
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
            this.Exit = new System.Windows.Forms.Button();
            this.camlbl = new System.Windows.Forms.Label();
            this.camchoices = new System.Windows.Forms.ComboBox();
            this.campreview = new System.Windows.Forms.PictureBox();
            this.cptr = new System.Windows.Forms.Button();
            this.generateqr = new System.Windows.Forms.TextBox();
            this.camTimer = new System.Windows.Forms.Timer(this.components);
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
            this.camchoices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.camchoices.FormattingEnabled = true;
            this.camchoices.Location = new System.Drawing.Point(86, 17);
            this.camchoices.Name = "camchoices";
            this.camchoices.Size = new System.Drawing.Size(173, 21);
            this.camchoices.TabIndex = 36;
            // 
            // campreview
            // 
            this.campreview.Location = new System.Drawing.Point(24, 44);
            this.campreview.Name = "campreview";
            this.campreview.Size = new System.Drawing.Size(235, 148);
            this.campreview.TabIndex = 37;
            this.campreview.TabStop = false;
            // 
            // cptr
            // 
            this.cptr.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cptr.Location = new System.Drawing.Point(24, 198);
            this.cptr.Name = "cptr";
            this.cptr.Size = new System.Drawing.Size(75, 23);
            this.cptr.TabIndex = 38;
            this.cptr.Text = "CAPTURE";
            this.cptr.UseVisualStyleBackColor = true;
            this.cptr.Click += new System.EventHandler(this.cptr_Click);
            // 
            // generateqr
            // 
            this.generateqr.Location = new System.Drawing.Point(276, 18);
            this.generateqr.Multiline = true;
            this.generateqr.Name = "generateqr";
            this.generateqr.Size = new System.Drawing.Size(408, 289);
            this.generateqr.TabIndex = 39;
            // 
            // camTimer
            // 
            this.camTimer.Tick += new System.EventHandler(this.camTimer_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
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
    }
}