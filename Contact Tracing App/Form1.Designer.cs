
namespace Contact_Tracing_App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtbxFN = new System.Windows.Forms.TextBox();
            this.fn = new System.Windows.Forms.Label();
            this.txtbxMN = new System.Windows.Forms.TextBox();
            this.mn = new System.Windows.Forms.Label();
            this.txtbxLN = new System.Windows.Forms.TextBox();
            this.ln = new System.Windows.Forms.Label();
            this.personalinfo = new System.Windows.Forms.Label();
            this.txtbxSTRT = new System.Windows.Forms.TextBox();
            this.strt = new System.Windows.Forms.Label();
            this.txtbxBRNGY = new System.Windows.Forms.TextBox();
            this.brgy = new System.Windows.Forms.Label();
            this.txtbxPRV = new System.Windows.Forms.TextBox();
            this.prv = new System.Windows.Forms.Label();
            this.txtbxAG = new System.Windows.Forms.TextBox();
            this.ag = new System.Windows.Forms.Label();
            this.dt = new System.Windows.Forms.Label();
            this.txtbxTP = new System.Windows.Forms.TextBox();
            this.tp = new System.Windows.Forms.Label();
            this.bttnsave = new System.Windows.Forms.Button();
            this.txtbxSYMPTMS = new System.Windows.Forms.TextBox();
            this.symptms = new System.Windows.Forms.Label();
            this.lst = new System.Windows.Forms.Button();
            this.health = new System.Windows.Forms.Label();
            this.spcfy = new System.Windows.Forms.Label();
            this.txtbxSPCFY = new System.Windows.Forms.TextBox();
            this.prvcy = new System.Windows.Forms.Button();
            this.txtbxCNTCT = new System.Windows.Forms.TextBox();
            this.cntct = new System.Windows.Forms.Label();
            this.adminbttn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.time = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.qrscan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbxFN
            // 
            this.txtbxFN.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxFN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxFN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxFN.Location = new System.Drawing.Point(39, 67);
            this.txtbxFN.Name = "txtbxFN";
            this.txtbxFN.Size = new System.Drawing.Size(208, 25);
            this.txtbxFN.TabIndex = 0;
            this.txtbxFN.Text = "--Ex: Juan--";
            this.txtbxFN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fn
            // 
            this.fn.AutoSize = true;
            this.fn.BackColor = System.Drawing.Color.Transparent;
            this.fn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fn.Location = new System.Drawing.Point(113, 95);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(85, 13);
            this.fn.TabIndex = 1;
            this.fn.Text = "FIRST NAME";
            // 
            // txtbxMN
            // 
            this.txtbxMN.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxMN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxMN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxMN.Location = new System.Drawing.Point(251, 67);
            this.txtbxMN.Name = "txtbxMN";
            this.txtbxMN.Size = new System.Drawing.Size(208, 25);
            this.txtbxMN.TabIndex = 2;
            this.txtbxMN.Text = "--Ex: Raymundo--";
            this.txtbxMN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mn
            // 
            this.mn.AutoSize = true;
            this.mn.BackColor = System.Drawing.Color.Transparent;
            this.mn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mn.Location = new System.Drawing.Point(305, 95);
            this.mn.Name = "mn";
            this.mn.Size = new System.Drawing.Size(96, 13);
            this.mn.TabIndex = 3;
            this.mn.Text = "MIDDLE NAME";
            // 
            // txtbxLN
            // 
            this.txtbxLN.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxLN.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxLN.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxLN.Location = new System.Drawing.Point(463, 67);
            this.txtbxLN.Name = "txtbxLN";
            this.txtbxLN.Size = new System.Drawing.Size(208, 25);
            this.txtbxLN.TabIndex = 4;
            this.txtbxLN.Text = "--Ex: Dela Cruz--";
            this.txtbxLN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ln
            // 
            this.ln.AutoSize = true;
            this.ln.BackColor = System.Drawing.Color.Transparent;
            this.ln.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ln.Location = new System.Drawing.Point(533, 95);
            this.ln.Name = "ln";
            this.ln.Size = new System.Drawing.Size(79, 13);
            this.ln.TabIndex = 5;
            this.ln.Text = "LAST NAME";
            // 
            // personalinfo
            // 
            this.personalinfo.AutoSize = true;
            this.personalinfo.BackColor = System.Drawing.Color.Transparent;
            this.personalinfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.personalinfo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalinfo.Location = new System.Drawing.Point(253, 42);
            this.personalinfo.Name = "personalinfo";
            this.personalinfo.Size = new System.Drawing.Size(257, 18);
            this.personalinfo.TabIndex = 6;
            this.personalinfo.Text = "-PERSONAL INFORMATION-";
            // 
            // txtbxSTRT
            // 
            this.txtbxSTRT.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxSTRT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSTRT.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxSTRT.Location = new System.Drawing.Point(39, 126);
            this.txtbxSTRT.Name = "txtbxSTRT";
            this.txtbxSTRT.Size = new System.Drawing.Size(242, 25);
            this.txtbxSTRT.TabIndex = 7;
            this.txtbxSTRT.Text = "--Ex: B1 L3 Harurut Street--";
            this.txtbxSTRT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // strt
            // 
            this.strt.AutoSize = true;
            this.strt.BackColor = System.Drawing.Color.Transparent;
            this.strt.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.strt.Location = new System.Drawing.Point(91, 163);
            this.strt.Name = "strt";
            this.strt.Size = new System.Drawing.Size(118, 13);
            this.strt.TabIndex = 8;
            this.strt.Text = "STREET ADDRESS";
            // 
            // txtbxBRNGY
            // 
            this.txtbxBRNGY.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxBRNGY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxBRNGY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxBRNGY.Location = new System.Drawing.Point(287, 126);
            this.txtbxBRNGY.Name = "txtbxBRNGY";
            this.txtbxBRNGY.Size = new System.Drawing.Size(187, 25);
            this.txtbxBRNGY.TabIndex = 9;
            this.txtbxBRNGY.Text = "--Ex: Barangay Anonas--";
            this.txtbxBRNGY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // brgy
            // 
            this.brgy.AutoSize = true;
            this.brgy.BackColor = System.Drawing.Color.Transparent;
            this.brgy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brgy.Location = new System.Drawing.Point(338, 163);
            this.brgy.Name = "brgy";
            this.brgy.Size = new System.Drawing.Size(76, 13);
            this.brgy.TabIndex = 10;
            this.brgy.Text = "BARANGAY";
            // 
            // txtbxPRV
            // 
            this.txtbxPRV.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxPRV.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPRV.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxPRV.Location = new System.Drawing.Point(480, 126);
            this.txtbxPRV.Name = "txtbxPRV";
            this.txtbxPRV.Size = new System.Drawing.Size(250, 25);
            this.txtbxPRV.TabIndex = 11;
            this.txtbxPRV.Text = "--Ex: Metro Manila, Quezon City--";
            this.txtbxPRV.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prv
            // 
            this.prv.AutoSize = true;
            this.prv.BackColor = System.Drawing.Color.Transparent;
            this.prv.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prv.Location = new System.Drawing.Point(513, 163);
            this.prv.Name = "prv";
            this.prv.Size = new System.Drawing.Size(200, 13);
            this.prv.TabIndex = 12;
            this.prv.Text = "PROVINCE AND MUNICIPALITY";
            // 
            // txtbxAG
            // 
            this.txtbxAG.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxAG.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAG.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxAG.Location = new System.Drawing.Point(39, 203);
            this.txtbxAG.Name = "txtbxAG";
            this.txtbxAG.Size = new System.Drawing.Size(82, 25);
            this.txtbxAG.TabIndex = 13;
            this.txtbxAG.Text = "--Ex: 18 --";
            this.txtbxAG.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ag
            // 
            this.ag.AutoSize = true;
            this.ag.BackColor = System.Drawing.Color.Transparent;
            this.ag.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag.Location = new System.Drawing.Point(62, 231);
            this.ag.Name = "ag";
            this.ag.Size = new System.Drawing.Size(33, 13);
            this.ag.TabIndex = 14;
            this.ag.Text = "AGE";
            // 
            // dt
            // 
            this.dt.AutoSize = true;
            this.dt.BackColor = System.Drawing.Color.Transparent;
            this.dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt.Location = new System.Drawing.Point(179, 231);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(0, 13);
            this.dt.TabIndex = 16;
            // 
            // txtbxTP
            // 
            this.txtbxTP.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxTP.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxTP.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxTP.Location = new System.Drawing.Point(39, 383);
            this.txtbxTP.Name = "txtbxTP";
            this.txtbxTP.Size = new System.Drawing.Size(101, 25);
            this.txtbxTP.TabIndex = 17;
            this.txtbxTP.Text = "--Ex: 36.5°C--";
            this.txtbxTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tp
            // 
            this.tp.AutoSize = true;
            this.tp.BackColor = System.Drawing.Color.Transparent;
            this.tp.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tp.Location = new System.Drawing.Point(36, 367);
            this.tp.Name = "tp";
            this.tp.Size = new System.Drawing.Size(99, 13);
            this.tp.TabIndex = 18;
            this.tp.Text = "TEMPERATURE";
            // 
            // bttnsave
            // 
            this.bttnsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bttnsave.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnsave.Location = new System.Drawing.Point(39, 432);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(108, 32);
            this.bttnsave.TabIndex = 19;
            this.bttnsave.Text = "SUBMIT";
            this.bttnsave.UseVisualStyleBackColor = false;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // txtbxSYMPTMS
            // 
            this.txtbxSYMPTMS.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxSYMPTMS.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSYMPTMS.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxSYMPTMS.Location = new System.Drawing.Point(39, 327);
            this.txtbxSYMPTMS.Name = "txtbxSYMPTMS";
            this.txtbxSYMPTMS.Size = new System.Drawing.Size(101, 25);
            this.txtbxSYMPTMS.TabIndex = 20;
            this.txtbxSYMPTMS.Text = "--Yes/No--";
            this.txtbxSYMPTMS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // symptms
            // 
            this.symptms.AutoSize = true;
            this.symptms.BackColor = System.Drawing.Color.Transparent;
            this.symptms.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symptms.Location = new System.Drawing.Point(36, 311);
            this.symptms.Name = "symptms";
            this.symptms.Size = new System.Drawing.Size(191, 13);
            this.symptms.TabIndex = 21;
            this.symptms.Text = "ARE YOU EXPERIENCING ANY";
            // 
            // lst
            // 
            this.lst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lst.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lst.Location = new System.Drawing.Point(223, 307);
            this.lst.Name = "lst";
            this.lst.Size = new System.Drawing.Size(165, 19);
            this.lst.TabIndex = 22;
            this.lst.Text = "COVID-19 SYMPTOMS?\r\n";
            this.lst.UseVisualStyleBackColor = false;
            this.lst.Click += new System.EventHandler(this.lst_Click);
            // 
            // health
            // 
            this.health.AutoSize = true;
            this.health.BackColor = System.Drawing.Color.Transparent;
            this.health.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.health.Location = new System.Drawing.Point(268, 274);
            this.health.Name = "health";
            this.health.Size = new System.Drawing.Size(230, 18);
            this.health.TabIndex = 23;
            this.health.Text = "-HEALTH DECLARATION-";
            this.health.Click += new System.EventHandler(this.health_Click);
            // 
            // spcfy
            // 
            this.spcfy.AutoSize = true;
            this.spcfy.BackColor = System.Drawing.Color.Transparent;
            this.spcfy.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spcfy.Location = new System.Drawing.Point(415, 311);
            this.spcfy.Name = "spcfy";
            this.spcfy.Size = new System.Drawing.Size(167, 13);
            this.spcfy.TabIndex = 24;
            this.spcfy.Text = "IF YES, PLEASE SPECIFY:";
            // 
            // txtbxSPCFY
            // 
            this.txtbxSPCFY.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxSPCFY.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxSPCFY.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxSPCFY.Location = new System.Drawing.Point(418, 327);
            this.txtbxSPCFY.Name = "txtbxSPCFY";
            this.txtbxSPCFY.Size = new System.Drawing.Size(101, 25);
            this.txtbxSPCFY.TabIndex = 25;
            this.txtbxSPCFY.Text = "--Ex: Fever--";
            this.txtbxSPCFY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prvcy
            // 
            this.prvcy.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("prvcy.BackgroundImage")));
            this.prvcy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.prvcy.Location = new System.Drawing.Point(16, 11);
            this.prvcy.Name = "prvcy";
            this.prvcy.Size = new System.Drawing.Size(48, 43);
            this.prvcy.TabIndex = 26;
            this.prvcy.UseVisualStyleBackColor = true;
            this.prvcy.Click += new System.EventHandler(this.prvcy_Click);
            // 
            // txtbxCNTCT
            // 
            this.txtbxCNTCT.BackColor = System.Drawing.SystemColors.Info;
            this.txtbxCNTCT.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxCNTCT.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtbxCNTCT.Location = new System.Drawing.Point(130, 203);
            this.txtbxCNTCT.Name = "txtbxCNTCT";
            this.txtbxCNTCT.Size = new System.Drawing.Size(139, 25);
            this.txtbxCNTCT.TabIndex = 27;
            this.txtbxCNTCT.Text = "--Ex: 09510037642--";
            this.txtbxCNTCT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cntct
            // 
            this.cntct.AutoSize = true;
            this.cntct.BackColor = System.Drawing.Color.Transparent;
            this.cntct.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cntct.Location = new System.Drawing.Point(136, 231);
            this.cntct.Name = "cntct";
            this.cntct.Size = new System.Drawing.Size(122, 13);
            this.cntct.TabIndex = 28;
            this.cntct.Text = "CONTACT NUMBER";
            this.cntct.Click += new System.EventHandler(this.cntct_Click);
            // 
            // adminbttn
            // 
            this.adminbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.adminbttn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminbttn.Location = new System.Drawing.Point(16, 502);
            this.adminbttn.Name = "adminbttn";
            this.adminbttn.Size = new System.Drawing.Size(64, 32);
            this.adminbttn.TabIndex = 29;
            this.adminbttn.Text = "Admin";
            this.adminbttn.UseVisualStyleBackColor = false;
            this.adminbttn.Click += new System.EventHandler(this.adminbttn_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(505, 12);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(34, 13);
            this.date.TabIndex = 30;
            this.date.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.time.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(685, 12);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(35, 13);
            this.time.TabIndex = 31;
            this.time.Text = "Time";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Snow;
            this.Exit.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(688, 502);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 32);
            this.Exit.TabIndex = 32;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // qrscan
            // 
            this.qrscan.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.qrscan.Location = new System.Drawing.Point(182, 383);
            this.qrscan.Name = "qrscan";
            this.qrscan.Size = new System.Drawing.Size(115, 81);
            this.qrscan.TabIndex = 33;
            this.qrscan.Text = "SMART SCANNER";
            this.qrscan.UseVisualStyleBackColor = true;
            this.qrscan.Click += new System.EventHandler(this.qrscan_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(765, 546);
            this.Controls.Add(this.qrscan);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.adminbttn);
            this.Controls.Add(this.cntct);
            this.Controls.Add(this.txtbxCNTCT);
            this.Controls.Add(this.prvcy);
            this.Controls.Add(this.txtbxSPCFY);
            this.Controls.Add(this.spcfy);
            this.Controls.Add(this.health);
            this.Controls.Add(this.lst);
            this.Controls.Add(this.symptms);
            this.Controls.Add(this.txtbxSYMPTMS);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.tp);
            this.Controls.Add(this.txtbxTP);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.ag);
            this.Controls.Add(this.txtbxAG);
            this.Controls.Add(this.prv);
            this.Controls.Add(this.txtbxPRV);
            this.Controls.Add(this.brgy);
            this.Controls.Add(this.txtbxBRNGY);
            this.Controls.Add(this.strt);
            this.Controls.Add(this.txtbxSTRT);
            this.Controls.Add(this.personalinfo);
            this.Controls.Add(this.ln);
            this.Controls.Add(this.txtbxLN);
            this.Controls.Add(this.mn);
            this.Controls.Add(this.txtbxMN);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.txtbxFN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbxFN;
        private System.Windows.Forms.Label fn;
        private System.Windows.Forms.TextBox txtbxMN;
        private System.Windows.Forms.Label mn;
        private System.Windows.Forms.TextBox txtbxLN;
        private System.Windows.Forms.Label ln;
        private System.Windows.Forms.Label personalinfo;
        private System.Windows.Forms.TextBox txtbxSTRT;
        private System.Windows.Forms.Label strt;
        private System.Windows.Forms.TextBox txtbxBRNGY;
        private System.Windows.Forms.Label brgy;
        private System.Windows.Forms.TextBox txtbxPRV;
        private System.Windows.Forms.Label prv;
        private System.Windows.Forms.TextBox txtbxAG;
        private System.Windows.Forms.Label ag;
        private System.Windows.Forms.Label dt;
        private System.Windows.Forms.TextBox txtbxTP;
        private System.Windows.Forms.Label tp;
        private System.Windows.Forms.Button bttnsave;
        private System.Windows.Forms.TextBox txtbxSYMPTMS;
        private System.Windows.Forms.Label symptms;
        private System.Windows.Forms.Button lst;
        private System.Windows.Forms.Label health;
        private System.Windows.Forms.Label spcfy;
        private System.Windows.Forms.TextBox txtbxSPCFY;
        private System.Windows.Forms.Button prvcy;
        private System.Windows.Forms.TextBox txtbxCNTCT;
        private System.Windows.Forms.Label cntct;
        private System.Windows.Forms.Button adminbttn;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button qrscan;
    }
}

