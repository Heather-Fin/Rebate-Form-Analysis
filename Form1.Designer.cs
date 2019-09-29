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
            this.lbl_max_entry_time = new System.Windows.Forms.Label();
            this.lbl_max_entry_time_data = new System.Windows.Forms.Label();
            this.lbl_average_entry_time = new System.Windows.Forms.Label();
            this.lbl_total_time = new System.Windows.Forms.Label();
            this.lbl_backspace_count = new System.Windows.Forms.Label();
            this.lbl_total_time_data = new System.Windows.Forms.Label();
            this.lbl_backspace_count_data = new System.Windows.Forms.Label();
            this.btn_open_file = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbl_min_inner_time = new System.Windows.Forms.Label();
            this.lbl_max_inter_time = new System.Windows.Forms.Label();
            this.lbl_average_inter_time = new System.Windows.Forms.Label();
            this.lbl_min_inter_time_data = new System.Windows.Forms.Label();
            this.lbl_max_inter_time_data = new System.Windows.Forms.Label();
            this.lbl_average_inter_time_data = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbl_average_entry_time_data = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_record_num
            // 
            this.lbl_record_num.AutoSize = true;
            this.lbl_record_num.Location = new System.Drawing.Point(136, 86);
            this.lbl_record_num.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_record_num.Name = "lbl_record_num";
            this.lbl_record_num.Size = new System.Drawing.Size(151, 20);
            this.lbl_record_num.TabIndex = 0;
            this.lbl_record_num.Text = "Number of Records:";
            // 
            // lbl_record_num_data
            // 
            this.lbl_record_num_data.AutoSize = true;
            this.lbl_record_num_data.Location = new System.Drawing.Point(298, 86);
            this.lbl_record_num_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_record_num_data.Name = "lbl_record_num_data";
            this.lbl_record_num_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_record_num_data.TabIndex = 1;
            // 
            // lbl_min_entry_time
            // 
            this.lbl_min_entry_time.AutoSize = true;
            this.lbl_min_entry_time.Location = new System.Drawing.Point(134, 197);
            this.lbl_min_entry_time.Name = "lbl_min_entry_time";
            this.lbl_min_entry_time.Size = new System.Drawing.Size(155, 20);
            this.lbl_min_entry_time.TabIndex = 2;
            this.lbl_min_entry_time.Text = "Minimum Entry Time:";
            // 
            // lbl_min_entry_time_data
            // 
            this.lbl_min_entry_time_data.AutoSize = true;
            this.lbl_min_entry_time_data.Location = new System.Drawing.Point(298, 197);
            this.lbl_min_entry_time_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_min_entry_time_data.Name = "lbl_min_entry_time_data";
            this.lbl_min_entry_time_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_min_entry_time_data.TabIndex = 3;
            // 
            // lbl_max_entry_time
            // 
            this.lbl_max_entry_time.AutoSize = true;
            this.lbl_max_entry_time.Location = new System.Drawing.Point(129, 234);
            this.lbl_max_entry_time.Name = "lbl_max_entry_time";
            this.lbl_max_entry_time.Size = new System.Drawing.Size(159, 20);
            this.lbl_max_entry_time.TabIndex = 4;
            this.lbl_max_entry_time.Text = "Maximum Entry Time:";
            // 
            // lbl_max_entry_time_data
            // 
            this.lbl_max_entry_time_data.AutoSize = true;
            this.lbl_max_entry_time_data.Location = new System.Drawing.Point(298, 234);
            this.lbl_max_entry_time_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_max_entry_time_data.Name = "lbl_max_entry_time_data";
            this.lbl_max_entry_time_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_max_entry_time_data.TabIndex = 5;
            // 
            // lbl_average_entry_time
            // 
            this.lbl_average_entry_time.AutoSize = true;
            this.lbl_average_entry_time.Location = new System.Drawing.Point(135, 274);
            this.lbl_average_entry_time.Name = "lbl_average_entry_time";
            this.lbl_average_entry_time.Size = new System.Drawing.Size(151, 20);
            this.lbl_average_entry_time.TabIndex = 6;
            this.lbl_average_entry_time.Text = "Average Entry Time:";
            // 
            // lbl_total_time
            // 
            this.lbl_total_time.AutoSize = true;
            this.lbl_total_time.Location = new System.Drawing.Point(200, 123);
            this.lbl_total_time.Name = "lbl_total_time";
            this.lbl_total_time.Size = new System.Drawing.Size(86, 20);
            this.lbl_total_time.TabIndex = 8;
            this.lbl_total_time.Text = "Total Time:";
            // 
            // lbl_backspace_count
            // 
            this.lbl_backspace_count.AutoSize = true;
            this.lbl_backspace_count.Location = new System.Drawing.Point(147, 160);
            this.lbl_backspace_count.Name = "lbl_backspace_count";
            this.lbl_backspace_count.Size = new System.Drawing.Size(139, 20);
            this.lbl_backspace_count.TabIndex = 9;
            this.lbl_backspace_count.Text = "Backspace Count:";
            // 
            // lbl_total_time_data
            // 
            this.lbl_total_time_data.AutoSize = true;
            this.lbl_total_time_data.Location = new System.Drawing.Point(298, 123);
            this.lbl_total_time_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_total_time_data.Name = "lbl_total_time_data";
            this.lbl_total_time_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_total_time_data.TabIndex = 10;
            // 
            // lbl_backspace_count_data
            // 
            this.lbl_backspace_count_data.AutoSize = true;
            this.lbl_backspace_count_data.Location = new System.Drawing.Point(298, 160);
            this.lbl_backspace_count_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_backspace_count_data.Name = "lbl_backspace_count_data";
            this.lbl_backspace_count_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_backspace_count_data.TabIndex = 11;
            // 
            // btn_open_file
            // 
            this.btn_open_file.Location = new System.Drawing.Point(288, 25);
            this.btn_open_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(112, 35);
            this.btn_open_file.TabIndex = 12;
            this.btn_open_file.Text = "Open File";
            this.btn_open_file.UseVisualStyleBackColor = true;
            this.btn_open_file.Click += new System.EventHandler(this.Btn_open_file_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "*.txt";
            this.openFileDialog1.Filter = "\"Text file (*.txt) | .txt\"";
            this.openFileDialog1.RestoreDirectory = true;
            this.openFileDialog1.Title = "Browse Rebate Forms";
            // 
            // lbl_min_inner_time
            // 
            this.lbl_min_inner_time.AutoSize = true;
            this.lbl_min_inner_time.Location = new System.Drawing.Point(81, 311);
            this.lbl_min_inner_time.Name = "lbl_min_inner_time";
            this.lbl_min_inner_time.Size = new System.Drawing.Size(208, 20);
            this.lbl_min_inner_time.TabIndex = 13;
            this.lbl_min_inner_time.Text = "Minimum Inter-Record Time:";
            // 
            // lbl_max_inter_time
            // 
            this.lbl_max_inter_time.AutoSize = true;
            this.lbl_max_inter_time.Location = new System.Drawing.Point(76, 349);
            this.lbl_max_inter_time.Name = "lbl_max_inter_time";
            this.lbl_max_inter_time.Size = new System.Drawing.Size(212, 20);
            this.lbl_max_inter_time.TabIndex = 14;
            this.lbl_max_inter_time.Text = "Maximum Inter-Record Time:";
            // 
            // lbl_average_inter_time
            // 
            this.lbl_average_inter_time.AutoSize = true;
            this.lbl_average_inter_time.Location = new System.Drawing.Point(82, 389);
            this.lbl_average_inter_time.Name = "lbl_average_inter_time";
            this.lbl_average_inter_time.Size = new System.Drawing.Size(204, 20);
            this.lbl_average_inter_time.TabIndex = 15;
            this.lbl_average_inter_time.Text = "Average Inter-Record Time:";
            // 
            // lbl_min_inter_time_data
            // 
            this.lbl_min_inter_time_data.AutoSize = true;
            this.lbl_min_inter_time_data.Location = new System.Drawing.Point(297, 311);
            this.lbl_min_inter_time_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_min_inter_time_data.Name = "lbl_min_inter_time_data";
            this.lbl_min_inter_time_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_min_inter_time_data.TabIndex = 16;
            // 
            // lbl_max_inter_time_data
            // 
            this.lbl_max_inter_time_data.AutoSize = true;
            this.lbl_max_inter_time_data.Location = new System.Drawing.Point(297, 349);
            this.lbl_max_inter_time_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_max_inter_time_data.Name = "lbl_max_inter_time_data";
            this.lbl_max_inter_time_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_max_inter_time_data.TabIndex = 17;
            // 
            // lbl_average_inter_time_data
            // 
            this.lbl_average_inter_time_data.AutoSize = true;
            this.lbl_average_inter_time_data.Location = new System.Drawing.Point(297, 389);
            this.lbl_average_inter_time_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_average_inter_time_data.Name = "lbl_average_inter_time_data";
            this.lbl_average_inter_time_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_average_inter_time_data.TabIndex = 18;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 446);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(682, 32);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(242, 25);
            this.toolStripStatusLabel1.Text = "Open a rebate file to analyze.";
            // 
            // lbl_average_entry_time_data
            // 
            this.lbl_average_entry_time_data.AutoSize = true;
            this.lbl_average_entry_time_data.Location = new System.Drawing.Point(298, 274);
            this.lbl_average_entry_time_data.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_average_entry_time_data.Name = "lbl_average_entry_time_data";
            this.lbl_average_entry_time_data.Size = new System.Drawing.Size(0, 20);
            this.lbl_average_entry_time_data.TabIndex = 20;
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_open_file;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 478);
            this.Controls.Add(this.lbl_average_entry_time_data);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbl_average_inter_time_data);
            this.Controls.Add(this.lbl_max_inter_time_data);
            this.Controls.Add(this.lbl_min_inter_time_data);
            this.Controls.Add(this.lbl_average_inter_time);
            this.Controls.Add(this.lbl_max_inter_time);
            this.Controls.Add(this.lbl_min_inner_time);
            this.Controls.Add(this.btn_open_file);
            this.Controls.Add(this.lbl_backspace_count_data);
            this.Controls.Add(this.lbl_total_time_data);
            this.Controls.Add(this.lbl_backspace_count);
            this.Controls.Add(this.lbl_total_time);
            this.Controls.Add(this.lbl_average_entry_time);
            this.Controls.Add(this.lbl_max_entry_time_data);
            this.Controls.Add(this.lbl_max_entry_time);
            this.Controls.Add(this.lbl_min_entry_time_data);
            this.Controls.Add(this.lbl_min_entry_time);
            this.Controls.Add(this.lbl_record_num_data);
            this.Controls.Add(this.lbl_record_num);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Rebate Form Analysis";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_record_num;
        private System.Windows.Forms.Label lbl_record_num_data;
        private System.Windows.Forms.Label lbl_min_entry_time;
        private System.Windows.Forms.Label lbl_min_entry_time_data;
        private System.Windows.Forms.Label lbl_max_entry_time;
        private System.Windows.Forms.Label lbl_max_entry_time_data;
        private System.Windows.Forms.Label lbl_average_entry_time;
        private System.Windows.Forms.Label lbl_total_time;
        private System.Windows.Forms.Label lbl_backspace_count;
        private System.Windows.Forms.Label lbl_total_time_data;
        private System.Windows.Forms.Label lbl_backspace_count_data;
        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbl_min_inner_time;
        private System.Windows.Forms.Label lbl_max_inter_time;
        private System.Windows.Forms.Label lbl_average_inter_time;
        private System.Windows.Forms.Label lbl_min_inter_time_data;
        private System.Windows.Forms.Label lbl_max_inter_time_data;
        private System.Windows.Forms.Label lbl_average_inter_time_data;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbl_average_entry_time_data;
    }
}

