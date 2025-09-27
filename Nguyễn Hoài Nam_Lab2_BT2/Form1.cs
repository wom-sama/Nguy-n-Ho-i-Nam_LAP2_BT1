using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nguyễn_Hoài_Nam_Lab2_BT2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void grBGT_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblCN_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string hoten = txtName.Text.Trim();
            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            string CN = cmbCN.Text;
            string dtb = txtDTB.Text.Trim();

            // Kiểm tra nhập liệu
            if (mssv == "" || hoten == "" || dtb == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo");
                return;
            }
            dataStudent.Rows.Add(mssv, hoten, gioitinh, dtb, CN);
            MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông Báo");
            TinhTongSV();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string mssv = txtMSSV.Text.Trim();
            if (mssv == "")
            {
                MessageBox.Show("Vui lòng nhập MSSV cần xóa!", "Thông Báo");
                return;
            }

            DataGridViewRow foundRow = null;
            foreach (DataGridViewRow row in dataStudent.Rows)
            {
                if (row.Cells["MSSV"].Value != null && row.Cells["MSSV"].Value.ToString() == mssv)
                {
                    foundRow = row;
                    break;
                }
            }

            if (foundRow == null)
            {
                MessageBox.Show("Không tìm thấy MSSV cần xóa!", "Thông Báo");
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    dataStudent.Rows.Remove(foundRow);
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông Báo");
                    TinhTongSV();
                }
            }
        }

        private void TinhTongSV()
        {
            int tongNam = 0;
            int tongNu = 0;
            foreach (DataGridViewRow row in dataStudent.Rows)
            {
                if (row.Cells["GT"].Value != null)
                {
                    string gt = row.Cells["GT"].Value.ToString();
                    if (gt == "Nam") tongNam++;
                    else if (gt == "Nữ") tongNu++;
                }
            }
            txtTongNam.Text = tongNam.ToString();
            txtTongNu.Text = tongNu.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbCN.SelectedIndex = 0;

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text.Trim();
            string hoten = txtName.Text.Trim();
            string gioitinh = radNam.Checked ? "Nam" : "Nữ";
            string CN = cmbCN.Text;
            string dtb = txtDTB.Text.Trim();

            // Kiểm tra nhập liệu
            if (mssv == "" || hoten == "" || dtb == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông Báo");
                return;
            }
            DataGridViewRow foundRow = null;
            foreach (DataGridViewRow row in dataStudent.Rows)
            {
                if (row.Cells["MSSV"].Value != null && row.Cells["MSSV"].Value.ToString() == mssv)
                {
                    foundRow = row;
                    break;
                }
            }
            foundRow.Cells["HoTen"].Value = hoten;
            foundRow.Cells["GT"].Value = gioitinh;
            foundRow.Cells["DTB"].Value = dtb;
            foundRow.Cells["CN"].Value = CN;
            MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông Báo");
            TinhTongSV();

        }

        private void btnRS_Click(object sender, EventArgs e)
        {
            // Xóa các textbox
            txtMSSV.Text = "";
            txtName.Text = "";
            txtDTB.Text = "";

            // Reset RadioButton Giới Tính
            radNu.Checked = true;
            radNam.Checked = false;

            // Reset ComboBox Chuyên Ngành (chọn item đầu hoặc none)
            if (cmbCN.Items.Count > 0)
                cmbCN.SelectedIndex = 0;
        }

        private void dataStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataStudent.Rows[e.RowIndex];
                txtMSSV.Text = row.Cells["MSSV"].Value?.ToString();
                txtName.Text = row.Cells["HoTen"].Value?.ToString();
                txtDTB.Text = row.Cells["DTB"].Value?.ToString();
                cmbCN.Text = row.Cells["CN"].Value?.ToString();


                string gt = row.Cells["GT"].Value?.ToString();
                if (gt == "Nam") radNam.Checked = true;
                else radNu.Checked = true;
            }

        }

        private void txtDTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Chỉ cho phép một dấu chấm
            if (e.KeyChar == '.' && (sender as TextBox).Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void txtMSSV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Chặn phím không hợp lệ
            }
        }
    }
}
