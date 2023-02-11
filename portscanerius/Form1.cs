using System.Collections.ObjectModel;
using System.Net.Sockets;

namespace portscanerius
{
    public partial class mainForm : Form
    {
        private readonly object _lock = new object();
        private readonly ObservableCollection<KeyValuePair<string, int>> enabledPorts = new ObservableCollection<KeyValuePair<string, int>>();
        public mainForm()
        {
            InitializeComponent();
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            enabledPorts.Clear();

            string unparsedPortString = inputBx.Text;
            string[] ranges = unparsedPortString.Split(',', ';');
            foreach (string range in ranges)
            {
                string[] ports = range.Split('-');

                if (ports.Length == 0)
                    continue;
                
                if (ports.Length == 1)
                {
                    
                    int port;
                    if (!Int32.TryParse(ports[0], out port))
                        continue;

                    
                    await Task.Run(() => ScanPorts(hostnameBx.Text, port, port));
                    continue;
                }              
                if (ports.Length > 1)
                {
                    
                    int startport;
                    int endport;

                    if (!Int32.TryParse(ports[0], out startport) || !Int32.TryParse(ports[1], out endport))
                        continue;

                    await Task.Run(() => ScanPorts(hostnameBx.Text, startport, endport));
                }
            }
        }

        private async Task ScanPorts(string hostname,int startport, int endport)
        {
            List<Task> tasks = new List<Task>();
            for (int currentPort = startport; currentPort <= endport; currentPort++)
            {
                tasks.Add(ScanPort(hostname, currentPort));
            }
            //When all Tasks are initialized -> await
            await Task.WhenAll(tasks);
        }

        private async Task ScanPort(string hostname, int port)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                IAsyncResult result = tcpClient.BeginConnect(hostname, port, null, null);

                //Create Delay Task
                Task timeout = Task.Delay(TimeSpan.FromSeconds((double)timoutBx.Value));

                //Create Task for Connection
                Task finishedTask = Task.Factory.FromAsync(result, tcpClient.EndConnect);
                //If either Delay elapsed or the Connection connected successfully it will pass the await block
                Task completed = await Task.WhenAny(finishedTask, timeout);

                tcpClient.Close();

                //If the Connection connected successfully befor the delay elapsed it will add it to the list
                if (completed == finishedTask)
                {
                    //The Lock operator locks the list while the programm writes to it (this will prevent data corruption)
                    lock (_lock)
                    {
                        enabledPorts.Add(new KeyValuePair<string, int>(hostname, port));
                    }
                }
            }
        }

        private async void mainForm_Load(object sender, EventArgs e)
        {
            //This is not really clean, instead of rewrap the List once per second,
            //you should create a eventhandler like list.onchanged to handle the rewrap
            await Task.Run(() => rewrapList());
        }

        private void rewrapList()
        {
            Thread.Sleep(1000);
            
            this.Invoke(delegate
            {
                listView1.Items.Clear();
                foreach (var item in enabledPorts)
                {
                    var item1 = new ListViewItem(item.Key);
                    item1.SubItems.Add(new ListViewItem.ListViewSubItem(item1, item.Value.ToString()));
                    listView1.Items.Add(item1);
                }
            });

            rewrapList();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}