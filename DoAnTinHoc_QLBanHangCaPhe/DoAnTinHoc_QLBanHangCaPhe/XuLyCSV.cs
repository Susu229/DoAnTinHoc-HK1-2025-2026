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
            string filePath = "Coffe_sales.csv";
            if (!File.Exists(filePath))
            {
                return "Lỗi đọc file";
            }
            string[]lines = File.ReadAllLines(filePath);
            if(lines.Length > 0)
            {
                return lines[0];
            }
            return "File rỗng";
        }

        public static bool GhiFile(string content)
        {
            string summaryFilePath = "Baocao_Tuan1.txt";
            try
            {
                File.WriteAllText(summaryFilePath, "\n Bao cao da duoc ghi thanh cong. Du lieu doc duoc: " + content);
                return true;
            } catch (Exception)
            {
                return false;
            }
        }
    }
}
