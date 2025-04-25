namespace WinForms01
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double score1 = Convert.ToDouble(TxtKor.Text);
                double score2 = Convert.ToDouble(TxtEng.Text);
                double score3 = Convert.ToDouble(TxtMath.Text);
                double score4 = Convert.ToDouble(TxtScience.Text);
                double score5 = Convert.ToDouble(TxtSociety.Text);

                double totalScore = score1 + score2 + score3 + score4 + score5;
                double averageScore = totalScore / 5;

                TxtTotal.Text = totalScore.ToString();
                TxtAvg.Text = averageScore.ToString();
            }
            catch
            {
                MessageBox.Show("점수를 올바르게 입력해주세요!");
            }
        }
    }
}
