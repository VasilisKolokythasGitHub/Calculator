namespace Calculator
{
    partial class Form1
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
            textBox = new TextBox();
            SevenBtn = new Button();
            EightBtn = new Button();
            NineBtn = new Button();
            FourBtn = new Button();
            FiveBtn = new Button();
            SixBtn = new Button();
            ThreeBtn = new Button();
            TwoBtn = new Button();
            OneBtn = new Button();
            EqualsBtn = new Button();
            DotBtn = new Button();
            ZeroBtn = new Button();
            ClearBtn = new Button();
            DivBtn = new Button();
            PlusBtn = new Button();
            MinusBtn = new Button();
            MulBtn = new Button();
            MinPlusBtn = new Button();
            ModBtn = new Button();
            SuspendLayout();
            // 
            // textBox
            // 
            textBox.AccessibleName = "";
            textBox.Font = new Font("Segoe UI", 26F);
            textBox.Location = new Point(12, 14);
            textBox.Multiline = true;
            textBox.Name = "textBox";
            textBox.Size = new Size(479, 52);
            textBox.TabIndex = 0;
            textBox.Text = "0";
            textBox.TextAlign = HorizontalAlignment.Right;
            textBox.TextChanged += textBox1_TextChanged;
            // 
            // SevenBtn
            // 
            SevenBtn.Font = new Font("Segoe UI", 12F);
            SevenBtn.Location = new Point(17, 79);
            SevenBtn.Name = "SevenBtn";
            SevenBtn.Size = new Size(88, 57);
            SevenBtn.TabIndex = 1;
            SevenBtn.Text = "7";
            SevenBtn.UseVisualStyleBackColor = true;
            SevenBtn.Click += button1_Click;
            // 
            // EightBtn
            // 
            EightBtn.Font = new Font("Segoe UI", 12F);
            EightBtn.Location = new Point(111, 79);
            EightBtn.Name = "EightBtn";
            EightBtn.Size = new Size(88, 57);
            EightBtn.TabIndex = 2;
            EightBtn.Text = "8";
            EightBtn.UseVisualStyleBackColor = true;
            EightBtn.Click += EightBtn_Click;
            // 
            // NineBtn
            // 
            NineBtn.Font = new Font("Segoe UI", 12F);
            NineBtn.Location = new Point(205, 79);
            NineBtn.Name = "NineBtn";
            NineBtn.Size = new Size(88, 57);
            NineBtn.TabIndex = 3;
            NineBtn.Text = "9";
            NineBtn.UseVisualStyleBackColor = true;
            NineBtn.Click += NineBtn_Click;
            // 
            // FourBtn
            // 
            FourBtn.Font = new Font("Segoe UI", 12F);
            FourBtn.Location = new Point(17, 142);
            FourBtn.Name = "FourBtn";
            FourBtn.Size = new Size(88, 57);
            FourBtn.TabIndex = 4;
            FourBtn.Text = "4";
            FourBtn.UseVisualStyleBackColor = true;
            FourBtn.Click += button4_Click;
            // 
            // FiveBtn
            // 
            FiveBtn.Font = new Font("Segoe UI", 12F);
            FiveBtn.Location = new Point(111, 142);
            FiveBtn.Name = "FiveBtn";
            FiveBtn.Size = new Size(88, 57);
            FiveBtn.TabIndex = 5;
            FiveBtn.Text = "5";
            FiveBtn.UseVisualStyleBackColor = true;
            FiveBtn.Click += FiveBtn_Click;
            // 
            // SixBtn
            // 
            SixBtn.Font = new Font("Segoe UI", 12F);
            SixBtn.Location = new Point(205, 142);
            SixBtn.Name = "SixBtn";
            SixBtn.Size = new Size(88, 57);
            SixBtn.TabIndex = 6;
            SixBtn.Text = "6";
            SixBtn.UseVisualStyleBackColor = true;
            SixBtn.Click += SixBtn_Click;
            // 
            // ThreeBtn
            // 
            ThreeBtn.Font = new Font("Segoe UI", 12F);
            ThreeBtn.Location = new Point(205, 207);
            ThreeBtn.Name = "ThreeBtn";
            ThreeBtn.Size = new Size(88, 57);
            ThreeBtn.TabIndex = 9;
            ThreeBtn.Text = "3";
            ThreeBtn.UseVisualStyleBackColor = true;
            ThreeBtn.Click += ThreeBtn_Click;
            // 
            // TwoBtn
            // 
            TwoBtn.Font = new Font("Segoe UI", 12F);
            TwoBtn.Location = new Point(111, 207);
            TwoBtn.Name = "TwoBtn";
            TwoBtn.Size = new Size(88, 57);
            TwoBtn.TabIndex = 8;
            TwoBtn.Text = "2";
            TwoBtn.UseVisualStyleBackColor = true;
            TwoBtn.Click += TwoBtn_Click;
            // 
            // OneBtn
            // 
            OneBtn.Font = new Font("Segoe UI", 12F);
            OneBtn.Location = new Point(17, 207);
            OneBtn.Name = "OneBtn";
            OneBtn.Size = new Size(88, 57);
            OneBtn.TabIndex = 7;
            OneBtn.Text = "1";
            OneBtn.UseVisualStyleBackColor = true;
            OneBtn.Click += OneBtn_Click;
            // 
            // EqualsBtn
            // 
            EqualsBtn.Font = new Font("Segoe UI", 12F);
            EqualsBtn.Location = new Point(205, 272);
            EqualsBtn.Name = "EqualsBtn";
            EqualsBtn.Size = new Size(88, 57);
            EqualsBtn.TabIndex = 12;
            EqualsBtn.Text = "=";
            EqualsBtn.UseVisualStyleBackColor = true;
            EqualsBtn.Click += EqualsBtn_Click;
            // 
            // DotBtn
            // 
            DotBtn.Font = new Font("Segoe UI", 12F);
            DotBtn.Location = new Point(111, 272);
            DotBtn.Name = "DotBtn";
            DotBtn.Size = new Size(88, 57);
            DotBtn.TabIndex = 11;
            DotBtn.Text = ".";
            DotBtn.UseVisualStyleBackColor = true;
            DotBtn.Click += DotBtn_Click;
            // 
            // ZeroBtn
            // 
            ZeroBtn.Font = new Font("Segoe UI", 12F);
            ZeroBtn.Location = new Point(17, 272);
            ZeroBtn.Name = "ZeroBtn";
            ZeroBtn.Size = new Size(88, 57);
            ZeroBtn.TabIndex = 10;
            ZeroBtn.Text = "0";
            ZeroBtn.UseVisualStyleBackColor = true;
            ZeroBtn.Click += ZeroBtn_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.Font = new Font("Segoe UI", 12F);
            ClearBtn.Location = new Point(347, 79);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(144, 57);
            ClearBtn.TabIndex = 14;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // DivBtn
            // 
            DivBtn.Font = new Font("Segoe UI", 12F);
            DivBtn.Location = new Point(347, 207);
            DivBtn.Name = "DivBtn";
            DivBtn.Size = new Size(67, 57);
            DivBtn.TabIndex = 15;
            DivBtn.Text = "/";
            DivBtn.UseVisualStyleBackColor = true;
            DivBtn.Click += DivBtn_Click;
            // 
            // PlusBtn
            // 
            PlusBtn.Font = new Font("Segoe UI", 12F);
            PlusBtn.Location = new Point(424, 142);
            PlusBtn.Name = "PlusBtn";
            PlusBtn.Size = new Size(67, 57);
            PlusBtn.TabIndex = 16;
            PlusBtn.Text = "+";
            PlusBtn.UseVisualStyleBackColor = true;
            PlusBtn.Click += PlusBtn_Click;
            // 
            // MinusBtn
            // 
            MinusBtn.Font = new Font("Segoe UI", 12F);
            MinusBtn.Location = new Point(347, 142);
            MinusBtn.Name = "MinusBtn";
            MinusBtn.Size = new Size(67, 57);
            MinusBtn.TabIndex = 17;
            MinusBtn.Text = "-";
            MinusBtn.UseVisualStyleBackColor = true;
            MinusBtn.Click += MinusBtn_Click;
            // 
            // MulBtn
            // 
            MulBtn.Font = new Font("Segoe UI", 12F);
            MulBtn.Location = new Point(424, 207);
            MulBtn.Name = "MulBtn";
            MulBtn.Size = new Size(67, 57);
            MulBtn.TabIndex = 18;
            MulBtn.Text = "*";
            MulBtn.UseVisualStyleBackColor = true;
            MulBtn.Click += MulBtn_Click;
            // 
            // MinPlusBtn
            // 
            MinPlusBtn.Font = new Font("Segoe UI", 12F);
            MinPlusBtn.Location = new Point(347, 272);
            MinPlusBtn.Name = "MinPlusBtn";
            MinPlusBtn.Size = new Size(67, 57);
            MinPlusBtn.TabIndex = 19;
            MinPlusBtn.Text = "-/+";
            MinPlusBtn.UseVisualStyleBackColor = true;
            MinPlusBtn.Click += MinPlusBtn_Click;
            // 
            // ModBtn
            // 
            ModBtn.Font = new Font("Segoe UI", 12F);
            ModBtn.Location = new Point(424, 272);
            ModBtn.Name = "ModBtn";
            ModBtn.Size = new Size(67, 57);
            ModBtn.TabIndex = 20;
            ModBtn.Text = "%";
            ModBtn.UseVisualStyleBackColor = true;
            ModBtn.Click += ModBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 363);
            Controls.Add(ModBtn);
            Controls.Add(MinPlusBtn);
            Controls.Add(MulBtn);
            Controls.Add(MinusBtn);
            Controls.Add(PlusBtn);
            Controls.Add(DivBtn);
            Controls.Add(ClearBtn);
            Controls.Add(EqualsBtn);
            Controls.Add(DotBtn);
            Controls.Add(ZeroBtn);
            Controls.Add(ThreeBtn);
            Controls.Add(TwoBtn);
            Controls.Add(OneBtn);
            Controls.Add(SixBtn);
            Controls.Add(FiveBtn);
            Controls.Add(FourBtn);
            Controls.Add(NineBtn);
            Controls.Add(EightBtn);
            Controls.Add(SevenBtn);
            Controls.Add(textBox);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            Text = "Calculator App";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox;
        private Button SevenBtn;
        private Button EightBtn;
        private Button NineBtn;
        private Button FourBtn;
        private Button FiveBtn;
        private Button SixBtn;
        private Button ThreeBtn;
        private Button TwoBtn;
        private Button OneBtn;
        private Button EqualsBtn;
        private Button DotBtn;
        private Button ZeroBtn;
        private Button ClearBtn;
        private Button DivBtn;
        private Button PlusBtn;
        private Button MinusBtn;
        private Button MulBtn;
        private Button MinPlusBtn;
        private Button ModBtn;
    }
}
