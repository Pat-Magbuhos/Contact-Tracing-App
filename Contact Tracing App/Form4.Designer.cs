
namespace Contact_Tracing_App
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.Exit = new System.Windows.Forms.Button();
            this.camlbl = new System.Windows.Forms.Label();
            this.camchoices = new System.Windows.Forms.ComboBox();
            this.campreview = new System.Windows.Forms.PictureBox();
            this.cptr = new System.Windows.Forms.Button();
            this.generateqr = new System.Windows.Forms.TextBox();
            this.camTimer = new System.Windows.Forms.Timer(this.components);
            this.generatebttn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.internetTime = new System.Windows.Forms.Timer(this.components);
            this.readbttn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.campreview)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Snow;
            this.Exit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(637, 406);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 32);
            this.Exit.TabIndex = 34;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // camlbl
            // 
            this.camlbl.AutoSize = true;
            this.camlbl.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camlbl.Location = new System.Drawing.Point(21, 20);
            this.camlbl.Name = "camlbl";
            this.camlbl.Size = new System.Drawing.Size(62, 14);
            this.camlbl.TabIndex = 35;
            this.camlbl.Text = "CAMERA";
            // 
            // camchoices
            // 
            this.camchoices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.camchoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camchoices.FormattingEnabled = true;
            this.camchoices.Location = new System.Drawing.Point(86, 17);
            this.camchoices.Name = "camchoices";
            this.camchoices.Size = new System.Drawing.Size(276, 21);
            this.camchoices.TabIndex = 36;
            // 
            // campreview
            // 
            this.campreview.Location = new System.Drawing.Point(24, 44);
            this.campreview.Name = "campreview";
            this.campreview.Size = new System.Drawing.Size(338, 234);
            this.campreview.TabIndex = 37;
            this.campreview.TabStop = false;
            // 
            // cptr
            // 
            this.cptr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cptr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptr.Location = new System.Drawing.Point(24, 294);
            this.cptr.Name = "cptr";
            this.cptr.Size = new System.Drawing.Size(75, 23);
            this.cptr.TabIndex = 38;
            this.cptr.Text = "CAPTURE";
            this.cptr.UseVisualStyleBackColor = false;
            this.cptr.Click += new System.EventHandler(this.cptr_Click);
            // 
            // generateqr
            // 
            this.generateqr.BackColor = System.Drawing.Color.Snow;
            this.generateqr.Location = new System.Drawing.Point(368, 44);
            this.generateqr.Multiline = true;
            this.generateqr.Name = "generateqr";
            this.generateqr.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.generateqr.Size = new System.Drawing.Size(321, 185);
            this.generateqr.TabIndex = 39;
            // 
            // camTimer
            // 
            this.camTimer.Tick += new System.EventHandler(this.camTimer_Tick);
            // 
            // generatebttn
            // 
            this.generatebttn.BackColor = System.Drawing.Color.Snow;
            this.generatebttn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatebttn.Location = new System.Drawing.Point(16, 407);
            this.generatebttn.Name = "generatebttn";
            this.generatebttn.Size = new System.Drawing.Size(83, 31);
            this.generatebttn.TabIndex = 40;
            this.generatebttn.Text = "GENERATE";
            this.generatebttn.UseVisualStyleBackColor = false;
            this.generatebttn.Click += new System.EventHandler(this.generatebttn_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.date.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(415, 9);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(34, 13);
            this.date.TabIndex = 41;
            this.date.Text = "Date";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.time.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(585, 9);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(35, 13);
            this.time.TabIndex = 42;
            this.time.Text = "Time";
            // 
            // internetTime
            // 
            this.internetTime.Tick += new System.EventHandler(this.internetTime_Tick);
            // 
            // readbttn
            // 
            this.readbttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.readbttn.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readbttn.Location = new System.Drawing.Point(287, 294);
            this.readbttn.Name = "readbttn";
            this.readbttn.Size = new System.Drawing.Size(75, 23);
            this.readbttn.TabIndex = 43;
            this.readbttn.Text = "READ";
            this.readbttn.UseVisualStyleBackColor = false;
            this.readbttn.Click += new System.EventHandler(this.readbttn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.readbttn);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.generatebttn);
            this.Controls.Add(this.generateqr);
            this.Controls.Add(this.cptr);
            this.Controls.Add(this.campreview);
            this.Controls.Add(this.camchoices);
            this.Controls.Add(this.camlbl);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_FormClosing);
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.campreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label camlbl;
        private System.Windows.Forms.ComboBox camchoices;
        private System.Windows.Forms.PictureBox campreview;
        private System.Windows.Forms.Button cptr;
        private System.Windows.Forms.TextBox generateqr;
        private System.Windows.Forms.Timer camTimer;
        private System.Windows.Forms.Button generatebttn;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Timer internetTime;
        private System.Windows.Forms.Button readbttn;
    }
}