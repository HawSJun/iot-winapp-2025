namespace WinForms01
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            TxtSociety = new TextBox();
            TxtScience = new TextBox();
            TxtMath = new TextBox();
            TxtEng = new TextBox();
            TxtKor = new TextBox();
            LblSociety = new Label();
            LblScience = new Label();
            LblMath = new Label();
            LblEng = new Label();
            LblKor = new Label();
            groupBox2 = new GroupBox();
            TxtAvg = new TextBox();
            TxtTotal = new TextBox();
            LblAvg = new Label();
            LbTotal = new Label();
            BtnCalc = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(TxtSociety);
            groupBox1.Controls.Add(TxtScience);
            groupBox1.Controls.Add(TxtMath);
            groupBox1.Controls.Add(TxtEng);
            groupBox1.Controls.Add(TxtKor);
            groupBox1.Controls.Add(LblSociety);
            groupBox1.Controls.Add(LblScience);
            groupBox1.Controls.Add(LblMath);
            groupBox1.Controls.Add(LblEng);
            groupBox1.Controls.Add(LblKor);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(260, 247);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "성적입력";
            // 
            // TxtSociety
            // 
            TxtSociety.Location = new Point(76, 196);
            TxtSociety.Name = "TxtSociety";
            TxtSociety.Size = new Size(155, 23);
            TxtSociety.TabIndex = 5;
            // 
            // TxtScience
            // 
            TxtScience.Location = new Point(76, 154);
            TxtScience.Name = "TxtScience";
            TxtScience.Size = new Size(155, 23);
            TxtScience.TabIndex = 4;
            // 
            // TxtMath
            // 
            TxtMath.Location = new Point(76, 112);
            TxtMath.Name = "TxtMath";
            TxtMath.Size = new Size(155, 23);
            TxtMath.TabIndex = 3;
            // 
            // TxtEng
            // 
            TxtEng.Location = new Point(76, 70);
            TxtEng.Name = "TxtEng";
            TxtEng.Size = new Size(155, 23);
            TxtEng.TabIndex = 2;
            // 
            // TxtKor
            // 
            TxtKor.Location = new Point(76, 28);
            TxtKor.Name = "TxtKor";
            TxtKor.Size = new Size(155, 23);
            TxtKor.TabIndex = 1;
            // 
            // LblSociety
            // 
            LblSociety.AutoSize = true;
            LblSociety.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblSociety.Location = new Point(31, 199);
            LblSociety.Name = "LblSociety";
            LblSociety.Size = new Size(38, 15);
            LblSociety.TabIndex = 0;
            LblSociety.Text = "사회 :";
            // 
            // LblScience
            // 
            LblScience.AutoSize = true;
            LblScience.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblScience.Location = new Point(31, 157);
            LblScience.Name = "LblScience";
            LblScience.Size = new Size(38, 15);
            LblScience.TabIndex = 0;
            LblScience.Text = "과학 :";
            // 
            // LblMath
            // 
            LblMath.AutoSize = true;
            LblMath.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblMath.Location = new Point(31, 112);
            LblMath.Name = "LblMath";
            LblMath.Size = new Size(38, 15);
            LblMath.TabIndex = 0;
            LblMath.Text = "수학 :";
            // 
            // LblEng
            // 
            LblEng.AutoSize = true;
            LblEng.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblEng.Location = new Point(31, 73);
            LblEng.Name = "LblEng";
            LblEng.Size = new Size(38, 15);
            LblEng.TabIndex = 0;
            LblEng.Text = "영어 :";
            // 
            // LblKor
            // 
            LblKor.AutoSize = true;
            LblKor.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblKor.Location = new Point(31, 31);
            LblKor.Name = "LblKor";
            LblKor.Size = new Size(38, 15);
            LblKor.TabIndex = 0;
            LblKor.Text = "국어 :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TxtAvg);
            groupBox2.Controls.Add(TxtTotal);
            groupBox2.Controls.Add(LblAvg);
            groupBox2.Controls.Add(LbTotal);
            groupBox2.Location = new Point(12, 302);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(260, 97);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "결과";
            // 
            // TxtAvg
            // 
            TxtAvg.BackColor = Color.White;
            TxtAvg.Location = new Point(76, 57);
            TxtAvg.Name = "TxtAvg";
            TxtAvg.ReadOnly = true;
            TxtAvg.Size = new Size(155, 23);
            TxtAvg.TabIndex = 8;
            // 
            // TxtTotal
            // 
            TxtTotal.BackColor = Color.White;
            TxtTotal.Location = new Point(76, 22);
            TxtTotal.Name = "TxtTotal";
            TxtTotal.ReadOnly = true;
            TxtTotal.Size = new Size(155, 23);
            TxtTotal.TabIndex = 7;
            // 
            // LblAvg
            // 
            LblAvg.AutoSize = true;
            LblAvg.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LblAvg.Location = new Point(23, 60);
            LblAvg.Name = "LblAvg";
            LblAvg.Size = new Size(38, 15);
            LblAvg.TabIndex = 1;
            LblAvg.Text = "평균 :";
            // 
            // LbTotal
            // 
            LbTotal.AutoSize = true;
            LbTotal.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            LbTotal.Location = new Point(23, 25);
            LbTotal.Name = "LbTotal";
            LbTotal.Size = new Size(38, 15);
            LbTotal.TabIndex = 0;
            LbTotal.Text = "총점 :";
            // 
            // BtnCalc
            // 
            BtnCalc.BackColor = Color.Silver;
            BtnCalc.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnCalc.ForeColor = SystemColors.ControlText;
            BtnCalc.Location = new Point(12, 265);
            BtnCalc.Name = "BtnCalc";
            BtnCalc.Size = new Size(260, 31);
            BtnCalc.TabIndex = 6;
            BtnCalc.Text = "계산";
            BtnCalc.UseVisualStyleBackColor = false;
            BtnCalc.Click += BtnCalc_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 411);
            Controls.Add(BtnCalc);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "성적계산기";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label LblSociety;
        private Label LblScience;
        private Label LblMath;
        private Label LblEng;
        private Label LblKor;
        private Button BtnCalc;
        private TextBox TxtSociety;
        private TextBox TxtScience;
        private TextBox TxtMath;
        private TextBox TxtEng;
        private TextBox TxtKor;
        private TextBox TxtAvg;
        private TextBox TxtTotal;
        private Label LblAvg;
        private Label LbTotal;
    }
}
