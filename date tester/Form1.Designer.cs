namespace date_tester
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
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.lbldate = new System.Windows.Forms.Label();
            this.btnclick = new System.Windows.Forms.Button();
            this.lbldefault = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // date1
            // 
            this.date1.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.date1.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.date1.CustomFormat = "HH:mm";
            this.date1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1.Location = new System.Drawing.Point(28, 37);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(200, 20);
            this.date1.TabIndex = 0;
            // 
            // date2
            // 
            this.date2.CalendarMonthBackground = System.Drawing.SystemColors.HotTrack;
            this.date2.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.date2.CustomFormat = "HH:mm";
            this.date2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2.Location = new System.Drawing.Point(28, 91);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(200, 20);
            this.date2.TabIndex = 1;
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldate.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldate.Location = new System.Drawing.Point(34, 162);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(44, 16);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "not set";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnclick
            // 
            this.btnclick.Location = new System.Drawing.Point(276, 60);
            this.btnclick.Name = "btnclick";
            this.btnclick.Size = new System.Drawing.Size(75, 33);
            this.btnclick.TabIndex = 3;
            this.btnclick.Text = "Diff";
            this.btnclick.UseVisualStyleBackColor = true;
            this.btnclick.Click += new System.EventHandler(this.btnclick_Click);
            // 
            // lbldefault
            // 
            this.lbldefault.AutoSize = true;
            this.lbldefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbldefault.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldefault.Location = new System.Drawing.Point(34, 134);
            this.lbldefault.Name = "lbldefault";
            this.lbldefault.Size = new System.Drawing.Size(66, 16);
            this.lbldefault.TabIndex = 4;
            this.lbldefault.Text = "work times";
            this.lbldefault.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 214);
            this.Controls.Add(this.lbldefault);
            this.Controls.Add(this.btnclick);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.date1);
            this.Name = "Form1";
            this.Text = "Calculate times";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Button btnclick;
        private System.Windows.Forms.Label lbldefault;
    }
}

