namespace RBGA
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
            components = new System.ComponentModel.Container();
            PanRGBA = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            PrgRed = new ProgressBar();
            PrgGreen = new ProgressBar();
            PrgBlue = new ProgressBar();
            PrgTotal = new ProgressBar();
            HscRed = new HScrollBar();
            HscGreen = new HScrollBar();
            HscBlue = new HScrollBar();
            HscAlpha = new HScrollBar();
            TxtRed = new TextBox();
            TxtGreen = new TextBox();
            TxtBlue = new TextBox();
            TxtAlpha = new TextBox();
            LblPercent = new Label();
            BtnColor = new Button();
            Timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // PanRGBA
            // 
            PanRGBA.BackColor = Color.Black;
            PanRGBA.Location = new Point(12, 12);
            PanRGBA.Name = "PanRGBA";
            PanRGBA.Size = new Size(440, 185);
            PanRGBA.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 211);
            label1.Name = "label1";
            label1.Size = new Size(22, 15);
            label1.TabIndex = 1;
            label1.Text = "R :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(12, 253);
            label2.Name = "label2";
            label2.Size = new Size(23, 15);
            label2.TabIndex = 1;
            label2.Text = "G :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(12, 295);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 1;
            label3.Text = "B :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(12, 337);
            label4.Name = "label4";
            label4.Size = new Size(22, 15);
            label4.TabIndex = 1;
            label4.Text = "A :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(12, 379);
            label5.Name = "label5";
            label5.Size = new Size(22, 15);
            label5.TabIndex = 1;
            label5.Text = "R :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(12, 421);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 1;
            label6.Text = "G :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label7.ForeColor = Color.Blue;
            label7.Location = new Point(12, 463);
            label7.Name = "label7";
            label7.Size = new Size(22, 15);
            label7.TabIndex = 1;
            label7.Text = "B :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            label8.ForeColor = Color.DimGray;
            label8.Location = new Point(12, 505);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 1;
            label8.Text = "진행률 :";
            // 
            // PrgRed
            // 
            PrgRed.Location = new Point(40, 377);
            PrgRed.Name = "PrgRed";
            PrgRed.Size = new Size(412, 23);
            PrgRed.TabIndex = 2;
            // 
            // PrgGreen
            // 
            PrgGreen.Location = new Point(40, 419);
            PrgGreen.Name = "PrgGreen";
            PrgGreen.Size = new Size(412, 23);
            PrgGreen.TabIndex = 2;
            // 
            // PrgBlue
            // 
            PrgBlue.Location = new Point(40, 461);
            PrgBlue.Name = "PrgBlue";
            PrgBlue.Size = new Size(412, 23);
            PrgBlue.TabIndex = 2;
            // 
            // PrgTotal
            // 
            PrgTotal.Location = new Point(68, 503);
            PrgTotal.Name = "PrgTotal";
            PrgTotal.Size = new Size(268, 23);
            PrgTotal.TabIndex = 2;
            // 
            // HscRed
            // 
            HscRed.LargeChange = 1;
            HscRed.Location = new Point(40, 211);
            HscRed.Maximum = 255;
            HscRed.Name = "HscRed";
            HscRed.Size = new Size(348, 21);
            HscRed.TabIndex = 3;
            HscRed.Scroll += HscRed_Scroll;
            // 
            // HscGreen
            // 
            HscGreen.LargeChange = 1;
            HscGreen.Location = new Point(40, 247);
            HscGreen.Maximum = 255;
            HscGreen.Name = "HscGreen";
            HscGreen.Size = new Size(348, 21);
            HscGreen.TabIndex = 3;
            HscGreen.Scroll += HscGreen_Scroll;
            // 
            // HscBlue
            // 
            HscBlue.LargeChange = 1;
            HscBlue.Location = new Point(40, 295);
            HscBlue.Maximum = 255;
            HscBlue.Name = "HscBlue";
            HscBlue.Size = new Size(348, 21);
            HscBlue.TabIndex = 3;
            HscBlue.Scroll += HscBlue_Scroll;
            // 
            // HscAlpha
            // 
            HscAlpha.LargeChange = 1;
            HscAlpha.Location = new Point(40, 337);
            HscAlpha.Maximum = 255;
            HscAlpha.Name = "HscAlpha";
            HscAlpha.Size = new Size(348, 21);
            HscAlpha.TabIndex = 3;
            HscAlpha.Scroll += HscAlpha_Scroll;
            // 
            // TxtRed
            // 
            TxtRed.Location = new Point(408, 208);
            TxtRed.Name = "TxtRed";
            TxtRed.Size = new Size(44, 23);
            TxtRed.TabIndex = 1;
            TxtRed.TextChanged += TxtRed_TextChanged;
            // 
            // TxtGreen
            // 
            TxtGreen.Location = new Point(408, 250);
            TxtGreen.Name = "TxtGreen";
            TxtGreen.Size = new Size(44, 23);
            TxtGreen.TabIndex = 2;
            TxtGreen.TextChanged += TxtGreen_TextChanged;
            // 
            // TxtBlue
            // 
            TxtBlue.Location = new Point(408, 292);
            TxtBlue.Name = "TxtBlue";
            TxtBlue.Size = new Size(44, 23);
            TxtBlue.TabIndex = 3;
            TxtBlue.TextChanged += TxtBlue_TextChanged;
            // 
            // TxtAlpha
            // 
            TxtAlpha.Location = new Point(408, 334);
            TxtAlpha.Name = "TxtAlpha";
            TxtAlpha.Size = new Size(44, 23);
            TxtAlpha.TabIndex = 4;
            TxtAlpha.TextChanged += TxtAlpha_TextChanged;
            // 
            // LblPercent
            // 
            LblPercent.AutoSize = true;
            LblPercent.Font = new Font("맑은 고딕", 12F, FontStyle.Bold);
            LblPercent.Location = new Point(342, 503);
            LblPercent.Name = "LblPercent";
            LblPercent.Size = new Size(33, 21);
            LblPercent.TabIndex = 5;
            LblPercent.Text = "0%";
            // 
            // BtnColor
            // 
            BtnColor.Font = new Font("맑은 고딕", 9F, FontStyle.Bold);
            BtnColor.Location = new Point(392, 499);
            BtnColor.Name = "BtnColor";
            BtnColor.Size = new Size(60, 30);
            BtnColor.TabIndex = 5;
            BtnColor.Text = "적용";
            BtnColor.UseVisualStyleBackColor = true;
            BtnColor.Click += BtnColor_Click;
            // 
            // Timer
            // 
            Timer.Tick += Timer_Tick;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 541);
            Controls.Add(BtnColor);
            Controls.Add(LblPercent);
            Controls.Add(TxtAlpha);
            Controls.Add(TxtBlue);
            Controls.Add(TxtGreen);
            Controls.Add(TxtRed);
            Controls.Add(HscAlpha);
            Controls.Add(HscBlue);
            Controls.Add(HscGreen);
            Controls.Add(HscRed);
            Controls.Add(PrgTotal);
            Controls.Add(PrgBlue);
            Controls.Add(PrgGreen);
            Controls.Add(PrgRed);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PanRGBA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RGBA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PanRGBA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ProgressBar PrgRed;
        private ProgressBar PrgGreen;
        private ProgressBar PrgBlue;
        private ProgressBar PrgTotal;
        private HScrollBar HscRed;
        private HScrollBar HscGreen;
        private HScrollBar HscBlue;
        private HScrollBar HscAlpha;
        private TextBox TxtRed;
        private TextBox TxtGreen;
        private TextBox TxtBlue;
        private TextBox TxtAlpha;
        private Label LblPercent;
        private Button BtnColor;
        private System.Windows.Forms.Timer Timer;
    }
}
