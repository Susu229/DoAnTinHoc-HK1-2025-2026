using System.Text;


namespace DoAnTinHoc_QLBanHangCaPhe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dulieudocduoc = XuLyCSV.DocFile();
            if(dulieudocduoc == "Lỗi đọc file")
            {
                MessageBox.Show("Lỗi không tìm thấy file Coffe_sales.csv", "Lỗi file", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Đã đọc dữ liệu: "+ dulieudocduoc);

            if (XuLyCSV.GhiFile(dulieudocduoc))
            {
                MessageBox.Show("Ghi file Baocao_Tuan1.txt thành công", "Thành công!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ghi file Không Thành Công!!", "Lỗi !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}