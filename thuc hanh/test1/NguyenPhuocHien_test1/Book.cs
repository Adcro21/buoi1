
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenPhuocHien_test1
{
    internal class Book
    {
        int maSach;
        string tenSach;
        string tacGia;
        int namXB;

        public Book()
        {
        }

        public Book(int maSach, string tenSach, string tacGia, int namXB)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tacGia = tacGia;
            this.namXB = namXB;
        }

        public int MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public int NamXB { get => namXB; set => namXB = value; }
        public void Nhap()
        {
            Console.Write("Mời bạn nhập mã sách: ");
            maSach = int.Parse(Console.ReadLine());
            Console.Write("Mời bạn nhập tên sách: ");
            tenSach = Console.ReadLine();
            Console.Write("Mời bạn nhập tác giả: ");
            tacGia = Console.ReadLine();
            Console.Write("Mời bạn nhập năm xuất bản: ");
            namXB = int.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($"Mã sách: {maSach}");

            Console.WriteLine($"Tên sách: {tenSach}");

            Console.WriteLine($"Tác giả: {tacGia}");

            Console.WriteLine($"Năm xuất bản: {namXB}");

        }
    }
}
