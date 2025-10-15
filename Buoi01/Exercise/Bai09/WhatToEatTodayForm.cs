using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise.Bai09
{
    public partial class WhatToEatTodayForm : Form
    {
        public WhatToEatTodayForm()
        {
            InitializeComponent();
        }

        private void WhatToEatTodayForm_Load(object sender, EventArgs e)
        {
            string[] dishes = { "Bún riêu", "Bún thịt nướng", "Cơm tấm sườn trứng", "Phở", "Gỏi cuốn" };
            foreach (string dis in dishes)
            {
                lstDishes.Items.Add(dis);
            }
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (lstDishes.Items.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random rand = new Random();
            int index = rand.Next(lstDishes.Items.Count);
            string selectedDish = lstDishes.Items[index].ToString();

            lblOuput.Text = $"Hôm nay bạn nên ăn: {selectedDish}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string newDish = txtInput.Text.Trim();

            if (string.IsNullOrEmpty(newDish))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (string item in lstDishes.Items)
            {
                if (string.Equals(item, newDish, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("Món ăn này đã có trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            lstDishes.Items.Add(newDish);
            txtInput.Clear();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (lstDishes.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstDishes.Items.Remove(lstDishes.SelectedItem);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
