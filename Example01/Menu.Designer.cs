namespace Example01
{
    partial class Menu
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
            dgvSach = new DataGridView();
            btnThoat = new Button();
            btnReset = new Button();
            btXoa = new Button();
            btSua = new Button();
            btThem = new Button();
            groupBox1 = new GroupBox();
            txtSoLuong = new TextBox();
            txtTacGia = new TextBox();
            txtGia = new TextBox();
            txtTenSach = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSach).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSach
            // 
            dgvSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSach.Location = new Point(244, 320);
            dgvSach.Margin = new Padding(3, 4, 3, 4);
            dgvSach.Name = "dgvSach";
            dgvSach.RowHeadersWidth = 51;
            dgvSach.Size = new Size(504, 200);
            dgvSach.TabIndex = 15;
            // 
            // btnThoat
            // 
            btnThoat.FlatStyle = FlatStyle.Popup;
            btnThoat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(710, 268);
            btnThoat.Margin = new Padding(3, 4, 3, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(86, 31);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.FlatStyle = FlatStyle.Popup;
            btnReset.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(579, 268);
            btnReset.Margin = new Padding(3, 4, 3, 4);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(86, 31);
            btnReset.TabIndex = 13;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // btXoa
            // 
            btXoa.FlatStyle = FlatStyle.Popup;
            btXoa.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btXoa.Location = new Point(453, 268);
            btXoa.Margin = new Padding(3, 4, 3, 4);
            btXoa.Name = "btXoa";
            btXoa.Size = new Size(86, 31);
            btXoa.TabIndex = 12;
            btXoa.Text = "Xoá";
            btXoa.UseVisualStyleBackColor = true;
            btXoa.Click += btXoa_Click;
            // 
            // btSua
            // 
            btSua.FlatStyle = FlatStyle.Popup;
            btSua.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btSua.Location = new Point(328, 268);
            btSua.Margin = new Padding(3, 4, 3, 4);
            btSua.Name = "btSua";
            btSua.Size = new Size(86, 31);
            btSua.TabIndex = 11;
            btSua.Text = "Sửa";
            btSua.UseVisualStyleBackColor = true;
            btSua.Click += btSua_Click;
            // 
            // btThem
            // 
            btThem.FlatStyle = FlatStyle.Popup;
            btThem.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btThem.Location = new Point(191, 268);
            btThem.Margin = new Padding(3, 4, 3, 4);
            btThem.Name = "btThem";
            btThem.Size = new Size(86, 31);
            btThem.TabIndex = 10;
            btThem.Text = "Thêm";
            btThem.UseVisualStyleBackColor = true;
            btThem.Click += btThem_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSoLuong);
            groupBox1.Controls.Add(txtTacGia);
            groupBox1.Controls.Add(txtGia);
            groupBox1.Controls.Add(txtTenSach);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(124, 73);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(763, 172);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sách";
            // 
            // txtSoLuong
            // 
            txtSoLuong.BorderStyle = BorderStyle.FixedSingle;
            txtSoLuong.Location = new Point(478, 96);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(222, 29);
            txtSoLuong.TabIndex = 7;
            // 
            // txtTacGia
            // 
            txtTacGia.BorderStyle = BorderStyle.FixedSingle;
            txtTacGia.Location = new Point(478, 32);
            txtTacGia.Margin = new Padding(3, 4, 3, 4);
            txtTacGia.Name = "txtTacGia";
            txtTacGia.Size = new Size(222, 29);
            txtTacGia.TabIndex = 6;
            // 
            // txtGia
            // 
            txtGia.BorderStyle = BorderStyle.FixedSingle;
            txtGia.Location = new Point(131, 93);
            txtGia.Margin = new Padding(3, 4, 3, 4);
            txtGia.Name = "txtGia";
            txtGia.Size = new Size(212, 29);
            txtGia.TabIndex = 5;
            // 
            // txtTenSach
            // 
            txtTenSach.BorderStyle = BorderStyle.FixedSingle;
            txtTenSach.Location = new Point(131, 32);
            txtTenSach.Margin = new Padding(3, 4, 3, 4);
            txtTenSach.Name = "txtTenSach";
            txtTenSach.Size = new Size(212, 29);
            txtTenSach.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(402, 99);
            label5.Name = "label5";
            label5.Size = new Size(79, 23);
            label5.TabIndex = 3;
            label5.Text = "Số lượng";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(406, 38);
            label4.Name = "label4";
            label4.Size = new Size(62, 23);
            label4.TabIndex = 2;
            label4.Text = "Tác giả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 99);
            label3.Name = "label3";
            label3.Size = new Size(35, 23);
            label3.TabIndex = 1;
            label3.Text = "Giá";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 38);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 0;
            label2.Text = "Tên sách";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(397, 16);
            label1.Name = "label1";
            label1.Size = new Size(227, 37);
            label1.TabIndex = 8;
            label1.Text = "Quản lý thư viện";
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(993, 549);
            Controls.Add(dgvSach);
            Controls.Add(btnThoat);
            Controls.Add(btnReset);
            Controls.Add(btXoa);
            Controls.Add(btSua);
            Controls.Add(btThem);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)dgvSach).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSach;
        private Button btnThoat;
        private Button btnReset;
        private Button btXoa;
        private Button btSua;
        private Button btThem;
        private GroupBox groupBox1;
        private TextBox txtSoLuong;
        private TextBox txtTacGia;
        private TextBox txtGia;
        private TextBox txtTenSach;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}