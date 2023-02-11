namespace portscanerius
{
    partial class mainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startBtn = new System.Windows.Forms.Button();
            this.inputBx = new System.Windows.Forms.TextBox();
            this.PortscanLbl = new System.Windows.Forms.Label();
            this.hostnameBx = new System.Windows.Forms.TextBox();
            this.hostnameLbl = new System.Windows.Forms.Label();
            this.portLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Host = new System.Windows.Forms.ColumnHeader();
            this.Port = new System.Windows.Forms.ColumnHeader();
            this.timoutBx = new System.Windows.Forms.NumericUpDown();
            this.timoutLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timoutBx)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.startBtn.Location = new System.Drawing.Point(22, 152);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(206, 23);
            this.startBtn.TabIndex = 4;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // inputBx
            // 
            this.inputBx.Location = new System.Drawing.Point(99, 80);
            this.inputBx.Name = "inputBx";
            this.inputBx.Size = new System.Drawing.Size(129, 23);
            this.inputBx.TabIndex = 2;
            // 
            // PortscanLbl
            // 
            this.PortscanLbl.AutoSize = true;
            this.PortscanLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PortscanLbl.Location = new System.Drawing.Point(86, 18);
            this.PortscanLbl.Name = "PortscanLbl";
            this.PortscanLbl.Size = new System.Drawing.Size(72, 21);
            this.PortscanLbl.TabIndex = 5;
            this.PortscanLbl.Text = "Portscan";
            // 
            // hostnameBx
            // 
            this.hostnameBx.Location = new System.Drawing.Point(99, 51);
            this.hostnameBx.Name = "hostnameBx";
            this.hostnameBx.Size = new System.Drawing.Size(129, 23);
            this.hostnameBx.TabIndex = 1;
            // 
            // hostnameLbl
            // 
            this.hostnameLbl.AutoSize = true;
            this.hostnameLbl.Location = new System.Drawing.Point(31, 54);
            this.hostnameLbl.Name = "hostnameLbl";
            this.hostnameLbl.Size = new System.Drawing.Size(62, 15);
            this.hostnameLbl.TabIndex = 7;
            this.hostnameLbl.Text = "Hostname";
            // 
            // portLbl
            // 
            this.portLbl.AutoSize = true;
            this.portLbl.Location = new System.Drawing.Point(31, 83);
            this.portLbl.Name = "portLbl";
            this.portLbl.Size = new System.Drawing.Size(34, 15);
            this.portLbl.TabIndex = 8;
            this.portLbl.Text = "Ports";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Host,
            this.Port});
            this.listView1.Location = new System.Drawing.Point(22, 181);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(206, 160);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Host
            // 
            this.Host.Text = "Host";
            this.Host.Width = 100;
            // 
            // Port
            // 
            this.Port.Text = "Port";
            this.Port.Width = 100;
            // 
            // timoutBx
            // 
            this.timoutBx.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timoutBx.Location = new System.Drawing.Point(153, 109);
            this.timoutBx.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.timoutBx.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.timoutBx.Name = "timoutBx";
            this.timoutBx.Size = new System.Drawing.Size(75, 23);
            this.timoutBx.TabIndex = 3;
            this.timoutBx.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timoutLbl
            // 
            this.timoutLbl.AutoSize = true;
            this.timoutLbl.Location = new System.Drawing.Point(31, 111);
            this.timoutLbl.Name = "timoutLbl";
            this.timoutLbl.Size = new System.Drawing.Size(105, 15);
            this.timoutLbl.TabIndex = 12;
            this.timoutLbl.Text = "Timeout (seconds)";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 353);
            this.Controls.Add(this.timoutLbl);
            this.Controls.Add(this.timoutBx);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.portLbl);
            this.Controls.Add(this.hostnameLbl);
            this.Controls.Add(this.hostnameBx);
            this.Controls.Add(this.PortscanLbl);
            this.Controls.Add(this.inputBx);
            this.Controls.Add(this.startBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portscan";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timoutBx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button startBtn;
        private TextBox inputBx;
        private Label PortscanLbl;
        private TextBox hostnameBx;
        private Label hostnameLbl;
        private Label portLbl;
        private ListView listView1;
        private ColumnHeader Host;
        private ColumnHeader Port;
        private NumericUpDown timoutBx;
        private Label timoutLbl;
    }
}