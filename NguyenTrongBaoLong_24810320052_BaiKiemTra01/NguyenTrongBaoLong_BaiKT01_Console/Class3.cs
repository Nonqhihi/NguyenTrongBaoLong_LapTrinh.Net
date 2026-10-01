using System;

namespace NguyenTrongBaoLong_BaiKT01_Console
{
    public class XeMay : PhuongTien
    {
        private int _dungTichXylanh;

        public int DungTichXylanh
        {
            get => _dungTichXylanh;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Dung tich xi lanh phai lon hon 0!");
                _dungTichXylanh = value;
            }
        }

        public XeMay(string maPT, string tenHang, int namSanXuat, decimal giaGoc, int dungTichXylanh)
            : base(maPT, tenHang, namSanXuat, giaGoc)
        {
            DungTichXylanh = dungTichXylanh;
        }

        public override decimal TinhGiaLanBanh()
        {
            decimal thueTruocBa = DungTichXylanh < 175 ? 0.02m : 0.05m;
            return GiaGoc + (GiaGoc * thueTruocBa);
        }

        public override string GetInfo()
        {
            return $"{base.GetInfo()} | Dung tich XL: {DungTichXylanh}cc | Gia lan banh: {TinhGiaLanBanh():N0} VND";
        }
    }
}