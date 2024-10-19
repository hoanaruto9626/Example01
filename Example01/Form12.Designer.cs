namespace Example01
{
    partial class Form112
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
            dgvEmployee = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenNV = new DataGridViewTextBoxColumn();
            old = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ckGender = new CheckBox();
            txtId = new TextBox();
            txtName = new TextBox();
            txtAge = new TextBox();
            button1 = new Button();
            btDelete = new Button();
            btnAddNew = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Columns.AddRange(new DataGridViewColumn[] { ID, TenNV, old, GioiTinh });
            dgvEmployee.Location = new Point(12, 12);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(660, 231);
            dgvEmployee.TabIndex = 0;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 278);
            label1.Name = "label1";
            label1.Size = new Size(30, 20);
            label1.TabIndex = 1;
            label1.Text = "Mã";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 326);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 2;
            label2.Text = "Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 370);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 3;
            label3.Text = "Tuổi";
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.FlatStyle = FlatStyle.Popup;
            ckGender.Location = new Point(102, 414);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(60, 24);
            ckGender.TabIndex = 5;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(102, 275);
            txtId.Name = "txtId";
            txtId.Size = new Size(239, 27);
            txtId.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Location = new Point(102, 323);
            txtName.Name = "txtName";
            txtName.Size = new Size(239, 27);
            txtName.TabIndex = 7;
            // 
            // txtAge
            // 
            txtAge.BorderStyle = BorderStyle.FixedSingle;
            txtAge.Location = new Point(102, 367);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(239, 27);
            txtAge.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(578, 461);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // btDelete
            // 
            btDelete.FlatStyle = FlatStyle.Flat;
            btDelete.Location = new Point(478, 461);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(94, 29);
            btDelete.TabIndex = 11;
            btDelete.Text = "Xóa";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btnAddNew
            // 
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Location = new Point(378, 461);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(94, 29);
            btnAddNew.TabIndex = 12;
            btnAddNew.Text = "Thêm";
            btnAddNew.UseVisualStyleBackColor = true;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // Form112
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 517);
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
            Name = "Form112";
            Text = "Form12";
            Load += Form112_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private CheckBox ckGender;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtAge;
        private Button button1;
        private Button btDelete;
        private Button btnAddNew;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenNV;
        private DataGridViewTextBoxColumn old;
        private DataGridViewTextBoxColumn GioiTinh;
    }
}