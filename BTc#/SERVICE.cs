using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinhld_PH56704
{
    internal class SERVICE
    {
        List<LapTop> lapLst = new List<LapTop>();

        public void lapTop()
        {
            LapTop lap1 = new LapTop(1, "A", 19);
            LapTop lap2 = new LapTop(2, "B", 14);
            LapTop lap3 = new LapTop(3, "C", 27);
            lapLst.Add(lap1);
            lapLst.Add(lap2);
            lapLst.Add(lap3);
            lapLst.Sort((x, y) => x.KichThuocMH1.CompareTo(y.KichThuocMH1));
        }


        public int Menu()
        {
            Console.WriteLine("====MENU====");
            Console.WriteLine("1.Nhập danh sách đối tượng");
            Console.WriteLine("2.Xuất danh sách đối tượng");
            Console.WriteLine("3.Xóa đối tượng theo MaLapTop");
            Console.WriteLine("4.Xuất kích thước màn hình theo khoảng nhập ");
            Console.WriteLine("0.Thoát");
            Console.WriteLine("Xin mời chọn chức năng: ");
            int chucNang = Convert.ToInt32(Console.ReadLine());
            while (chucNang < 0 || chucNang > 4)
            {
                Console.WriteLine("Chức năng không hợp lệ!");
                return Menu();
            }
            return chucNang;
        }

        public void nhapDanhSach()
        {

            string check;
            do
            {

                LapTop lapTop = new LapTop();

                Console.WriteLine("Nhập vào ID ");
                lapTop.ID1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Nhập vào Mã LapTop ");
                lapTop.MaLapTop1 = Console.ReadLine();
                Console.WriteLine("Nhập vào kích thước màn hình ");
                lapTop.KichThuocMH1 = Convert.ToDouble(Console.ReadLine());
                lapLst.Add(lapTop);
                lapLst.Sort((x, y) => x.KichThuocMH1.CompareTo(y.KichThuocMH1));

                Console.WriteLine("Bạn có muốn nhập tiếp không(Y/N)?");
                check = Console.ReadLine();

            } while (check.ToUpper() == "Y");

        }

        public void xuatDanhSach()
        {

            if (lapLst.Count == 0)
            {
                Console.WriteLine("Danh sách sinh viên rỗng.");
                return;
            }
            foreach (var item in lapLst)
            {
                item.inThongTin();
            }
        }

        public void xoaTheoMa()
        {
            Console.WriteLine("Nhập vào Mã cần xóa: ");
            string maXoa = Console.ReadLine();
            int count = 0;
            for (int i = lapLst.Count - 1; i >= 0; i--)
            {
                if (lapLst[i].MaLapTop1 == maXoa)
                {
                    lapLst.Remove(lapLst[i]);
                    count++;
                }

            }
            if (count == 0) { Console.WriteLine("Mã không tồn tại!"); }
        }

        public void xuatKichThuoc()
        {
            Console.WriteLine("Nhập vào kích thước bé nhất(min) cần tìm");
            double ktMin = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhập vào kích thước lớn nhất(max) cần tìm");
            double ktMax = Convert.ToDouble(Console.ReadLine());
            if (ktMin > ktMax)
            {
                Console.WriteLine("Nhập ngược max ,min , tự động đổi vị trí!");
                double temp = ktMin;
                ktMin = ktMax;
                ktMax = temp;
            }
            Console.WriteLine("Những laptop trong khoảng chọn: ");
            int count = 0;
            foreach (var item in lapLst)
            {
                if (item.KichThuocMH1 >= ktMin && item.KichThuocMH1 <= ktMax)
                {
                    item.inThongTin();
                    count++;
                }
            }
            if (count == 0) { Console.WriteLine($"Không tồn tại màn hình có kích thước {ktMin} đến {ktMax}!"); }
        }


    }



}
