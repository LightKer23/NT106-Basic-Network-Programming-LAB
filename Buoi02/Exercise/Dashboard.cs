using Exercise.Bai01;
using Exercise.Bai02;
using Exercise.Bai03;
using Exercise.Bai04;
using Exercise.Bai05;
using Exercise.Bai06;
using Exercise.Bai07;

namespace Exercise
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        public void Dashboard_Load(object sender, EventArgs e)
        {
        }

        public void btnBai01_Click(object sender, EventArgs e)
        {
            ReadAndWriteFileForm rawff = new ReadAndWriteFileForm();
            rawff.Show();
        }

        public void btnBai02_Click(object sender, EventArgs e)
        {
            ReadFiletxtForm rawff = new ReadFiletxtForm();
            rawff.Show();
        }

        public void btnBai03_Click(object sender, EventArgs e)
        {
            CalculateForm calc = new CalculateForm();
            calc.Show();
        }

        public void btnBai04_Click(object sender, EventArgs e)
        {
            StudentManagementForm studentManagementForm = new StudentManagementForm();
            studentManagementForm.Show();
        }

        public void btnBai05_Click(object sender, EventArgs e)
        {
            TicketManagementForm ticketManagementForm = new TicketManagementForm();
            ticketManagementForm.Show();
        }

        public void btnBai06_Click(object sender, EventArgs e)
        {
            WhatEatTodayForm whatEatTodayForm = new WhatEatTodayForm();
            whatEatTodayForm.Show();
        }

        public void btnBai07_Click(object sender, EventArgs e)
        {
            TraversalFolderForm traversalFolderForm = new TraversalFolderForm();
            traversalFolderForm.Show();
        }
    }
}
