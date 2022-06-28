
namespace Contact_Tracing_App
{
    partial class Form3
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
            this.shwrcrds = new System.Windows.Forms.Button();
            this.rslts = new System.Windows.Forms.TextBox();
            this.dateTimeFilter = new System.Windows.Forms.DateTimePicker();
            this.fltrbttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Papyrus", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(582, 414);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(92, 24);
            this.Exit.TabIndex = 34;
            this.Exit.Text = "Close";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // shwrcrds
            // 
            this.shwrcrds.Location = new System.Drawing.Point(36, 21);
            this.shwrcrds.Name = "shwrcrds";
            this.shwrcrds.Size = new System.Drawing.Size(128, 23);
            this.shwrcrds.TabIndex = 35;
            this.shwrcrds.Text = "Show Records";
            this.shwrcrds.UseVisualStyleBackColor = true;
            this.shwrcrds.Click += new System.EventHandler(this.shwrcrds_Click);
            // 
            // rslts
            // 
            this.rslts.BackColor = System.Drawing.SystemColors.Window;
            this.rslts.Location = new System.Drawing.Point(36, 51);
            this.rslts.Multiline = true;
            this.rslts.Name = "rslts";
            this.rslts.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.rslts.Size = new System.Drawing.Size(638, 348);
            this.rslts.TabIndex = 36;
            // 
            // dateTimeFilter
            // 
            this.dateTimeFilter.Location = new System.Drawing.Point(355, 25);
            this.dateTimeFilter.Name = "dateTimeFilter";
            this.dateTimeFilter.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFilter.TabIndex = 37;
            // 
            // fltrbttn
            // 
            this.fltrbttn.Location = new System.Drawing.Point(599, 25);
            this.fltrbttn.Name = "fltrbttn";
            this.fltrbttn.Size = new System.Drawing.Size(75, 23);
            this.fltrbttn.TabIndex = 38;
            this.fltrbttn.Text = "Go";
            this.fltrbttn.UseVisualStyleBackColor = true;
            this.fltrbttn.Click += new System.EventHandler(this.fltrbttn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.fltrbttn);
            this.Controls.Add(this.dateTimeFilter);
            this.Controls.Add(this.rslts);
            this.Controls.Add(this.shwrcrds);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button shwrcrds;
        private System.Windows.Forms.TextBox rslts;
        private System.Windows.Forms.DateTimePicker dateTimeFilter;
        private System.Windows.Forms.Button fltrbttn;
    }
}