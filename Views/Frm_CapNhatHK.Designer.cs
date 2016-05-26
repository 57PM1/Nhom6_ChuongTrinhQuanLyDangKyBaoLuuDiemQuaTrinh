namespace QuanLiDuAn
{
    partial class CapNhatHK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hockyID = new System.Windows.Forms.TextBox();
            this.hocphi = new System.Windows.Forms.TextBox();
            this.hocky = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.trangthai = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Học Phí";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Học Kỳ";
            // 
            // hockyID
            // 
            this.hockyID.Enabled = false;
            this.hockyID.Location = new System.Drawing.Point(154, 44);
            this.hockyID.Multiline = true;
            this.hockyID.Name = "hockyID";
            this.hockyID.Size = new System.Drawing.Size(170, 25);
            this.hockyID.TabIndex = 3;
            this.hockyID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // hocphi
            // 
            this.hocphi.Location = new System.Drawing.Point(154, 119);
            this.hocphi.Multiline = true;
            this.hocphi.Name = "hocphi";
            this.hocphi.Size = new System.Drawing.Size(170, 25);
            this.hocphi.TabIndex = 4;
            // 
            // hocky
            // 
            this.hocky.Location = new System.Drawing.Point(154, 79);
            this.hocky.Multiline = true;
            this.hocky.Name = "hocky";
            this.hocky.Size = new System.Drawing.Size(170, 25);
            this.hocky.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(249, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // trangthai
            // 
            this.trangthai.AutoSize = true;
            this.trangthai.Location = new System.Drawing.Point(184, 175);
            this.trangthai.Name = "trangthai";
            this.trangthai.Size = new System.Drawing.Size(70, 17);
            this.trangthai.TabIndex = 8;
            this.trangthai.TabStop = true;
            this.trangthai.Text = "Khóa/Mở";
            this.trangthai.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trạng Thái";
            // 
            // CapNhatHK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trangthai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hocky);
            this.Controls.Add(this.hocphi);
            this.Controls.Add(this.hockyID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CapNhatHK";
            this.Text = "Cập Nhật Học Kỳ";
            this.Load += new System.EventHandler(this.CapNhatHK_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hockyID;
        private System.Windows.Forms.TextBox hocphi;
        private System.Windows.Forms.TextBox hocky;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton trangthai;
        private System.Windows.Forms.Label label4;
    }
}