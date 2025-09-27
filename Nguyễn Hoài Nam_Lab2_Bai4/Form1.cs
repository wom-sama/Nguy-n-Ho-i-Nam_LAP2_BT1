using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Nguyễn_Hoài_Nam_Lab2_Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
        private void TinhTongTien()
        {
            long tong = 0;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                tong += long.Parse(item.SubItems[4].Text);
            }
            txtTongTien.Text = tong.ToString();
        }

        // Nút Thêm/Sửa
        private void btnThemSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSTK.Text) ||
                string.IsNullOrWhiteSpace(txtTKH.Text) ||
                string.IsNullOrWhiteSpace(txtDC.Text) ||
                string.IsNullOrWhiteSpace(txtST.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Kiểm tra số tài khoản đã tồn tại chưa
            ListViewItem existingItem = null;
            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == txtSTK.Text)
                {
                    existingItem = item;
                    break;
                }
            }

            if (existingItem == null)
            {
                // Thêm mới
                int stt = lvTaiKhoan.Items.Count + 1;
                ListViewItem lvi = new ListViewItem(stt.ToString());
                lvi.SubItems.Add(txtSTK.Text);
                lvi.SubItems.Add(txtTKH.Text);
                lvi.SubItems.Add(txtDC.Text);
                lvi.SubItems.Add(txtST.Text);

                lvTaiKhoan.Items.Add(lvi);

                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo");
            }
            else
            {
                // Cập nhật
                existingItem.SubItems[2].Text = txtTKH.Text;
                existingItem.SubItems[3].Text = txtDC.Text;
                existingItem.SubItems[4].Text = txtST.Text;

                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo");
            }

            TinhTongTien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string stk = txtSTK.Text;
            ListViewItem itemXoa = null;

            foreach (ListViewItem item in lvTaiKhoan.Items)
            {
                if (item.SubItems[1].Text == stk)
                {
                    itemXoa = item;
                    break;
                }
            }

            if (itemXoa == null)
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa tài khoản này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lvTaiKhoan.Items.Remove(itemXoa);
                MessageBox.Show("Xóa tài khoản thành công!", "Thông báo");
                TinhTongTien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void lvTaiKhoan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTaiKhoan.SelectedItems.Count > 0)
            {
                ListViewItem item = lvTaiKhoan.SelectedItems[0]; // lấy dòng được chọn

                // Đưa dữ liệu ngược vào các TextBox
                txtSTK.Text = item.SubItems[1].Text;   // cột Mã Tài Khoản
                txtTKH.Text = item.SubItems[2].Text;        // cột Tên Khách Hàng
                txtDC.Text = item.SubItems[3].Text;       // cột Địa Chỉ
                txtST.Text = item.SubItems[4].Text;       // cột Số Tiền
            }
        }
    }
}
