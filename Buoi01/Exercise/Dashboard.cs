using Exercise.Bai01;
using Exercise.Bai02;
using Exercise.Bai03;
using Exercise.Bai04;
using Exercise.Bai05;
using Exercise.Bai06;
using Exercise.Bai07;
using Exercise.Bai08;
using Exercise.Bai09;


namespace Exercise
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnBai03_Click(object sender, EventArgs e)
        {
            ReadNumberForm readNumberForm = new ReadNumberForm();
            readNumberForm.Show();
        }

        private void btnBai01_Click(object sender, EventArgs e)
        {
            TwoSumForm twoSumForm = new TwoSumForm();
            twoSumForm.Show();
        }

        private void btnBai02_Click(object sender, EventArgs e)
        {
            FindMaxMinForm findMaxMinForm = new FindMaxMinForm();
            findMaxMinForm.Show();
        }

        private void btnBai04_Click(object sender, EventArgs e)
        {
            ReadNumberAdvanceForm readNumberAdvanceForm = new ReadNumberAdvanceForm();
            readNumberAdvanceForm.Show();
        }

        private void btnBai05_Click(object sender, EventArgs e)
        {
            MovieTicketApp movie = new MovieTicketApp();
            movie.Show();
        }

        private void btnBai06_Click(object sender, EventArgs e)
        {
            MultiplicationTableForm multiplicationTableForm = new MultiplicationTableForm();
            multiplicationTableForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ZodiacForm zodiacForm = new ZodiacForm();
            zodiacForm.Show();
        }

        private void btnBai08_Click(object sender, EventArgs e)
        {
            ArrayProcessingForm arrayProcessingForm = new ArrayProcessingForm();
            arrayProcessingForm.Show();
        }

        private void btnBai09_Click(object sender, EventArgs e)
        {
            WhatToEatTodayForm whatToEatTodayForm = new WhatToEatTodayForm();
            whatToEatTodayForm.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
