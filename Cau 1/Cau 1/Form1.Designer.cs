namespace Cau_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            gbTTHH = new GroupBox();
            cboxConKinhDoanh = new CheckBox();
            label6 = new Label();
            dtpNgayNhap = new DateTimePicker();
            label5 = new Label();
            nudSoLuongTon = new NumericUpDown();
            nudGiaBan = new NumericUpDown();
            cbDonVi = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cbLoaiHang = new ComboBox();
            label1 = new Label();
            txtTenHang = new TextBox();
            gbTimKiem = new GroupBox();
            cboxHangConKinhDoanh = new CheckBox();
            cbTatCaCacLoai = new ComboBox();
            txtTimKiem = new TextBox();
            tmrSearch = new System.Windows.Forms.Timer(components);
            dgvHangHoa = new DataGridView();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnXemBangGia = new Button();
            btnXuatPDF = new Button();
            btnXuatExcel = new Button();
            btnXuatExcelTonKho = new Button();
            lblTrangThai = new Label();
            gbTTHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).BeginInit();
            gbTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).BeginInit();
            SuspendLayout();
            // 
            // gbTTHH
            // 
            gbTTHH.Controls.Add(cboxConKinhDoanh);
            gbTTHH.Controls.Add(label6);
            gbTTHH.Controls.Add(dtpNgayNhap);
            gbTTHH.Controls.Add(label5);
            gbTTHH.Controls.Add(nudSoLuongTon);
            gbTTHH.Controls.Add(nudGiaBan);
            gbTTHH.Controls.Add(cbDonVi);
            gbTTHH.Controls.Add(label4);
            gbTTHH.Controls.Add(label3);
            gbTTHH.Controls.Add(label2);
            gbTTHH.Controls.Add(cbLoaiHang);
            gbTTHH.Controls.Add(label1);
            gbTTHH.Controls.Add(txtTenHang);
            gbTTHH.Location = new Point(25, 28);
            gbTTHH.Name = "gbTTHH";
            gbTTHH.Size = new Size(578, 222);
            gbTTHH.TabIndex = 0;
            gbTTHH.TabStop = false;
            gbTTHH.Text = "Thông tin hàng hóa";
            gbTTHH.Enter += groupBox1_Enter;
            // 
            // cboxConKinhDoanh
            // 
            cboxConKinhDoanh.AccessibleRole = AccessibleRole.None;
            cboxConKinhDoanh.AutoSize = true;
            cboxConKinhDoanh.Checked = true;
            cboxConKinhDoanh.CheckState = CheckState.Checked;
            cboxConKinhDoanh.Location = new Point(424, 184);
            cboxConKinhDoanh.Name = "cboxConKinhDoanh";
            cboxConKinhDoanh.Size = new Size(134, 24);
            cboxConKinhDoanh.TabIndex = 12;
            cboxConKinhDoanh.Text = "Còn kinh doanh";
            cboxConKinhDoanh.UseVisualStyleBackColor = true;
            cboxConKinhDoanh.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(314, 143);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 11;
            label6.Text = "Ngày nhập:";
            // 
            // dtpNgayNhap
            // 
            dtpNgayNhap.CustomFormat = "dd/MM/yyyy";
            dtpNgayNhap.Format = DateTimePickerFormat.Custom;
            dtpNgayNhap.Location = new Point(424, 138);
            dtpNgayNhap.Name = "dtpNgayNhap";
            dtpNgayNhap.Size = new Size(144, 27);
            dtpNgayNhap.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(314, 94);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 9;
            label5.Text = "Số Lượng Tồn:";
            // 
            // nudSoLuongTon
            // 
            nudSoLuongTon.Location = new Point(424, 91);
            nudSoLuongTon.Name = "nudSoLuongTon";
            nudSoLuongTon.Size = new Size(144, 27);
            nudSoLuongTon.TabIndex = 8;
            nudSoLuongTon.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // nudGiaBan
            // 
            nudGiaBan.Increment = new decimal(new int[] { 500, 0, 0, 0 });
            nudGiaBan.Location = new Point(119, 182);
            nudGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudGiaBan.Name = "nudGiaBan";
            nudGiaBan.Size = new Size(150, 27);
            nudGiaBan.TabIndex = 7;
            // 
            // cbDonVi
            // 
            cbDonVi.FormattingEnabled = true;
            cbDonVi.Items.AddRange(new object[] { "Chai", "Gói", "Hộp", "Túi" });
            cbDonVi.Location = new Point(118, 140);
            cbDonVi.Name = "cbDonVi";
            cbDonVi.Size = new Size(151, 28);
            cbDonVi.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 184);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 5;
            label4.Text = "Giá Bán:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 94);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 4;
            label3.Text = "Loại Hàng: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 143);
            label2.Name = "label2";
            label2.Size = new Size(57, 20);
            label2.TabIndex = 3;
            label2.Text = "Đơn Vị:";
            // 
            // cbLoaiHang
            // 
            cbLoaiHang.FormattingEnabled = true;
            cbLoaiHang.Items.AddRange(new object[] { "Đồ uống", "Thực phẩm khô", "Gia vị", "Đồ gia dụng" });
            cbLoaiHang.Location = new Point(118, 91);
            cbLoaiHang.Name = "cbLoaiHang";
            cbLoaiHang.Size = new Size(151, 28);
            cbLoaiHang.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 49);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên Hàng: ";
            // 
            // txtTenHang
            // 
            txtTenHang.Location = new Point(118, 46);
            txtTenHang.Name = "txtTenHang";
            txtTenHang.Size = new Size(450, 27);
            txtTenHang.TabIndex = 0;
            // 
            // gbTimKiem
            // 
            gbTimKiem.Controls.Add(cboxHangConKinhDoanh);
            gbTimKiem.Controls.Add(cbTatCaCacLoai);
            gbTimKiem.Controls.Add(txtTimKiem);
            gbTimKiem.Location = new Point(635, 28);
            gbTimKiem.Name = "gbTimKiem";
            gbTimKiem.Size = new Size(344, 222);
            gbTimKiem.TabIndex = 1;
            gbTimKiem.TabStop = false;
            gbTimKiem.Text = "Tìm Kiếm";
            // 
            // cboxHangConKinhDoanh
            // 
            cboxHangConKinhDoanh.AutoSize = true;
            cboxHangConKinhDoanh.Location = new Point(28, 138);
            cboxHangConKinhDoanh.Name = "cboxHangConKinhDoanh";
            cboxHangConKinhDoanh.Size = new Size(226, 24);
            cboxHangConKinhDoanh.TabIndex = 2;
            cboxHangConKinhDoanh.Text = "Chỉ hiện hàng còn kinh doanh";
            cboxHangConKinhDoanh.UseVisualStyleBackColor = true;
            // 
            // cbTatCaCacLoai
            // 
            cbTatCaCacLoai.FormattingEnabled = true;
            cbTatCaCacLoai.Items.AddRange(new object[] { "Tất cả các loại" });
            cbTatCaCacLoai.Location = new Point(28, 90);
            cbTatCaCacLoai.Name = "cbTatCaCacLoai";
            cbTatCaCacLoai.Size = new Size(297, 28);
            cbTatCaCacLoai.TabIndex = 1;
            cbTatCaCacLoai.SelectedIndexChanged += cbTatCaCacLoai_SelectedIndexChanged;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(28, 49);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(297, 27);
            txtTimKiem.TabIndex = 0;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // tmrSearch
            // 
            tmrSearch.Interval = 350;
            tmrSearch.Tick += tmrSearch_Tick;
            // 
            // dgvHangHoa
            // 
            dgvHangHoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHangHoa.Location = new Point(25, 267);
            dgvHangHoa.Name = "dgvHangHoa";
            dgvHangHoa.ReadOnly = true;
            dgvHangHoa.RowHeadersWidth = 51;
            dgvHangHoa.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangHoa.Size = new Size(954, 209);
            dgvHangHoa.TabIndex = 2;
            dgvHangHoa.CellContentClick += dgvHangHoa_CellContentClick;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 482);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(125, 482);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(225, 482);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(329, 482);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 6;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXemBangGia
            // 
            btnXemBangGia.Location = new Point(465, 482);
            btnXemBangGia.Name = "btnXemBangGia";
            btnXemBangGia.Size = new Size(118, 29);
            btnXemBangGia.TabIndex = 7;
            btnXemBangGia.Text = "Xem Bảng Giá";
            btnXemBangGia.UseVisualStyleBackColor = true;
            // 
            // btnXuatPDF
            // 
            btnXuatPDF.Location = new Point(594, 482);
            btnXuatPDF.Name = "btnXuatPDF";
            btnXuatPDF.Size = new Size(94, 29);
            btnXuatPDF.TabIndex = 8;
            btnXuatPDF.Text = "Xuất PDF";
            btnXuatPDF.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcel
            // 
            btnXuatExcel.Location = new Point(694, 482);
            btnXuatExcel.Name = "btnXuatExcel";
            btnXuatExcel.Size = new Size(135, 29);
            btnXuatExcel.TabIndex = 9;
            btnXuatExcel.Text = "Xuất Excel (lưới)";
            btnXuatExcel.UseVisualStyleBackColor = true;
            // 
            // btnXuatExcelTonKho
            // 
            btnXuatExcelTonKho.Location = new Point(835, 482);
            btnXuatExcelTonKho.Name = "btnXuatExcelTonKho";
            btnXuatExcelTonKho.Size = new Size(144, 29);
            btnXuatExcelTonKho.TabIndex = 10;
            btnXuatExcelTonKho.Text = "Xuất Excel Tồn Kho";
            btnXuatExcelTonKho.UseVisualStyleBackColor = true;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Location = new Point(25, 524);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(85, 20);
            lblTrangThai.TabIndex = 11;
            lblTrangThai.Text = "Trạng Thái: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(991, 553);
            Controls.Add(lblTrangThai);
            Controls.Add(btnXuatExcelTonKho);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnXuatPDF);
            Controls.Add(btnXemBangGia);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvHangHoa);
            Controls.Add(gbTimKiem);
            Controls.Add(gbTTHH);
            Name = "Form1";
            Text = "Quản Lý Hàng Hóa - Tạp Hóa UTC2";
            Load += Form1_Load;
            gbTTHH.ResumeLayout(false);
            gbTTHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuongTon).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudGiaBan).EndInit();
            gbTimKiem.ResumeLayout(false);
            gbTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangHoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbTTHH;
        private ComboBox cbDonVi;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cbLoaiHang;
        private Label label1;
        private TextBox txtTenHang;
        private NumericUpDown nudSoLuongTon;
        private NumericUpDown nudGiaBan;
        private Label label5;
        private Label label6;
        private DateTimePicker dtpNgayNhap;
        private CheckBox cboxConKinhDoanh;
        private GroupBox gbTimKiem;
        private CheckBox cboxHangConKinhDoanh;
        private ComboBox cbTatCaCacLoai;
        private TextBox txtTimKiem;
        private System.Windows.Forms.Timer tmrSearch;
        private DataGridView dgvHangHoa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnXemBangGia;
        private Button btnXuatPDF;
        private Button btnXuatExcel;
        private Button btnXuatExcelTonKho;
        private Label lblTrangThai;
    }
}
