namespace Thinhld_PH56704
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            SERVICE Service = new SERVICE();
            Service.lapTop();
            do
            {
                switch (Service.Menu())
                {
                    case 1:
                        {
                            Console.WriteLine("--- Bạn đang dùng chức năng Nhập danh sách đối tượng --- ");
                            Service.nhapDanhSach();
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("--- Bạn đang dùng chức năng Xuất danh sách đối tượng ---");
                            Console.WriteLine("Danh sách các laptop đã nhập: ");
                            Service.xuatDanhSach();

                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("--- Bạn đang dùng chức năng Xóa đối tượng theo MaLapTop ---");
                            Service.xoaTheoMa();
                            Console.WriteLine("Đối tượng đã được xóa!");
                            Console.WriteLine("Những laptop còn lại sau khi xóa: ");
                            Service.xuatDanhSach();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("--- Bạn đang dùng chức năng Xuất kích thước màn hình theo khoảng nhập --- ");
                            Service.xuatKichThuoc();
                            break;
                        }

                    case 0:
                        {
                            Console.WriteLine("Nhấn phím bất kì để thoát!");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Chức năng không hợp lệ!");
                            break;
                        }
                }

            } while (true);
        }
    }
}
