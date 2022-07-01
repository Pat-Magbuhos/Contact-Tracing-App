
namespace Contact_Tracing_App
{
    partial class Form5
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
            this.Exit = new System.Windows.Forms.Button();
            this.bttngenerate = new System.Windows.Forms.Button();
            this.qrlabel = new System.Windows.Forms.Label();
            this.txtbxinput = new System.Windows.Forms.TextBox();
            this.qrpic = new System.Windows.Forms.PictureBox();
            this.bttnsave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).BeginInit();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Snow;
            this.Exit.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(405, 528);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(65, 32);
            this.Exit.TabIndex = 35;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // bttngenerate
            // 
            this.bttngenerate.Location = new System.Drawing.Point(395, 496);
            this.bttngenerate.Name = "bttngenerate";
            this.bttngenerate.Size = new System.Drawing.Size(75, 23);
            this.bttngenerate.TabIndex = 36;
            this.bttngenerate.Text = "GENERATE";
            this.bttngenerate.UseVisualStyleBackColor = true;
            this.bttngenerate.Click += new System.EventHandler(this.bttngenerate_Click);
            // 
            // qrlabel
            // 
            this.qrlabel.AutoSize = true;
            this.qrlabel.Location = new System.Drawing.Point(43, 18);
            this.qrlabel.Name = "qrlabel";
            this.qrlabel.Size = new System.Drawing.Size(56, 13);
            this.qrlabel.TabIndex = 37;
            this.qrlabel.Text = "QR CODE";
            // 
            // txtbxinput
            // 
            this.txtbxinput.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxinput.Location = new System.Drawing.Point(46, 399);
            this.txtbxinput.Multiline = true;
            this.txtbxinput.Name = "txtbxinput";
            this.txtbxinput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtbxinput.Size = new System.Drawing.Size(424, 80);
            this.txtbxinput.TabIndex = 38;
            this.txtbxinput.Text = "First Name:\r\nMiddle Name:\r\nLast Name:\r\nStreet Address:\r\nBarangay:\r\nProvince and M" +
    "unicipality:\r\nAge:\r\nContact Number:\r\nTemperature:\r\nExperiencing any Covid-19 Sym" +
    "ptoms? \r\nSpecification:";
            // 
            // qrpic
            // 
            this.qrpic.BackColor = System.Drawing.Color.White;
            this.qrpic.Location = new System.Drawing.Point(46, 45);
            this.qrpic.Name = "qrpic";
            this.qrpic.Size = new System.Drawing.Size(424, 348);
            this.qrpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.qrpic.TabIndex = 39;
            this.qrpic.TabStop = false;
            // 
            // bttnsave
            // 
            this.bttnsave.Location = new System.Drawing.Point(46, 496);
            this.bttnsave.Name = "bttnsave";
            this.bttnsave.Size = new System.Drawing.Size(75, 23);
            this.bttnsave.TabIndex = 40;
            this.bttnsave.Text = "SAVE QR";
            this.bttnsave.UseVisualStyleBackColor = true;
            this.bttnsave.Click += new System.EventHandler(this.bttnsave_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 572);
            this.Controls.Add(this.bttnsave);
            this.Controls.Add(this.qrpic);
            this.Controls.Add(this.txtbxinput);
            this.Controls.Add(this.qrlabel);
            this.Controls.Add(this.bttngenerate);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button bttngenerate;
        private System.Windows.Forms.Label qrlabel;
        private System.Windows.Forms.TextBox txtbxinput;
        private System.Windows.Forms.PictureBox qrpic;
        private System.Windows.Forms.Button bttnsave;
    }
}