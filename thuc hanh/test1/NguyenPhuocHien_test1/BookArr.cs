using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenPhuocHien_test1
{
    internal class BookArr
    {
        Book[] arr;

        public BookArr()
        {
            arr = new Book[0];
        }

        public BookArr(Book[] arr)
        {
            this.arr = new Book[arr.Length];
            for (int i = 0; i < arr.Length; i++)
                this.arr[i] = new Book { MaSach = arr[i].MaSach, TenSach = arr[i].TenSach, TacGia = arr[i].TacGia, NamXB = arr[i].NamXB };
        }

        internal Book[] Arr { get => arr; set => arr = value; }
        public int NhapN()
        {
            int n = 0;
            while (true)
            {
                Console.Write("Mời nhập (n>0) n: ");
                n = int.Parse(Console.ReadLine());
                if (n > 0) return n;
                Console.WriteLine("Bạn nhập sai, mời nhập lại...");
            }
        }
        public bool TonTai(int ms, int vt) //kiểm tra có trùng mã số không
        {
            for (int i = 0; i < vt; i++)
            {
                if (arr[i].MaSach == ms) //giống nhau = trùng mã số, có tồn tại
                    return true; //
            }
            return false; //không giống nhau => không trùng , không tồn tại
        }
        public void Nhap()
        {
            int n = NhapN();
            arr = new Book[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = new Book();
                arr[i].Nhap();
                while (true)
                {
                    if (TonTai(arr[i].MaSach, i) == false) break;
                    Console.Write("Mã số SV bị trùng, mời nhập lại mã số sinh viên:");
                    arr[i].MaSach = int.Parse(Console.ReadLine());
                }
            }
        }
        public void Xuat()
        {
            foreach (Book s in arr)
                s.Xuat();
        }

        public void QuickSort(int left, int right)
        {
            if (left < right)
            {
                // Chọn phần tử giữa làm pivot
                int pivotIndex = (left + right) / 2;
                Book pivotValue = arr[pivotIndex];

                // Di chuyển pivot về cuối mảng
                Swap(pivotIndex, right);
                int storeIndex = left;

                // Phân hoạch
                for (int i = left; i < right; i++)
                {
                    if (arr[i].MaSach < pivotValue.MaSach)
                    {
                        Swap(i, storeIndex);
                        storeIndex++;
                    }
                }

                // Đưa pivot về vị trí đúng
                Swap(storeIndex, right);

                // Đệ quy với hai nửa mảng
                QuickSort(left, storeIndex - 1);
                QuickSort(storeIndex + 1, right);
            }
        }

        public void Swap(int i, int j)
        {
            Book temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public bool KiemTraTang_MaSach()
        {
            for (int i = 1; i < arr.Length; i++)
                if (arr[i].MaSach < arr[i - 1].MaSach)
                    return false;
            return true;
        }
        //mảng phải có thứ tự 
        public int TimNhiPhan(int x)
        {
            int left = 0, right = Arr.Length - 1;
            while (left <= right)
            {
                //tìm thấy x tại vị trí mid
                int mid = (left + right) / 2;
                if (Arr[mid].MaSach == x) return mid;
                if (x > Arr[mid].MaSach) left = mid + 1;
                else right = mid - 1;
            }
            return -1; //không tìm thấy x
        }
        public void ChenMotCuonSachTangMaSach()
        {
            Book s = new Book();
            s.Nhap();
            while (true)
            {
                if (TonTai(s.MaSach, arr.Length) == false) break;
                Console.Write("Mã số SV bị trùng, mời nhập lại mã số sinh viên:");
                s.MaSach = int.Parse(Console.ReadLine());
            }
            Array.Resize(ref arr, arr.Length + 1);
            int pos = arr.Length - 2;
            //duyệt ngược
            while (pos >= 0 && arr[pos].MaSach > s.MaSach)
            {
                arr[pos + 1] = arr[pos];
                pos--;
            }

            arr[pos + 1] = s;
        }
    }
}
