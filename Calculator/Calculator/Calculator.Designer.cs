namespace Calculator
{
    partial class Calculator
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoThuNhat = new System.Windows.Forms.TextBox();
            this.txtSoThuHai = new System.Windows.Forms.TextBox();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1000, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHƯƠNG TRÌNH TÍNH TOÁN ĐƠN GIẢN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số thứ nhất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số thứ hai";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 197);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kết quả";
            // 
            // txtSoThuNhat
            // 
            this.txtSoThuNhat.Location = new System.Drawing.Point(242, 44);
            this.txtSoThuNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoThuNhat.Name = "txtSoThuNhat";
            this.txtSoThuNhat.Size = new System.Drawing.Size(328, 27);
            this.txtSoThuNhat.TabIndex = 4;
            // 
            // txtSoThuHai
            // 
            this.txtSoThuHai.Location = new System.Drawing.Point(242, 117);
            this.txtSoThuHai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoThuHai.Name = "txtSoThuHai";
            this.txtSoThuHai.Size = new System.Drawing.Size(328, 27);
            this.txtSoThuHai.TabIndex = 5;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(242, 190);
            this.txtRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(328, 27);
            this.txtRes.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoThuNhat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtRes);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoThuHai);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(136, 105);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(712, 282);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tính toán đơn giản";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(378, 448);
            this.btnCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(94, 29);
            this.btnCong.TabIndex = 8;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(503, 448);
            this.btnTru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(94, 29);
            this.btnTru.TabIndex = 9;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(628, 448);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(94, 29);
            this.btnNhan.TabIndex = 10;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(753, 448);
            this.btnChia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(94, 29);
            this.btnChia.TabIndex = 11;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 562);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoThuNhat;
        private System.Windows.Forms.TextBox txtSoThuHai;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
    }
}

