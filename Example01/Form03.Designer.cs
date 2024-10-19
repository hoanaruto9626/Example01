namespace Example01
{
    partial class Form03
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
            label1 = new Label();
            tbSoX = new TextBox();
            btCong = new Button();
            tbSoY = new TextBox();
            label2 = new Label();
            tbKetQua = new TextBox();
            label3 = new Label();
            btThoat = new Button();
            btNhan = new Button();
            btLuu = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 57);
            label1.Name = "label1";
            label1.Size = new Size(37, 20);
            label1.TabIndex = 0;
            label1.Text = "Số x";
            // 
            // tbSoX
            // 
            tbSoX.BorderStyle = BorderStyle.FixedSingle;
            tbSoX.Location = new Point(139, 54);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(437, 27);
            tbSoX.TabIndex = 1;
            // 
            // btCong
            // 
            btCong.FlatStyle = FlatStyle.Flat;
            btCong.Location = new Point(444, 508);
            btCong.Name = "btCong";
            btCong.Size = new Size(94, 29);
            btCong.TabIndex = 2;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // tbSoY
            // 
            tbSoY.BorderStyle = BorderStyle.FixedSingle;
            tbSoY.Location = new Point(139, 116);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(437, 27);
            tbSoY.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 119);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "Số y";
            // 
            // tbKetQua
            // 
            tbKetQua.BorderStyle = BorderStyle.FixedSingle;
            tbKetQua.Location = new Point(139, 187);
            tbKetQua.Multiline = true;
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(437, 278);
            tbKetQua.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 190);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 5;
            label3.Text = "Kết quả";
            // 
            // btThoat
            // 
            btThoat.FlatStyle = FlatStyle.Flat;
            btThoat.Location = new Point(644, 508);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 7;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btNhan
            // 
            btNhan.FlatStyle = FlatStyle.Flat;
            btNhan.Location = new Point(544, 508);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(94, 29);
            btNhan.TabIndex = 8;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btLuu
            // 
            btLuu.FlatStyle = FlatStyle.Flat;
            btLuu.Location = new Point(54, 508);
            btLuu.Name = "btLuu";
            btLuu.Size = new Size(94, 29);
            btLuu.TabIndex = 9;
            btLuu.Text = "Lưu";
            btLuu.UseVisualStyleBackColor = true;
            btLuu.Click += btLuu_Click;
            // 
            // Form03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 574);
            Controls.Add(btLuu);
            Controls.Add(btNhan);
            Controls.Add(btThoat);
            Controls.Add(tbKetQua);
            Controls.Add(label3);
            Controls.Add(tbSoY);
            Controls.Add(label2);
            Controls.Add(btCong);
            Controls.Add(tbSoX);
            Controls.Add(label1);
            Name = "Form03";
            Text = "Form03";
            Load += Form03_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbSoX;
        private Button btCong;
        private TextBox tbSoY;
        private Label label2;
        private TextBox tbKetQua;
        private Label label3;
        private Button btThoat;
        private Button btNhan;
        private Button btLuu;
    }
}