using System;
using System.Collections.Generic;

namespace NguyenTrongBaoLong_BaiKT01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyPhuongTien ql = new QuanLyPhuongTien();
            int choice = -1;

            do
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY PHUONG TIEN");
                Console.WriteLine("1. Them O To");
                Console.WriteLine("2. Them Xe May");
                Console.WriteLine("3. Hien thi toan bo danh sach");
                Console.WriteLine("4. Tim phuong tien co gia lan banh cao nhat");
                Console.WriteLine("5. Tim kiem phuong tien theo ten hang");
                Console.WriteLine("0. Thoat chuong trinh");
                Console.Write("Moi ban chon chuc nang (0-5): ");

                string input = Console.ReadLine();
                if (!int.TryParse(input, out choice))
                {
                    Console.WriteLine("Lua chon khong hop le. Vui long nhap so tu 0 den 5!");
                    continue;
                }

                try
                {
                    switch (choice)
                    {
                        case 1:
                            ThemOTo(ql);
                            break;
                        case 2:
                            ThemXeMay(ql);
                            break;
                        case 3:
                            ql.DisplayAll();
                            break;
                        case 4:
                            PhuongTien maxPT = ql.FindMaxGiaLanBanh();
                            if (maxPT != null)
                            {
                                Console.WriteLine("\nPHUONG TIEN CO GIA LAN BANH CAO NHAT");
                                Console.WriteLine(maxPT.GetInfo());
                            }
                            else
                            {
                                Console.WriteLine("\nDanh sach chua co du lieu!");
                            }
                            break;
                        case 5:
                            Console.Write("\nNhap ten hang can tim: ");
                            string keyword = Console.ReadLine();
                            List<PhuongTien> kq = ql.SearchByName(keyword);

                            if (kq.Count > 0)
                            {
                                Console.WriteLine($"\nTIM THAY {kq.Count} KET QUA");
                                foreach (var pt in kq)
                                {
                                    Console.WriteLine(pt.GetInfo());
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nKhong tim thay phuong tien nao phu hop!");
                            }
                            break;
                        case 0:
                            Console.WriteLine("Dang thoat chuong trinh. Tam biet!");
                            break;
                        default:
                            Console.WriteLine("Chuc nang khong ton tai. Vui long chon lai!");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nLoi: Ban da nhap sai dinh dang du lieu (Vi du: nhap chu vao o can nhap so)!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nLoi: {ex.Message}");
                }

            } while (choice != 0);
        }

        static void ThemOTo(QuanLyPhuongTien ql)
        {
            Console.WriteLine("\nTHEM THONG TIN O TO");
            Console.Write("Nhap Ma PT: "); string ma = Console.ReadLine();
            Console.Write("Nhap Ten Hang: "); string ten = Console.ReadLine();
            Console.Write("Nhap Nam SX: "); int nam = int.Parse(Console.ReadLine());
            Console.Write("Nhap Gia Goc (VND): "); decimal gia = decimal.Parse(Console.ReadLine());
            Console.Write("Nhap So Cho Ngoi: "); int soCho = int.Parse(Console.ReadLine());
            Console.Write("Nhap Dung Tich Dong Co (L): "); double dungTich = double.Parse(Console.ReadLine());

            OTo oto = new OTo(ma, ten, nam, gia, soCho, dungTich);
            ql.AddPhuongTien(oto);
            Console.WriteLine("Da them O To thanh cong!");
        }

        static void ThemXeMay(QuanLyPhuongTien ql)
        {
            Console.WriteLine("\nTHEM THONG TIN XE MAY");
            Console.Write("Nhap Ma PT: "); string ma = Console.ReadLine();
            Console.Write("Nhap Ten Hang: "); string ten = Console.ReadLine();
            Console.Write("Nhap Nam SX: "); int nam = int.Parse(Console.ReadLine());
            Console.Write("Nhap Gia Goc (VND): "); decimal gia = decimal.Parse(Console.ReadLine());
            Console.Write("Nhap Dung Tich Xi Lanh (cc): "); int dungTich = int.Parse(Console.ReadLine());

            XeMay xm = new XeMay(ma, ten, nam, gia, dungTich);
            ql.AddPhuongTien(xm);
            Console.WriteLine("Da them Xe May thanh cong!");
        }
    }
}