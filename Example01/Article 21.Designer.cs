namespace Example01
{
    partial class Article_21
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
            btnAddNew = new Button();
            btDelete = new Button();
            button1 = new Button();
            txtAge = new TextBox();
            txtName = new TextBox();
            txtId = new TextBox();
            ckGender = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvEmployee = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            old = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // btnAddNew
            // 
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Location = new Point(378, 461);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 23;
            btnAddNew.Text = "Thêm";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // btDelete
            // 
            btDelete.FlatStyle = FlatStyle.Flat;
            btDelete.Location = new Point(478, 461);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 22;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(578, 461);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 21;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(102, 367);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(239, 27);
            txtAge.TabIndex = 20;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(102, 323);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 27);
            txtName.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(102, 275);
            txtId.Name = "txtId";
            txtId.Size = new Size(239, 27);
            txtId.TabIndex = 18;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.FlatStyle = FlatStyle.Popup;
            ckGender.Location = new Point(102, 414);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(60, 24);
            ckGender.TabIndex = 17;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 370);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 16;
            label3.Text = "Tuổi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 326);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 15;
            label2.Text = "Tên";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 278);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 14;
            label1.Text = "Mã";
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { ID, TenNV, old, GioiTinh });
            dgvEmployee.Location = new Point(12, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(660, 231);
            dgvEmployee.TabIndex = 13;
            dgvEmployee.CellContentClick += dgvEmployee_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "Mã nhân viên";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 150;
            // 
            // TenNV
            // 
            TenNV.HeaderText = "Tên nhân viên";
            TenNV.MinimumWidth = 6;
            TenNV.Name = "TenNV";
            TenNV.Width = 150;
            // 
            // old
            // 
            old.HeaderText = "Tuổi";
            old.MinimumWidth = 6;
            old.Name = "old";
            old.Width = 150;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới Tính(Nam)";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 150;
            // 
            // Article_21
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(691, 563);
            Controls.Add(btnAddNew);
            Controls.Add(btDelete);
            Controls.Add(button1);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(ckGender);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Name = "Article_21";
            Text = "Article_21";
            Load += Article_21_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNew;
        private Button btDelete;
        private Button button1;
        private TextBox txtAge;
        private TextBox txtName;
        private TextBox txtId;
        private CheckBox ckGender;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvEmployee;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn old;
        private DataGridViewTextBoxColumn GioiTinh;
    }
}