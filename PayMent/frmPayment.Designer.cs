namespace PayMent
{
    partial class frmPayment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtGiamGia = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtThuKhac = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCanTra = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtLoaiPhong = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSoPhong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnTienMat = new System.Windows.Forms.RadioButton();
            this.rbtnChuyenKhoan = new System.Windows.Forms.RadioButton();
            this.rbtnTheTinDung = new System.Windows.Forms.RadioButton();
            this.rbtnViDienTu = new System.Windows.Forms.RadioButton();
            this.btnHTTT = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 564);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtLoaiPhong);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtSoPhong);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txtSDT);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTenKH);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaKH);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(29, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 350);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã khách hàng";
            // 
            // txtMaKH
            // 
            this.txtMaKH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaKH.Location = new System.Drawing.Point(152, 12);
            this.txtMaKH.Multiline = true;
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.ReadOnly = true;
            this.txtMaKH.Size = new System.Drawing.Size(155, 35);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenKH.Location = new System.Drawing.Point(152, 66);
            this.txtTenKH.Multiline = true;
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.ReadOnly = true;
            this.txtTenKH.Size = new System.Drawing.Size(155, 35);
            this.txtTenKH.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên khách hàng";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtEmail.Location = new System.Drawing.Point(152, 121);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(155, 35);
            this.txtEmail.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSDT.Location = new System.Drawing.Point(152, 184);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.ReadOnly = true;
            this.txtSDT.Size = new System.Drawing.Size(155, 35);
            this.txtSDT.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Số điện thoại";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCanTra);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtThuKhac);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtGiamGia);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtTongTien);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(537, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(359, 277);
            this.panel3.TabIndex = 2;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTongTien.Location = new System.Drawing.Point(155, 25);
            this.txtTongTien.Multiline = true;
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(155, 35);
            this.txtTongTien.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tổng tiền";
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiamGia.Location = new System.Drawing.Point(155, 85);
            this.txtGiamGia.Multiline = true;
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Size = new System.Drawing.Size(155, 35);
            this.txtGiamGia.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(28, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Giảm giá";
            // 
            // txtThuKhac
            // 
            this.txtThuKhac.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtThuKhac.Location = new System.Drawing.Point(155, 139);
            this.txtThuKhac.Multiline = true;
            this.txtThuKhac.Name = "txtThuKhac";
            this.txtThuKhac.Size = new System.Drawing.Size(155, 35);
            this.txtThuKhac.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(28, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Thu khác";
            // 
            // txtCanTra
            // 
            this.txtCanTra.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtCanTra.Location = new System.Drawing.Point(155, 198);
            this.txtCanTra.Multiline = true;
            this.txtCanTra.Name = "txtCanTra";
            this.txtCanTra.ReadOnly = true;
            this.txtCanTra.Size = new System.Drawing.Size(155, 35);
            this.txtCanTra.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(28, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Cần trả";
            // 
            // txtLoaiPhong
            // 
            this.txtLoaiPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLoaiPhong.Location = new System.Drawing.Point(152, 296);
            this.txtLoaiPhong.Multiline = true;
            this.txtLoaiPhong.Name = "txtLoaiPhong";
            this.txtLoaiPhong.ReadOnly = true;
            this.txtLoaiPhong.Size = new System.Drawing.Size(155, 35);
            this.txtLoaiPhong.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Loại phòng";
            // 
            // txtSoPhong
            // 
            this.txtSoPhong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSoPhong.Location = new System.Drawing.Point(152, 242);
            this.txtSoPhong.Multiline = true;
            this.txtSoPhong.Name = "txtSoPhong";
            this.txtSoPhong.ReadOnly = true;
            this.txtSoPhong.Size = new System.Drawing.Size(155, 35);
            this.txtSoPhong.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số phòng";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rbtnViDienTu);
            this.panel4.Controls.Add(this.rbtnTheTinDung);
            this.panel4.Controls.Add(this.rbtnChuyenKhoan);
            this.panel4.Controls.Add(this.rbtnTienMat);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(537, 380);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 165);
            this.panel4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phương thức thanh toán";
            // 
            // rbtnTienMat
            // 
            this.rbtnTienMat.AutoSize = true;
            this.rbtnTienMat.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTienMat.Location = new System.Drawing.Point(36, 58);
            this.rbtnTienMat.Name = "rbtnTienMat";
            this.rbtnTienMat.Size = new System.Drawing.Size(84, 21);
            this.rbtnTienMat.TabIndex = 1;
            this.rbtnTienMat.TabStop = true;
            this.rbtnTienMat.Text = "Tiền mặt";
            this.rbtnTienMat.UseVisualStyleBackColor = true;
            // 
            // rbtnChuyenKhoan
            // 
            this.rbtnChuyenKhoan.AutoSize = true;
            this.rbtnChuyenKhoan.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnChuyenKhoan.Location = new System.Drawing.Point(256, 58);
            this.rbtnChuyenKhoan.Name = "rbtnChuyenKhoan";
            this.rbtnChuyenKhoan.Size = new System.Drawing.Size(117, 21);
            this.rbtnChuyenKhoan.TabIndex = 2;
            this.rbtnChuyenKhoan.TabStop = true;
            this.rbtnChuyenKhoan.Text = "Chuyển khoản";
            this.rbtnChuyenKhoan.UseVisualStyleBackColor = true;
            // 
            // rbtnTheTinDung
            // 
            this.rbtnTheTinDung.AutoSize = true;
            this.rbtnTheTinDung.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTheTinDung.Location = new System.Drawing.Point(36, 107);
            this.rbtnTheTinDung.Name = "rbtnTheTinDung";
            this.rbtnTheTinDung.Size = new System.Drawing.Size(109, 21);
            this.rbtnTheTinDung.TabIndex = 3;
            this.rbtnTheTinDung.TabStop = true;
            this.rbtnTheTinDung.Text = "Thẻ tín dụng";
            this.rbtnTheTinDung.UseVisualStyleBackColor = true;
            // 
            // rbtnViDienTu
            // 
            this.rbtnViDienTu.AutoSize = true;
            this.rbtnViDienTu.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnViDienTu.Location = new System.Drawing.Point(256, 107);
            this.rbtnViDienTu.Name = "rbtnViDienTu";
            this.rbtnViDienTu.Size = new System.Drawing.Size(91, 21);
            this.rbtnViDienTu.TabIndex = 4;
            this.rbtnViDienTu.TabStop = true;
            this.rbtnViDienTu.Text = "Ví điện tử";
            this.rbtnViDienTu.UseVisualStyleBackColor = true;
            // 
            // btnHTTT
            // 
            this.btnHTTT.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnHTTT.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTTT.ForeColor = System.Drawing.Color.White;
            this.btnHTTT.Location = new System.Drawing.Point(393, 637);
            this.btnHTTT.Name = "btnHTTT";
            this.btnHTTT.Size = new System.Drawing.Size(267, 56);
            this.btnHTTT.TabIndex = 1;
            this.btnHTTT.Text = "Hoàn thành thanh toán";
            this.btnHTTT.UseVisualStyleBackColor = false;
            this.btnHTTT.Click += new System.EventHandler(this.btnHTTT_Click);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.LightGray;
            this.btnTroVe.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.ForeColor = System.Drawing.Color.White;
            this.btnTroVe.Location = new System.Drawing.Point(12, 12);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(96, 34);
            this.btnTroVe.TabIndex = 2;
            this.btnTroVe.Text = "Trở về";
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(537, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Thời gian tạo hóa đơn";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.White;
            this.dateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(721, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 25);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2025, 10, 19, 21, 57, 21, 0);
            // 
            // frmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1036, 705);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnHTTT);
            this.Controls.Add(this.panel1);
            this.Name = "frmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPayment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtnViDienTu;
        private System.Windows.Forms.RadioButton rbtnTheTinDung;
        private System.Windows.Forms.RadioButton rbtnChuyenKhoan;
        private System.Windows.Forms.RadioButton rbtnTienMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCanTra;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtThuKhac;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLoaiPhong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSoPhong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnHTTT;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label12;
    }
}