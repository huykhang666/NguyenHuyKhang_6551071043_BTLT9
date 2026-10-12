using System;
using System.Collections.Generic;
using System.Linq;

namespace Cau_1
{
    public class HangHoa
    {
        public int MaHang { get; set; }
        public string TenHang { get; set; }
        public string LoaiHang { get; set; }
        public string DonVi { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public DateTime NgayNhap { get; set; }
        public bool ConKinhDoanh { get; set; }
    }
    // Minimal in-memory set and context so the WinForms app can run without EF scaffolding.
    public class HangHoaSet : List<HangHoa>
    {
        private int _nextId = 1;

        public HangHoaSet()
        {
        }

        public HangHoaSet(IEnumerable<HangHoa> items)
            : base(items)
        {
            if (this.Any()) _nextId = this.Max(h => h.MaHang) + 1;
        }

        // Hide List.Add to auto-assign MaHang when missing
        public new void Add(HangHoa item)
        {
            if (item == null) return;
            if (item.MaHang == 0)
            {
                item.MaHang = _nextId++;
            }
            base.Add(item);
        }

        // Provide Find by primary key (int) to mimic DbSet.Find
        public HangHoa Find(int id)
        {
            return this.FirstOrDefault(h => h.MaHang == id);
        }
    }

    public class TiemTapHoaContext
    {
        public HangHoaSet HangHoas { get; }

        public TiemTapHoaContext()
        {
            HangHoas = new HangHoaSet(new List<HangHoa>
            {
                new HangHoa { MaHang = 1, TenHang = "Nước ngọt", LoaiHang = "Đồ uống", DonVi = "Chai", GiaBan = 5000m, SoLuongTon = 100, NgayNhap = DateTime.Now.AddDays(-10), ConKinhDoanh = true },
                new HangHoa { MaHang = 2, TenHang = "Gạo", LoaiHang = "Thực phẩm khô", DonVi = "Kg", GiaBan = 20000m, SoLuongTon = 50, NgayNhap = DateTime.Now.AddDays(-30), ConKinhDoanh = true },
                new HangHoa { MaHang = 3, TenHang = "Muối", LoaiHang = "Gia vị", DonVi = "Gói", GiaBan = 3000m, SoLuongTon = 200, NgayNhap = DateTime.Now.AddDays(-5), ConKinhDoanh = true },
                new HangHoa { MaHang = 4, TenHang = "Xà phòng", LoaiHang = "Đồ gia dụng", DonVi = "Cái", GiaBan = 15000m, SoLuongTon = 30, NgayNhap = DateTime.Now.AddDays(-1), ConKinhDoanh = false }
            });
        }

        // No-op to mimic EF Core DbContext.SaveChanges
        public void SaveChanges()
        {
            // In-memory; nothing required.
        }
    }
}
