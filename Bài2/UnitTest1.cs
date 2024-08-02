using System.Text.RegularExpressions;

namespace Bài2
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        SinhVienPoly sinhVienPoly = new SinhVienPoly();
        [Test]
        [TestCase("SV001", "Nguyen Van A", "CT123", "Cong nghe thong tin", "123456")]
        [TestCase("SV002", "Nguyen Thi B", "DT123", "Dien tu@", "67890")]
        [TestCase("SV003", "Mary Jane", "KT123", "Kinh te1", "12345")]
        [TestCase("SV004", "Harry Potter", "KT123", "Kinh te2", "12345")]
        [TestCase("SV005", "Lewandowki", "KT123", "Ky thuat$", "12345")]
        [TestCase("SV006", "Messi", "KT123", "Kinh te", "12345")]
        [TestCase("SV007", "Ronando", "KT123", "Kinh te", "12345")]
        [TestCase("SV008", "Muller", "KT123", "Kinh te", "12345")]
        [TestCase("SV009", "Nguyễn thị lụa", "KT123", "Kinh te", "12345")]
        [TestCase("SV0010", "Giải phòng Miền Nam", "KT123", "Kinh te", "12345")]
        public void ThemSinhVien_TenLopKhongChuKyTuDacBiet(string id, string hoTen, string maLop, string tenLop, string maSV)
        {
            var sinhVien = new SinhVien(id, hoTen, maLop, tenLop, maSV);
            sinhVienPoly.ThemSinhVien(sinhVien);
            Assert.IsFalse(Regex.IsMatch(sinhVien.TenLop, @"[^a-zA-Z0-9\s]"));
        }
    }
}