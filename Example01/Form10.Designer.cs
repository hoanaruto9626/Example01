namespace Example01
{
    partial class Form10
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
            btSelect = new Button();
            btDeselect = new Button();
            btDeselectAll = new Button();
            btSelectAll = new Button();
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 0;
            label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(336, 20);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 1;
            label2.Text = "Danh sách bài hát ưa thích";
            // 
            // btSelect
            // 
            btSelect.FlatStyle = FlatStyle.Flat;
            btSelect.Location = new Point(269, 120);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(61, 49);
            btSelect.TabIndex = 4;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // btDeselect
            // 
            btDeselect.FlatStyle = FlatStyle.Flat;
            btDeselect.Location = new Point(269, 175);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(61, 56);
            btDeselect.TabIndex = 5;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            btDeselect.Click += btDeselect_Click;
            // 
            // btDeselectAll
            // 
            btDeselectAll.FlatStyle = FlatStyle.Flat;
            btDeselectAll.Location = new Point(269, 295);
            btDeselectAll.Name = "btDeselectAll";
            btDeselectAll.Size = new Size(61, 56);
            btDeselectAll.TabIndex = 7;
            btDeselectAll.Text = "<<";
            btDeselectAll.UseVisualStyleBackColor = true;
            btDeselectAll.Click += btDeselectAll_Click;
            // 
            // btSelectAll
            // 
            btSelectAll.FlatStyle = FlatStyle.Flat;
            btSelectAll.Location = new Point(269, 240);
            btSelectAll.Name = "btSelectAll";
            btSelectAll.Size = new Size(61, 49);
            btSelectAll.TabIndex = 6;
            btSelectAll.Text = ">>";
            btSelectAll.UseVisualStyleBackColor = true;
            btSelectAll.Click += btSelectAll_Click;
            // 
            // lbSong
            // 
            lbSong.FormattingEnabled = true;
            lbSong.Items.AddRange(new object[] { "Giấc mơ Chapi", "Đôi Mắt Pleiku", "Em Muốn Sống Bên Anh Trọn Đời", "H'Zen Lên Rẫy", "Ly Cà Phê Ban Mê", "Đi tìm lời ru mặt trời" });
            lbSong.Location = new Point(12, 43);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(251, 384);
            lbSong.TabIndex = 8;
            lbSong.MouseDoubleClick += lbSong_MouseDoubleClick;
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.Items.AddRange(new object[] { "Còn thương nhau thì về Buôn Mê Thuộc" });
            lbFavorite.Location = new Point(336, 43);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(250, 384);
            lbFavorite.TabIndex = 9;
            lbFavorite.MouseDoubleClick += lbFavorite_MouseDoubleClick;
            // 
            // Form10
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(598, 450);
            Controls.Add(lbFavorite);
            Controls.Add(lbSong);
            Controls.Add(btDeselectAll);
            Controls.Add(btSelectAll);
            Controls.Add(btDeselect);
            Controls.Add(btSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form10";
            Text = "Form10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btSelect;
        private Button btDeselect;
        private Button btDeselectAll;
        private Button btSelectAll;
        private ListBox lbSong;
        private ListBox lbFavorite;
    }
}