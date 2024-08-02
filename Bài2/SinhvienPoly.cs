using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bài2
{
    public class SinhVienPoly
    {
        private List<SinhVien> danhSachSinhVien = new List<SinhVien>();

        public void ThemSinhVien(SinhVien sinhVien)
        {
            danhSachSinhVien.Add(sinhVien);
        }

        public List<SinhVien> TimKiemTheoTen(string ten)
        {
            return danhSachSinhVien.Where(sv => sv.HoTen.Contains(ten, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public List<SinhVien> TimKiemTheoMaLop(string maLop)
        {
            return danhSachSinhVien.Where(sv => sv.MaLop == maLop).ToList();
        }
    }
}
