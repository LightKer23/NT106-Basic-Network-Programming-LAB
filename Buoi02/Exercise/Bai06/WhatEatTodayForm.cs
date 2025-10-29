using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai06
{
    public partial class WhatEatTodayForm : Form
    {
        private DataHelper dataHelper;
        private string getImagePath = string.Empty;

        public WhatEatTodayForm()
        {
            InitializeComponent();
            dataHelper = new DataHelper();
            LoadDishList();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc muốn thoát?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void LoadDishList()
        {
            listView1.Items.Clear();

            DataTable dt = dataHelper.GetAllDishes();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["IDMA"].ToString());
                item.SubItems.Add(row["TenMonAn"].ToString());
                item.SubItems.Add(row["HoVaTen"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void btnPickPic_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openfdl = new OpenFileDialog())
            {
                openfdl.Filter = "Image Files |*.jpg;*.jpeg;*.png;*.bmp";
                if (openfdl.ShowDialog() == DialogResult.OK)
                {
                    getImagePath = openfdl.FileName;
                    MessageBox.Show("Đã chọn hình ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtUser.Text.Trim();
            string quyenHan = txtAccess.Text.Trim();
            string tenMonAn = txtDish.Text.Trim();

            if (string.IsNullOrEmpty(hoVaTen) || string.IsNullOrEmpty(quyenHan) || string.IsNullOrEmpty(tenMonAn))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(getImagePath) || !File.Exists(getImagePath))
            {
                MessageBox.Show("Vui lòng chọn hình ảnh cho món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int idncc = dataHelper.CreateUser(hoVaTen, quyenHan);

                byte[]? imageBytes = null;
                if (!string.IsNullOrEmpty(getImagePath) && File.Exists(getImagePath))
                {
                    imageBytes = File.ReadAllBytes(getImagePath);
                }

                if (dataHelper.AddDish(tenMonAn, imageBytes, idncc))
                {
                    MessageBox.Show("Thêm món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAccess.Text = string.Empty;
                    txtDish.Text = string.Empty;
                    txtUser.Text = string.Empty;
                    getImagePath = string.Empty;
                    LoadDishList();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi thêm món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DishInfo? dish = dataHelper.GetRandomDish();

            if (dish == null)
            {
                MessageBox.Show("Chưa có món ăn để thực hiện chức năng này!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            lblNameDish.Text = "Món ăn: " + dish.TenMonAn;
            lblUserContribute.Text = "Người đóng góp: " + dish.TenNguoiDongGop;

            if (dish.HinhAnh != null && dish.HinhAnh.Length > 0)
            {
                using (var ms = new MemoryStream(dish.HinhAnh))
                {
                    pctDish.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pctDish.Image = null;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                int idma = Convert.ToInt32(listView1.SelectedItems[0].Text);
                DishInfo? monAn = dataHelper.GetDishById(idma);

                if (monAn != null)
                {
                    lblNameDish.Text = monAn.TenMonAn;
                    lblUserContribute.Text = monAn.TenNguoiDongGop;

                    if (monAn.HinhAnh != null && monAn.HinhAnh.Length > 0)
                    {
                        using (var ms = new MemoryStream(monAn.HinhAnh))
                        {
                            pctDish.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        pctDish.Image = null;
                    }
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa món ăn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                int idma = Convert.ToInt32(listView1.SelectedItems[0].Text);

                if (dataHelper.DeleteDish(idma))
                {
                    MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAccess.Text = string.Empty;
                    txtDish.Text = string.Empty;
                    txtUser.Text = string.Empty;
                    getImagePath = string.Empty;
                    LoadDishList();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra khi xóa món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
