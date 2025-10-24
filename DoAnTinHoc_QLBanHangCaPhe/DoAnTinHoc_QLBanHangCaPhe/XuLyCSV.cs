using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnTinHoc_QLBanHangCaPhe
{
    public static class XuLyCSV
    {
        public static string DocFile()
        {
            string filecsv = "Coffe_sales.csv";
            if (!File.Exists(filecsv))
            {
                return "Lỗi đọc file";
            }
            string[]lines = File.ReadAllLines(filecsv);
            if(lines.Length > 0)
            {
                return lines[0];
            }
            return "File rỗng";
        }

        public static bool GhiFile(string gf)
        {
            string fileBaocao = "Baocao_Tuan1.txt";
            try
            {
                File.WriteAllText(fileBaocao, "\n Bao cao da duoc ghi thanh cong. Du lieu doc duoc: " + gf);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
