namespace Asg3_HXF180007
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
            this.lbl_record_num = new System.Windows.Forms.Label();
            this.lbl_record_num_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_record_num
            // 
            this.lbl_record_num.AutoSize = true;
            this.lbl_record_num.Location = new System.Drawing.Point(38, 91);
            this.lbl_record_num.Name = "lbl_record_num";
            this.lbl_record_num.Size = new System.Drawing.Size(102, 13);
            this.lbl_record_num.TabIndex = 0;
            this.lbl_record_num.Text = "Number of Records:";
            // 
            // lbl_record_num_data
            // 
            this.lbl_record_num_data.AutoSize = true;
            this.lbl_record_num_data.Location = new System.Drawing.Point(147, 91);
            this.lbl_record_num_data.Name = "lbl_record_num_data";
            this.lbl_record_num_data.Size = new System.Drawing.Size(0, 13);
            this.lbl_record_num_data.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 456);
            this.Controls.Add(this.lbl_record_num_data);
            this.Controls.Add(this.lbl_record_num);
            this.Name = "Form1";
            this.Text = "Rebate Form Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_record_num;
        private System.Windows.Forms.Label lbl_record_num_data;
    }
}

