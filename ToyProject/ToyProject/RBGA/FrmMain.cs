namespace RBGA
{
    public partial class FrmMain : Form
    {
        private int targetR, targetG, targetB, targetA;

        public FrmMain()
        {
            InitializeComponent();

            // 초기 설정
            TxtRed.Text = "0";
            TxtGreen.Text = "0";
            TxtBlue.Text = "0";
            TxtAlpha.Text = "255";

            PrgRed.Maximum = 255;
            PrgGreen.Maximum = 255;
            PrgBlue.Maximum = 255;

            PrgTotal.Maximum = 100;

            Timer.Interval = 20;
            Timer.Enabled = false;
        }

        private void TxtRed_TextChanged(object sender, EventArgs e)
        {
            int r = ClampTextbox(TxtRed);
            HscRed.Value = Math.Max(HscRed.Minimum, Math.Min(HscRed.Maximum, r));
            PrgRed.Value = r;
        }

        private void TxtGreen_TextChanged(object sender, EventArgs e)
        {
            int g = ClampTextbox(TxtGreen);
            HscGreen.Value = Math.Max(HscGreen.Minimum, Math.Min(HscGreen.Maximum, g));
            PrgGreen.Value = g;
        }

        private void TxtBlue_TextChanged(object sender, EventArgs e)
        {
            int b = ClampTextbox(TxtBlue);
            HscBlue.Value = Math.Max(HscBlue.Minimum, Math.Min(HscBlue.Maximum, b));
            PrgBlue.Value = b;
        }

        private void TxtAlpha_TextChanged(object sender, EventArgs e)
        {
            int a = ClampTextbox(TxtAlpha);
            HscAlpha.Value = Math.Max(HscAlpha.Minimum, Math.Min(HscAlpha.Maximum, a));
        }

        private void HscRed_Scroll(object sender, ScrollEventArgs e)
        {
            TxtRed.Text = HscRed.Value.ToString();
            PrgRed.Value = HscRed.Value;
        }

        private void HscGreen_Scroll(object sender, ScrollEventArgs e)
        {
            TxtGreen.Text = HscGreen.Value.ToString();
            PrgGreen.Value = HscGreen.Value;
        }

        private void HscBlue_Scroll(object sender, ScrollEventArgs e)
        {
            TxtBlue.Text = HscBlue.Value.ToString();
            PrgBlue.Value = HscBlue.Value;
        }

        private void HscAlpha_Scroll(object sender, ScrollEventArgs e)
        {
            TxtAlpha.Text = HscAlpha.Value.ToString();
        }

        private int ClampTextbox(TextBox tb)
        {
            try
            {
                int val = Convert.ToInt32(tb.Text);
                val = Math.Max(0, Math.Min(255, val));
                tb.Text = val.ToString();
                return val;
            }
            catch
            {
                tb.Text = "0";
                return 0;
            }
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            targetR = ClampTextbox(TxtRed);
            targetG = ClampTextbox(TxtGreen);
            targetB = ClampTextbox(TxtBlue);
            targetA = ClampTextbox(TxtAlpha);

            PrgTotal.Value = 0;
            Timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (PrgTotal.Value < 100)
            {
                PrgTotal.Value += 1;
                LblPercent.Text = $"{PrgTotal.Value}%";
            }
            else
            {
                Timer.Stop();
                SetFinalColor();
            }
        }
        private void SetFinalColor()
        {
            PanRGBA.BackColor = Color.FromArgb(targetA, targetR, targetG, targetB);

            int rgbSum = targetR + targetG + targetB;
            int percent = (int)((rgbSum / 765.0) * 100);
            PrgTotal.Value = 100;
            LblPercent.Text = "100%";

            MessageBox.Show("색상 적용이 완료되었습니다!", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}