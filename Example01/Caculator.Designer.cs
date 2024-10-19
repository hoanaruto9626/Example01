namespace Example01
{
    partial class Caculator
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
            label2 = new Label();
            label3 = new Label();
            btCong = new Button();
            btNhan = new Button();
            btThoat = new Button();
            tbSoX = new TextBox();
            tbSoY = new TextBox();
            tbKetQua = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 67);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "Số X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 120);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Số Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 173);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Kết quả";
            // 
            // btCong
            // 
            btCong.FlatStyle = FlatStyle.Popup;
            btCong.Location = new Point(65, 232);
            btCong.Name = "btCong";
            btCong.Size = new Size(94, 29);
            btCong.TabIndex = 3;
            btCong.Text = "Cộng";
            btCong.UseVisualStyleBackColor = true;
            btCong.Click += btCong_Click;
            // 
            // btNhan
            // 
            btNhan.FlatStyle = FlatStyle.Popup;
            btNhan.Location = new Point(165, 232);
            btNhan.Name = "btNhan";
            btNhan.Size = new Size(94, 29);
            btNhan.TabIndex = 4;
            btNhan.Text = "Nhân";
            btNhan.UseVisualStyleBackColor = true;
            btNhan.Click += btNhan_Click;
            // 
            // btThoat
            // 
            btThoat.FlatStyle = FlatStyle.Popup;
            btThoat.Location = new Point(343, 232);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(94, 29);
            btThoat.TabIndex = 5;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // tbSoX
            // 
            tbSoX.BorderStyle = BorderStyle.FixedSingle;
            tbSoX.Location = new Point(154, 60);
            tbSoX.Name = "tbSoX";
            tbSoX.Size = new Size(225, 27);
            tbSoX.TabIndex = 6;
            // 
            // tbSoY
            // 
            tbSoY.BorderStyle = BorderStyle.FixedSingle;
            tbSoY.Location = new Point(154, 113);
            tbSoY.Name = "tbSoY";
            tbSoY.Size = new Size(225, 27);
            tbSoY.TabIndex = 7;
            // 
            // tbKetQua
            // 
            tbKetQua.BorderStyle = BorderStyle.FixedSingle;
            tbKetQua.Location = new Point(154, 166);
            tbKetQua.Name = "tbKetQua";
            tbKetQua.ReadOnly = true;
            tbKetQua.Size = new Size(225, 27);
            tbKetQua.TabIndex = 8;
            // 
            // Caculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 350);
            Controls.Add(tbKetQua);
            Controls.Add(tbSoY);
            Controls.Add(tbSoX);
            Controls.Add(btThoat);
            Controls.Add(btNhan);
            Controls.Add(btCong);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Caculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Caculator";
            Load += Caculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btCong;
        private Button btNhan;
        private Button btThoat;
        private TextBox tbSoX;
        private TextBox tbSoY;
        private TextBox tbKetQua;
    }
}