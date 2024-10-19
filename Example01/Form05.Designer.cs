namespace Example01
{
    partial class Form05
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDisplay = new TextBox();
            btMC = new Button();
            btMR = new Button();
            btMS = new Button();
            btMemoryPlus = new Button();
            btMemorySub = new Button();
            btSquareRoot = new Button();
            btPlusMinus = new Button();
            btC = new Button();
            btCE = new Button();
            btBackspace = new Button();
            btPer = new Button();
            btDivide = new Button();
            bt9 = new Button();
            bt8 = new Button();
            bt7 = new Button();
            btReci = new Button();
            btMul = new Button();
            bt6 = new Button();
            bt5 = new Button();
            bt4 = new Button();
            btEquals = new Button();
            btSub = new Button();
            bt3 = new Button();
            bt2 = new Button();
            bt1 = new Button();
            btPlus = new Button();
            btDecimal = new Button();
            bt0 = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.BorderStyle = BorderStyle.FixedSingle;
            txtDisplay.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDisplay.Location = new Point(14, 12);
            txtDisplay.Multiline = true;
            txtDisplay.Name = "txtDisplay";
            txtDisplay.Size = new Size(432, 80);
            txtDisplay.TabIndex = 0;
            // 
            // btMC
            // 
            btMC.FlatStyle = FlatStyle.Flat;
            btMC.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btMC.Location = new Point(14, 107);
            btMC.Name = "btMC";
            btMC.Size = new Size(80, 52);
            btMC.TabIndex = 1;
            btMC.Text = "MC";
            btMC.UseVisualStyleBackColor = true;
            btMC.Click += Button_Click;
            // 
            // btMR
            // 
            btMR.FlatStyle = FlatStyle.Flat;
            btMR.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btMR.Location = new Point(100, 107);
            btMR.Name = "btMR";
            btMR.Size = new Size(82, 52);
            btMR.TabIndex = 2;
            btMR.Text = "MR";
            btMR.UseVisualStyleBackColor = true;
            btMR.Click += Button_Click;
            // 
            // btMS
            // 
            btMS.FlatStyle = FlatStyle.Flat;
            btMS.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btMS.Location = new Point(188, 107);
            btMS.Name = "btMS";
            btMS.Size = new Size(82, 52);
            btMS.TabIndex = 3;
            btMS.Text = "MS";
            btMS.UseVisualStyleBackColor = true;
            btMS.Click += Button_Click;
            // 
            // btMemoryPlus
            // 
            btMemoryPlus.FlatStyle = FlatStyle.Flat;
            btMemoryPlus.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btMemoryPlus.Location = new Point(276, 107);
            btMemoryPlus.Name = "btMemoryPlus";
            btMemoryPlus.Size = new Size(82, 52);
            btMemoryPlus.TabIndex = 4;
            btMemoryPlus.Text = "M+";
            btMemoryPlus.UseVisualStyleBackColor = true;
            btMemoryPlus.Click += Button_Click;
            // 
            // btMemorySub
            // 
            btMemorySub.FlatStyle = FlatStyle.Flat;
            btMemorySub.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btMemorySub.Location = new Point(364, 107);
            btMemorySub.Name = "btMemorySub";
            btMemorySub.Size = new Size(82, 52);
            btMemorySub.TabIndex = 5;
            btMemorySub.Text = "M-";
            btMemorySub.UseVisualStyleBackColor = true;
            btMemorySub.Click += Button_Click;
            // 
            // btSquareRoot
            // 
            btSquareRoot.FlatStyle = FlatStyle.Flat;
            btSquareRoot.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btSquareRoot.Location = new Point(364, 165);
            btSquareRoot.Name = "btSquareRoot";
            btSquareRoot.Size = new Size(82, 52);
            btSquareRoot.TabIndex = 10;
            btSquareRoot.Text = "√";
            btSquareRoot.UseVisualStyleBackColor = true;
            btSquareRoot.Click += Button_Click;
            // 
            // btPlusMinus
            // 
            btPlusMinus.FlatStyle = FlatStyle.Flat;
            btPlusMinus.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btPlusMinus.Location = new Point(276, 165);
            btPlusMinus.Name = "btPlusMinus";
            btPlusMinus.Size = new Size(82, 52);
            btPlusMinus.TabIndex = 9;
            btPlusMinus.Text = "±";
            btPlusMinus.UseVisualStyleBackColor = true;
            btPlusMinus.Click += Button_Click;
            // 
            // btC
            // 
            btC.FlatStyle = FlatStyle.Flat;
            btC.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btC.Location = new Point(188, 165);
            btC.Name = "btC";
            btC.Size = new Size(82, 52);
            btC.TabIndex = 8;
            btC.Text = "C";
            btC.UseVisualStyleBackColor = true;
            btC.Click += Button_Click;
            // 
            // btCE
            // 
            btCE.FlatStyle = FlatStyle.Flat;
            btCE.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btCE.Location = new Point(100, 165);
            btCE.Name = "btCE";
            btCE.Size = new Size(82, 52);
            btCE.TabIndex = 7;
            btCE.Text = "CE";
            btCE.UseVisualStyleBackColor = true;
            btCE.Click += Button_Click;
            // 
            // btBackspace
            // 
            btBackspace.FlatStyle = FlatStyle.Flat;
            btBackspace.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btBackspace.Location = new Point(14, 165);
            btBackspace.Name = "btBackspace";
            btBackspace.Size = new Size(80, 52);
            btBackspace.TabIndex = 6;
            btBackspace.Text = "<-";
            btBackspace.UseVisualStyleBackColor = true;
            btBackspace.Click += Button_Click;
            // 
            // btPer
            // 
            btPer.FlatStyle = FlatStyle.Flat;
            btPer.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btPer.Location = new Point(364, 223);
            btPer.Name = "btPer";
            btPer.Size = new Size(82, 52);
            btPer.TabIndex = 15;
            btPer.Text = "%";
            btPer.UseVisualStyleBackColor = true;
            btPer.Click += Button_Click;
            // 
            // btDivide
            // 
            btDivide.FlatStyle = FlatStyle.Flat;
            btDivide.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btDivide.Location = new Point(276, 223);
            btDivide.Name = "btDivide";
            btDivide.Size = new Size(82, 52);
            btDivide.TabIndex = 14;
            btDivide.Text = "/";
            btDivide.UseVisualStyleBackColor = true;
            btDivide.Click += Button_Click;
            // 
            // bt9
            // 
            bt9.FlatStyle = FlatStyle.Flat;
            bt9.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt9.Location = new Point(188, 223);
            bt9.Name = "bt9";
            bt9.Size = new Size(82, 52);
            bt9.TabIndex = 13;
            bt9.Text = "9";
            bt9.UseVisualStyleBackColor = true;
            bt9.Click += Button_Click;
            // 
            // bt8
            // 
            bt8.FlatStyle = FlatStyle.Flat;
            bt8.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt8.Location = new Point(100, 223);
            bt8.Name = "bt8";
            bt8.Size = new Size(82, 52);
            bt8.TabIndex = 12;
            bt8.Text = "8";
            bt8.UseVisualStyleBackColor = true;
            bt8.Click += Button_Click;
            // 
            // bt7
            // 
            bt7.FlatStyle = FlatStyle.Flat;
            bt7.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt7.Location = new Point(14, 223);
            bt7.Name = "bt7";
            bt7.Size = new Size(80, 52);
            bt7.TabIndex = 11;
            bt7.Text = "7";
            bt7.UseVisualStyleBackColor = true;
            bt7.Click += Button_Click;
            // 
            // btReci
            // 
            btReci.FlatStyle = FlatStyle.Flat;
            btReci.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btReci.Location = new Point(364, 281);
            btReci.Name = "btReci";
            btReci.Size = new Size(82, 52);
            btReci.TabIndex = 20;
            btReci.Text = "1/x";
            btReci.UseVisualStyleBackColor = true;
            btReci.Click += Button_Click;
            // 
            // btMul
            // 
            btMul.FlatStyle = FlatStyle.Flat;
            btMul.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btMul.Location = new Point(276, 281);
            btMul.Name = "btMul";
            btMul.Size = new Size(82, 52);
            btMul.TabIndex = 19;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = true;
            btMul.Click += Button_Click;
            // 
            // bt6
            // 
            bt6.FlatStyle = FlatStyle.Flat;
            bt6.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt6.Location = new Point(188, 281);
            bt6.Name = "bt6";
            bt6.Size = new Size(82, 52);
            bt6.TabIndex = 18;
            bt6.Text = "6";
            bt6.UseVisualStyleBackColor = true;
            bt6.Click += Button_Click;
            // 
            // bt5
            // 
            bt5.FlatStyle = FlatStyle.Flat;
            bt5.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt5.Location = new Point(100, 281);
            bt5.Name = "bt5";
            bt5.Size = new Size(82, 52);
            bt5.TabIndex = 17;
            bt5.Text = "5";
            bt5.UseVisualStyleBackColor = true;
            bt5.Click += Button_Click;
            // 
            // bt4
            // 
            bt4.FlatStyle = FlatStyle.Flat;
            bt4.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt4.Location = new Point(14, 281);
            bt4.Name = "bt4";
            bt4.Size = new Size(80, 52);
            bt4.TabIndex = 16;
            bt4.Text = "4";
            bt4.UseVisualStyleBackColor = true;
            bt4.Click += Button_Click;
            // 
            // btEquals
            // 
            btEquals.FlatStyle = FlatStyle.Flat;
            btEquals.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btEquals.Location = new Point(364, 339);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(82, 110);
            btEquals.TabIndex = 25;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += Button_Click;
            // 
            // btSub
            // 
            btSub.FlatStyle = FlatStyle.Flat;
            btSub.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btSub.Location = new Point(276, 339);
            btSub.Name = "btSub";
            btSub.Size = new Size(82, 52);
            btSub.TabIndex = 24;
            btSub.Text = "-";
            btSub.UseVisualStyleBackColor = true;
            btSub.Click += Button_Click;
            // 
            // bt3
            // 
            bt3.FlatStyle = FlatStyle.Flat;
            bt3.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt3.Location = new Point(188, 339);
            bt3.Name = "bt3";
            bt3.Size = new Size(82, 52);
            bt3.TabIndex = 23;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += Button_Click;
            // 
            // bt2
            // 
            bt2.FlatStyle = FlatStyle.Flat;
            bt2.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt2.Location = new Point(100, 339);
            bt2.Name = "bt2";
            bt2.Size = new Size(82, 52);
            bt2.TabIndex = 22;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += Button_Click;
            // 
            // bt1
            // 
            bt1.FlatStyle = FlatStyle.Flat;
            bt1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt1.Location = new Point(14, 339);
            bt1.Name = "bt1";
            bt1.Size = new Size(80, 52);
            bt1.TabIndex = 21;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += Button_Click;
            // 
            // btPlus
            // 
            btPlus.FlatStyle = FlatStyle.Flat;
            btPlus.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btPlus.Location = new Point(276, 397);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(82, 52);
            btPlus.TabIndex = 29;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += Button_Click;
            // 
            // btDecimal
            // 
            btDecimal.FlatStyle = FlatStyle.Flat;
            btDecimal.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            btDecimal.Location = new Point(188, 397);
            btDecimal.Name = "btDecimal";
            btDecimal.Size = new Size(82, 52);
            btDecimal.TabIndex = 28;
            btDecimal.Text = ".";
            btDecimal.UseVisualStyleBackColor = true;
            btDecimal.Click += Button_Click;
            // 
            // bt0
            // 
            bt0.FlatStyle = FlatStyle.Flat;
            bt0.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold);
            bt0.Location = new Point(14, 397);
            bt0.Name = "bt0";
            bt0.Size = new Size(168, 52);
            bt0.TabIndex = 27;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += Button_Click;
            // 
            // Form05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 481);
            Controls.Add(btPlus);
            Controls.Add(btDecimal);
            Controls.Add(bt0);
            Controls.Add(btEquals);
            Controls.Add(btSub);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(btReci);
            Controls.Add(btMul);
            Controls.Add(bt6);
            Controls.Add(bt5);
            Controls.Add(bt4);
            Controls.Add(btPer);
            Controls.Add(btDivide);
            Controls.Add(bt9);
            Controls.Add(bt8);
            Controls.Add(bt7);
            Controls.Add(btSquareRoot);
            Controls.Add(btPlusMinus);
            Controls.Add(btC);
            Controls.Add(btCE);
            Controls.Add(btBackspace);
            Controls.Add(btMemorySub);
            Controls.Add(btMemoryPlus);
            Controls.Add(btMS);
            Controls.Add(btMR);
            Controls.Add(btMC);
            Controls.Add(txtDisplay);
            Name = "Form05";
            Text = "Form05";
            Load += Form05_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btMC;
        private Button btMR;
        private Button btMS;
        private Button btMemoryPlus;
        private Button btMemorySub;
        private Button btSquareRoot;
        private Button btPlusMinus;
        private Button btC;
        private Button btCE;
        private Button btBackspace;
        private Button btPer;
        private Button btDivide;
        private Button bt9;
        private Button bt8;
        private Button bt7;
        private Button btReci;
        private Button btMul;
        private Button bt6;
        private Button bt5;
        private Button bt4;
        private Button btEquals;
        private Button btSub;
        private Button bt3;
        private Button bt2;
        private Button bt1;
        private Button btPlus;
        private Button btDecimal;
        private Button bt0;
    }
}