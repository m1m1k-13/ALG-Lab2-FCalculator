namespace lab_2
{
    partial class Calculator
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
            input = new TextBox();
            accuracy = new TextBox();
            exBtn = new Button();
            sqrtBtn = new Button();
            ctgBtn = new Button();
            lnBtn = new Button();
            lgBtn = new Button();
            sinBtn = new Button();
            cosBtn = new Button();
            tgBtn = new Button();
            clearBtn = new Button();
            result = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            trigMode = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // input
            // 
            input.BackColor = Color.FromArgb(40, 30, 60);
            input.BorderStyle = BorderStyle.None;
            input.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            input.ForeColor = Color.White;
            input.Location = new Point(2, 36);
            input.Name = "input";
            input.Size = new Size(360, 54);
            input.TabIndex = 0;
            input.Text = "0";
            input.TextAlign = HorizontalAlignment.Right;
            input.WordWrap = false;
            input.KeyPress += TextBox_KeyPress;
            input.Leave += TextBox_EmptyToZero;
            // 
            // accuracy
            // 
            accuracy.BackColor = Color.FromArgb(40, 30, 60);
            accuracy.BorderStyle = BorderStyle.None;
            accuracy.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            accuracy.ForeColor = Color.White;
            accuracy.Location = new Point(2, 126);
            accuracy.Name = "accuracy";
            accuracy.Size = new Size(360, 54);
            accuracy.TabIndex = 1;
            accuracy.Text = "0,001";
            accuracy.TextAlign = HorizontalAlignment.Right;
            accuracy.WordWrap = false;
            accuracy.KeyPress += TextBox_KeyPress;
            accuracy.Leave += TextBox_EmptyToZero;
            // 
            // exBtn
            // 
            exBtn.Anchor = AnchorStyles.Bottom;
            exBtn.BackColor = Color.FromArgb(20, 15, 30);
            exBtn.Cursor = Cursors.Hand;
            exBtn.FlatAppearance.BorderSize = 0;
            exBtn.FlatAppearance.CheckedBackColor = Color.White;
            exBtn.FlatStyle = FlatStyle.Flat;
            exBtn.Image = Properties.Resources.ex;
            exBtn.Location = new Point(2, 400);
            exBtn.Name = "exBtn";
            exBtn.Size = new Size(110, 55);
            exBtn.TabIndex = 4;
            exBtn.UseVisualStyleBackColor = false;
            exBtn.Click += ExBtn_Click;
            // 
            // sqrtBtn
            // 
            sqrtBtn.Anchor = AnchorStyles.Bottom;
            sqrtBtn.BackColor = Color.FromArgb(20, 15, 30);
            sqrtBtn.Cursor = Cursors.Hand;
            sqrtBtn.FlatAppearance.BorderSize = 0;
            sqrtBtn.FlatAppearance.CheckedBackColor = Color.White;
            sqrtBtn.FlatStyle = FlatStyle.Flat;
            sqrtBtn.Image = Properties.Resources.sqrtx1;
            sqrtBtn.Location = new Point(127, 400);
            sqrtBtn.Name = "sqrtBtn";
            sqrtBtn.Size = new Size(110, 55);
            sqrtBtn.TabIndex = 5;
            sqrtBtn.UseVisualStyleBackColor = false;
            sqrtBtn.Click += SqrtBtn_Click;
            // 
            // ctgBtn
            // 
            ctgBtn.Anchor = AnchorStyles.Bottom;
            ctgBtn.BackColor = Color.FromArgb(20, 15, 30);
            ctgBtn.Cursor = Cursors.Hand;
            ctgBtn.FlatAppearance.BorderSize = 0;
            ctgBtn.FlatAppearance.CheckedBackColor = Color.White;
            ctgBtn.FlatStyle = FlatStyle.Flat;
            ctgBtn.Image = Properties.Resources.ctgx;
            ctgBtn.Location = new Point(252, 549);
            ctgBtn.Name = "ctgBtn";
            ctgBtn.Size = new Size(110, 55);
            ctgBtn.TabIndex = 11;
            ctgBtn.UseVisualStyleBackColor = false;
            ctgBtn.Click += CtgBtn_Click;
            // 
            // lnBtn
            // 
            lnBtn.Anchor = AnchorStyles.Bottom;
            lnBtn.BackColor = Color.FromArgb(20, 15, 30);
            lnBtn.Cursor = Cursors.Hand;
            lnBtn.FlatAppearance.BorderSize = 0;
            lnBtn.FlatAppearance.CheckedBackColor = Color.White;
            lnBtn.FlatStyle = FlatStyle.Flat;
            lnBtn.Image = Properties.Resources.lnx;
            lnBtn.Location = new Point(2, 473);
            lnBtn.Name = "lnBtn";
            lnBtn.Size = new Size(110, 55);
            lnBtn.TabIndex = 7;
            lnBtn.UseVisualStyleBackColor = false;
            lnBtn.Click += LnBtn_Click;
            // 
            // lgBtn
            // 
            lgBtn.Anchor = AnchorStyles.Bottom;
            lgBtn.BackColor = Color.FromArgb(20, 15, 30);
            lgBtn.Cursor = Cursors.Hand;
            lgBtn.FlatAppearance.BorderSize = 0;
            lgBtn.FlatAppearance.CheckedBackColor = Color.White;
            lgBtn.FlatStyle = FlatStyle.Flat;
            lgBtn.Image = Properties.Resources.lgx;
            lgBtn.Location = new Point(127, 473);
            lgBtn.Name = "lgBtn";
            lgBtn.Size = new Size(110, 55);
            lgBtn.TabIndex = 8;
            lgBtn.UseVisualStyleBackColor = false;
            lgBtn.Click += LgBtn_Click;
            // 
            // sinBtn
            // 
            sinBtn.Anchor = AnchorStyles.Bottom;
            sinBtn.BackColor = Color.FromArgb(20, 15, 30);
            sinBtn.Cursor = Cursors.Hand;
            sinBtn.FlatAppearance.BorderSize = 0;
            sinBtn.FlatAppearance.CheckedBackColor = Color.White;
            sinBtn.FlatStyle = FlatStyle.Flat;
            sinBtn.Image = Properties.Resources.sinx;
            sinBtn.Location = new Point(252, 473);
            sinBtn.Name = "sinBtn";
            sinBtn.Size = new Size(110, 55);
            sinBtn.TabIndex = 9;
            sinBtn.UseVisualStyleBackColor = false;
            sinBtn.Click += SinBtn_Click;
            // 
            // cosBtn
            // 
            cosBtn.Anchor = AnchorStyles.Bottom;
            cosBtn.BackColor = Color.FromArgb(20, 15, 30);
            cosBtn.Cursor = Cursors.Hand;
            cosBtn.FlatAppearance.BorderSize = 0;
            cosBtn.FlatAppearance.CheckedBackColor = Color.White;
            cosBtn.FlatStyle = FlatStyle.Flat;
            cosBtn.Image = Properties.Resources.cosx;
            cosBtn.Location = new Point(2, 549);
            cosBtn.Name = "cosBtn";
            cosBtn.Size = new Size(110, 55);
            cosBtn.TabIndex = 10;
            cosBtn.UseVisualStyleBackColor = false;
            cosBtn.Click += CosBtn_Click;
            // 
            // tgBtn
            // 
            tgBtn.Anchor = AnchorStyles.Bottom;
            tgBtn.BackColor = Color.FromArgb(20, 15, 30);
            tgBtn.Cursor = Cursors.Hand;
            tgBtn.FlatAppearance.BorderSize = 0;
            tgBtn.FlatAppearance.CheckedBackColor = Color.White;
            tgBtn.FlatStyle = FlatStyle.Flat;
            tgBtn.Image = Properties.Resources.tgx;
            tgBtn.Location = new Point(127, 549);
            tgBtn.Name = "tgBtn";
            tgBtn.Size = new Size(110, 55);
            tgBtn.TabIndex = 11;
            tgBtn.UseVisualStyleBackColor = false;
            tgBtn.Click += TgBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom;
            clearBtn.BackColor = Color.OrangeRed;
            clearBtn.Cursor = Cursors.Hand;
            clearBtn.FlatAppearance.BorderSize = 0;
            clearBtn.FlatAppearance.CheckedBackColor = Color.White;
            clearBtn.FlatStyle = FlatStyle.Flat;
            clearBtn.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            clearBtn.Location = new Point(252, 400);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(110, 55);
            clearBtn.TabIndex = 6;
            clearBtn.Text = "C";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += ClearBtn_Click;
            // 
            // result
            // 
            result.BackColor = Color.FromArgb(40, 30, 60);
            result.BorderStyle = BorderStyle.None;
            result.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            result.ForeColor = Color.White;
            result.Location = new Point(2, 222);
            result.Name = "result";
            result.ReadOnly = true;
            result.Size = new Size(360, 54);
            result.TabIndex = 2;
            result.TextAlign = HorizontalAlignment.Right;
            result.WordWrap = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(2, 1);
            label1.Name = "label1";
            label1.Size = new Size(147, 32);
            label1.TabIndex = 12;
            label1.Text = "Значение x:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(2, 91);
            label2.Name = "label2";
            label2.Size = new Size(170, 32);
            label2.TabIndex = 13;
            label2.Text = "Погрешность:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(2, 187);
            label3.Name = "label3";
            label3.Size = new Size(235, 32);
            label3.TabIndex = 14;
            label3.Text = "Значение функции:";
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(trigMode);
            panel1.Controls.Add(input);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(accuracy);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(exBtn);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(sqrtBtn);
            panel1.Controls.Add(result);
            panel1.Controls.Add(ctgBtn);
            panel1.Controls.Add(clearBtn);
            panel1.Controls.Add(lnBtn);
            panel1.Controls.Add(tgBtn);
            panel1.Controls.Add(lgBtn);
            panel1.Controls.Add(cosBtn);
            panel1.Controls.Add(sinBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 604);
            panel1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(2, 284);
            label4.Name = "label4";
            label4.Size = new Size(192, 32);
            label4.TabIndex = 16;
            label4.Text = "Тригонометрия:";
            // 
            // trigMode
            // 
            trigMode.BackColor = Color.FromArgb(40, 30, 60);
            trigMode.FlatStyle = FlatStyle.Flat;
            trigMode.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            trigMode.ForeColor = Color.White;
            trigMode.FormattingEnabled = true;
            trigMode.Items.AddRange(new object[] { "В радианах", "В градусах" });
            trigMode.Location = new Point(3, 328);
            trigMode.Name = "trigMode";
            trigMode.RightToLeft = RightToLeft.No;
            trigMode.Size = new Size(358, 40);
            trigMode.TabIndex = 3;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(40, 30, 60);
            ClientSize = new Size(403, 644);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ForeColor = Color.White;
            Margin = new Padding(4);
            MaximizeBox = false;
            MaximumSize = new Size(425, 700);
            MinimumSize = new Size(425, 700);
            Name = "Calculator";
            Padding = new Padding(20);
            ShowIcon = false;
            Text = "Калькулятор";
            TopMost = true;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox input;
        private TextBox accuracy;
        private Button exBtn;
        private Button sqrtBtn;
        private Button ctgBtn;
        private Button lnBtn;
        private Button lgBtn;
        private Button sinBtn;
        private Button cosBtn;
        private Button tgBtn;
        private Button clearBtn;
        private TextBox result;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
        private ComboBox trigMode;
    }
}
