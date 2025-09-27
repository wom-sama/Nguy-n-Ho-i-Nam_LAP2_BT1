using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguyễn_Hoài_Nam_LAP2_BT1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Chi cho nhap so
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn phím không hợp lệ
            }

        }

        private void txtNumber2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn phím không hợp lệ
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                
                txtAnswer.Text = (float.Parse(txtNumber1.Text) + float.Parse(txtNumber2.Text)).ToString();
            } catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!!\n "+ex.Message, "Thông Báo");
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try
            {

                txtAnswer.Text = (float.Parse(txtNumber1.Text) - float.Parse(txtNumber2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!!\n " + ex.Message, "Thông Báo");
            }

        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            try
            {

                txtAnswer.Text = (float.Parse(txtNumber1.Text) * float.Parse(txtNumber2.Text)).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!!\n " + ex.Message, "Thông Báo");
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try
            {

                txtAnswer.Text = (float.Parse(txtNumber1.Text) / float.Parse(txtNumber2.Text)).ToString();
                if (float.Parse(txtNumber2.Text) == 0)
                {
                    txtAnswer.Text = "Error";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi !!!!!\n " + ex.Message, "Thông Báo");
            }
        }
    }
}
