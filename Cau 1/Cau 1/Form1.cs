namespace Cau_1
{
    public partial class Form1 : Form
    {
        private int _selectMaHang = 0;
        private TiemTapHoaContext _context = new TiemTapHoaContext();
        private int _selectedMaHang = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbTatCaCacLoai.Items.Clear();
            cbTatCaCacLoai.Items.Add("Tất cả loại");
            cbTatCaCacLoai.Items.AddRange(new string[] { "Đồ uống", "Thực phẩm khô", "Gia vị", "Đồ gia dụng" });
            cbTatCaCacLoai.SelectedIndex = 0;

            dgvHangHoa.AutoGenerateColumns = true;
            LoadData();

            if (dgvHangHoa.Columns["GiaBan"] != null)
            {
                dgvHangHoa.Columns["GiaBan"].DefaultCellStyle.Format = "N0";
                dgvHangHoa.Columns["GiaBan"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            if (dgvHangHoa.Columns["NgayNhap"] != null)
            {
                dgvHangHoa.Columns["NgayNhap"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void LoadData()
        {
            var query = _context.HangHoas.AsQueryable();

            // Lọc theo từ khóa tên hàng
            string tuKhoa = txtTimKiem.Text.Trim().ToLower();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                query = query.Where(h => h.TenHang.ToLower().Contains(tuKhoa));
            }

            // Lọc theo ComboBox loại hàng
            if (cbTatCaCacLoai.SelectedIndex > 0)
            {
                string loaiChon = cbTatCaCacLoai.SelectedItem.ToString();
                query = query.Where(h => h.LoaiHang == loaiChon);
            }

            // Lọc hàng còn kinh doanh
            if (cboxHangConKinhDoanh.Checked)
            {
                query = query.Where(h => h.ConKinhDoanh == true);
            }

            var ketQua = query.ToList();
            dgvHangHoa.DataSource = ketQua;

            // Đổi tiêu đề cột hiển thị
            if (dgvHangHoa.Columns["MaHang"] != null) dgvHangHoa.Columns["MaHang"].HeaderText = "Mã";
            if (dgvHangHoa.Columns["TenHang"] != null) dgvHangHoa.Columns["TenHang"].HeaderText = "Tên hàng";
            if (dgvHangHoa.Columns["LoaiHang"] != null) dgvHangHoa.Columns["LoaiHang"].HeaderText = "Loại hàng";
            if (dgvHangHoa.Columns["DonVi"] != null) dgvHangHoa.Columns["DonVi"].HeaderText = "Đơn vị";
            if (dgvHangHoa.Columns["GiaBan"] != null) dgvHangHoa.Columns["GiaBan"].HeaderText = "Giá bán";
            if (dgvHangHoa.Columns["SoLuongTon"] != null) dgvHangHoa.Columns["SoLuongTon"].HeaderText = "Tồn";
            if (dgvHangHoa.Columns["NgayNhap"] != null) dgvHangHoa.Columns["NgayNhap"].HeaderText = "Ngày nhập";
            if (dgvHangHoa.Columns["ConKinhDoanh"] != null) dgvHangHoa.Columns["ConKinhDoanh"].HeaderText = "Kinh doanh";

            lblTrangThai.Text = $"Tìm thấy {ketQua.Count} mặt hàng";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvHangHoa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvHangHoa.Rows[e.RowIndex];
                _selectedMaHang = Convert.ToInt32(row.Cells["MaHang"].Value);
                txtTenHang.Text = row.Cells["TenHang"].Value?.ToString();
                cbLoaiHang.SelectedItem = row.Cells["LoaiHang"].Value?.ToString();
                cbDonVi.SelectedItem = row.Cells["DonVi"].Value?.ToString();
                nudGiaBan.Value = Convert.ToDecimal(row.Cells["GiaBan"].Value ?? 0);
                nudSoLuongTon.Value = Convert.ToInt32(row.Cells["SoLuongTon"].Value ?? 0);
                dtpNgayNhap.Value = Convert.ToDateTime(row.Cells["NgayNhap"].Value ?? DateTime.Now);
                cboxConKinhDoanh.Checked = Convert.ToBoolean(row.Cells["ConKinhDoanh"].Value ?? false);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            _selectedMaHang = 0;
            txtTenHang.Clear();
            cbLoaiHang.SelectedIndex = -1;
            cbDonVi.SelectedIndex = -1;
            nudGiaBan.Value = 500;
            nudSoLuongTon.Value = 0;
            dtpNgayNhap.Value = DateTime.Now;
            cboxConKinhDoanh.Checked = true;
            dgvHangHoa.ClearSelection();
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenHang.Text))
            {
                MessageBox.Show("Tên hàng không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenHang.Focus();
                return false;
            }
            if (nudGiaBan.Value <= 0)
            {
                MessageBox.Show("Giá bán phải lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nudGiaBan.Focus();
                return false;
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            var hangHoaMoi = new HangHoa
            {
                TenHang = txtTenHang.Text.Trim(),
                LoaiHang = cbTatCaCacLoai.SelectedItem?.ToString(),
                DonVi = cbDonVi.SelectedItem?.ToString(),
                GiaBan = nudGiaBan.Value,
                SoLuongTon = (int)nudSoLuongTon.Value,
                NgayNhap = dtpNgayNhap.Value,
                ConKinhDoanh = cboxConKinhDoanh.Checked
            };

            _context.HangHoas.Add(hangHoaMoi);
            _context.SaveChanges();
            LoadData();
            btnLamMoi_Click(null, null);
            MessageBox.Show("Thêm hàng hóa thành công!", "Thông báo");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaHang == 0)
            {
                MessageBox.Show("Vui lòng chọn hàng hóa cần sửa trên lưới!", "Thông báo");
                return;
            }
            if (!ValidateInput()) return;

            // Option A: use List<T>.Find with a predicate
            var hh = _context.HangHoas.Find(h => h.MaHang == _selectedMaHang);

            // Option B (equivalent): use LINQ (requires using System.Linq)
            // var hh = _context.HangHoas.FirstOrDefault(h => h.MaHang == _selectedMaHang);

            if (hh != null)
            {
                hh.TenHang = txtTenHang.Text.Trim();
                hh.LoaiHang = cbLoaiHang.SelectedItem?.ToString();
                hh.DonVi = cbDonVi.SelectedItem?.ToString();
                hh.GiaBan = nudGiaBan.Value;
                hh.SoLuongTon = (int)nudSoLuongTon.Value;
                hh.NgayNhap = dtpNgayNhap.Value;
                hh.ConKinhDoanh = cboxConKinhDoanh.Checked;

                _context.SaveChanges();
                LoadData();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            tmrSearch.Stop();
            tmrSearch.Start();
        }

        private void tmrSearch_Tick(object sender, EventArgs e)
        {
            tmrSearch.Stop();
            LoadData();
        }

        private void cbTatCaCacLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
