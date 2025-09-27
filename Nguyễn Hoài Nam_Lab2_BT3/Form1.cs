using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguyễn_Hoài_Nam_Lab2_BT3
{
    public partial class Form1 : Form
    {
        private List<Button> gheDangChon = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control c in grbGhe.Controls)
            {
                if (c is Button && c.Name.StartsWith("button"))
                {
                    c.BackColor = Color.White;   // nền trắng = ghế trống
                    c.Enabled = true;            // bật lại ghế (phòng khi bạn muốn reset toàn bộ)
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.White) // ghế trống
            {
                btn.BackColor = Color.Blue; // chọn
                txtTien.Text = TinhTongTien().ToString()+" VNĐ";
            }
            else if (btn.BackColor == Color.Blue) // ghế đang chọn
            {

                btn.BackColor = Color.White; // bỏ chọn
            }
            else if (btn.BackColor == Color.Yellow) // ghế đã bán
            {
                MessageBox.Show("Ghế " + btn.Text + " đã được bán!");
            }
            
        }
        private int TinhTien(int soGhe)
        {
            if (soGhe >= 1 && soGhe <= 5) return 30000;
            else if (soGhe >= 6 && soGhe <= 10) return 40000;
            else if (soGhe >= 11 && soGhe <= 15) return 50000;
            else if (soGhe >= 16 && soGhe <= 20) return 80000;
            return 0;
        }
        private int TinhTongTien()
        {
            int tong = 0;
            foreach (Control c in grbGhe.Controls)
            {
                if (c is Button btn && btn.BackColor == Color.Blue) // ghế đang chọn
                {
                    int soGhe = int.Parse(btn.Text);
                    tong += TinhTien(soGhe);
                }
            }
            return tong;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            foreach (Control c in grbGhe.Controls)
            {
                if (c is Button btn && btn.BackColor == Color.Blue) // ghế đang chọn
                {
                    btn.BackColor = Color.Yellow; // chuyển sang ghế đã bán
                }
            }

            // Xoá text box tiền
            txtTien.Clear();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            foreach (Control c in grbGhe.Controls)
            {
                if (c is Button btn && btn.BackColor == Color.Blue) // ghế đang chọn
                {
                    btn.BackColor = Color.White; // trả lại ghế trống
                }
            }

            // Xoá text box tiền
            txtTien.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc muốn kết thúc chương trình không?",
        "Xác nhận thoát",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
