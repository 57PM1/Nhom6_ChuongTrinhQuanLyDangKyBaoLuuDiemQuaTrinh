namespace QuanLiDuAn
{
    partial class form101
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_idhocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_tenhocky = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_muchocphi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa_mo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Tạo mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(383, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txt_idhocky,
            this.txt_tenhocky,
            this.txt_muchocphi,
            this.khoa_mo});
            this.dataGridView1.Location = new System.Drawing.Point(12, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(551, 260);
            this.dataGridView1.TabIndex = 3;
            // 
            // txt_idhocky
            // 
            this.txt_idhocky.HeaderText = "Học Kỳ ID";
            this.txt_idhocky.Name = "txt_idhocky";
            // 
            // txt_tenhocky
            // 
            this.txt_tenhocky.HeaderText = "Tên Học Kỳ";
            this.txt_tenhocky.Name = "txt_tenhocky";
            // 
            // txt_muchocphi
            // 
            this.txt_muchocphi.HeaderText = "Mức Học Phí";
            this.txt_muchocphi.Name = "txt_muchocphi";
            // 
            // khoa_mo
            // 
            this.khoa_mo.HeaderText = "Khóa/Mở";
            this.khoa_mo.Name = "khoa_mo";
            // 
            // form101
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 304);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "form101";
            this.Text = "Khởi tạo học kì và mức học phí";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_idhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_tenhocky;
        private System.Windows.Forms.DataGridViewTextBoxColumn txt_muchocphi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn khoa_mo;
    }
}