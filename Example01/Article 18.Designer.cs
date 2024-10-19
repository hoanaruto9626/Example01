namespace Example01
{
    partial class Article_18
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
            lbFavorite = new ListBox();
            lbSong = new ListBox();
            btDeselect = new Button();
            btSelect = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lbFavorite
            // 
            lbFavorite.FormattingEnabled = true;
            lbFavorite.Location = new Point(345, 39);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(250, 384);
            lbFavorite.TabIndex = 17;
            // 
            // lbSong
            // 
            lbSong.FormattingEnabled = true;
            lbSong.Location = new Point(21, 39);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(251, 384);
            lbSong.TabIndex = 16;
            // 
            // btDeselect
            // 
            btDeselect.FlatStyle = FlatStyle.Flat;
            btDeselect.Location = new Point(278, 215);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(61, 56);
            btDeselect.TabIndex = 13;
            btDeselect.Text = "<";
            btDeselect.UseVisualStyleBackColor = true;
            btDeselect.Click += btDeselect_Click;
            // 
            // btSelect
            // 
            btSelect.FlatStyle = FlatStyle.Flat;
            btSelect.Location = new Point(278, 160);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(61, 49);
            btSelect.TabIndex = 12;
            btSelect.Text = ">";
            btSelect.UseVisualStyleBackColor = true;
            btSelect.Click += btSelect_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 16);
            label2.Name = "label2";
            label2.Size = new Size(184, 20);
            label2.TabIndex = 11;
            label2.Text = "Danh sách bài hát ưa thích";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 16);
            label1.Name = "label1";
            label1.Size = new Size(127, 20);
            label1.TabIndex = 10;
            label1.Text = "Danh sách bài hát";
            // 
            // Article_18
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 450);
            Controls.Add(lbFavorite);
            Controls.Add(lbSong);
            Controls.Add(btDeselect);
            Controls.Add(btSelect);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Article_18";
            Text = "Article_18";
            Load += Article_18_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbFavorite;
        private ListBox lbSong;
        private Button btDeselect;
        private Button btSelect;
        private Label label2;
        private Label label1;
    }
}