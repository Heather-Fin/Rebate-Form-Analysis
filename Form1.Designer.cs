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
            this.lbl_min_entry_time = new System.Windows.Forms.Label();
            this.lbl_min_entry_time_data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_record_num
            // 
            this.lbl_record_num.AutoSize = true;
            this.lbl_record_num.Location = new System.Drawing.Point(57, 140);
            this.lbl_record_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_record_num.Name = "lbl_record_num";
            this.lbl_record_num.Size = new System.Drawing.Size(151, 20);
            this.lbl_record_num.TabIndex = 0;
            this.lbl_record_num.Text = "Number of Records:";
            // 
            // lbl_record_num_data
            // 
            this.lbl_record_num_data.AutoSize = true;
            this.lbl_record_num_data.Location = new System.Drawing.Point(220, 140);
            this.lbl_record_num_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_record_num_data.Name = "lbl_record_num_data";
            this.lbl_record_num_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_record_num_data.TabIndex = 1;
            // 
            // lbl_min_entry_time
            // 
            this.lbl_min_entry_time.AutoSize = true;
            this.lbl_min_entry_time.Location = new System.Drawing.Point(57, 183);
            this.lbl_min_entry_time.Name = "lbl_min_entry_time";
            this.lbl_min_entry_time.Size = new System.Drawing.Size(155, 20);
            this.lbl_min_entry_time.TabIndex = 2;
            this.lbl_min_entry_time.Text = "Minimum Entry Time:";
            // 
            // lbl_min_entry_time_data
            // 
            this.lbl_min_entry_time_data.AutoSize = true;
            this.lbl_min_entry_time_data.Location = new System.Drawing.Point(219, 183);
            this.lbl_min_entry_time_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_min_entry_time_data.Name = "lbl_min_entry_time_data";
            this.lbl_min_entry_time_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_min_entry_time_data.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 702);
            this.Controls.Add(this.lbl_min_entry_time_data);
            this.Controls.Add(this.lbl_min_entry_time);
            this.Controls.Add(this.lbl_record_num_data);
            this.Controls.Add(this.lbl_record_num);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rebate Form Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_record_num;
        private System.Windows.Forms.Label lbl_record_num_data;
        private System.Windows.Forms.Label lbl_min_entry_time;
        private System.Windows.Forms.Label lbl_min_entry_time_data;
    }
}

