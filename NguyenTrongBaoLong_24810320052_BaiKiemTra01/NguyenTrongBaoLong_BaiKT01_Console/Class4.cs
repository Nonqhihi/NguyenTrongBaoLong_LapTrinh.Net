using System;
using System.Collections.Generic;
using System.Linq;

namespace NguyenTrongBaoLong_BaiKT01_Console
{
    public class QuanLyPhuongTien
    {
        private readonly List<PhuongTien> _danhSach = new List<PhuongTien>();

        public void AddPhuongTien(PhuongTien pt)
        {
            if (pt != null)
                _danhSach.Add(pt);
        }

        public void DisplayAll()
        {
            Console.WriteLine("\nDANH SACH PHUONG TIEN");
            if (_danhSach.Count == 0)
            {
                Console.WriteLine("Danh sach trong!");
                return;
            }

            foreach (var pt in _danhSach)
            {
                Console.WriteLine(pt.GetInfo());
            }
        }

        public PhuongTien FindMaxGiaLanBanh()
        {
            if (!_danhSach.Any()) return null;
            return _danhSach.OrderByDescending(pt => pt.TinhGiaLanBanh()).FirstOrDefault();
        }

        public List<PhuongTien> SearchByName(string keyword)
        {
            return _danhSach
                .Where(pt => pt.TenHang.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }
    }
}