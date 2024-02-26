using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thinhld_PH56704
{
    internal class LapTop
    {
        int ID;
        string MaLapTop;
        double KichThuocMH;

        public LapTop()
        {

        }
        public LapTop(int iD, string maLapTop, double kichThuocMH)
        {
            ID = iD;
            MaLapTop = maLapTop;
            KichThuocMH = kichThuocMH;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string MaLapTop1 { get => MaLapTop; set => MaLapTop = value; }
        public double KichThuocMH1 { get => KichThuocMH; set => KichThuocMH = value; }

        public void inThongTin()
        {
            Console.WriteLine($"ID : {ID} , Mã LapTop {MaLapTop}, Kích thước màn : {KichThuocMH}");
        }

    }
}
