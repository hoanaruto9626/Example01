namespace Example01
{
    partial class Form13
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
            pbImage = new PictureBox();
            btLeft = new Button();
            btRight = new Button();
            btFile = new Button();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // pbImage
            // 
            pbImage.Location = new Point(37, 26);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(124, 145);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // btLeft
            // 
            btLeft.FlatStyle = FlatStyle.Flat;
            btLeft.Location = new Point(127, 236);
            btLeft.Name = "btLeft";
            btLeft.Size = new Size(65, 57);
            btLeft.TabIndex = 1;
            btLeft.Text = "<-";
            btLeft.UseVisualStyleBackColor = true;
            btLeft.Click += btLeft_Click;
            // 
            // btRight
            // 
            btRight.FlatStyle = FlatStyle.Flat;
            btRight.Location = new Point(211, 236);
            btRight.Name = "btRight";
            btRight.Size = new Size(65, 57);
            btRight.TabIndex = 2;
            btRight.Text = "->";
            btRight.UseVisualStyleBackColor = true;
            btRight.Click += btRight_Click;
            // 
            // btFile
            // 
            btFile.FlatStyle = FlatStyle.Flat;
            btFile.Location = new Point(345, 259);
            btFile.Name = "btFile";
            btFile.Size = new Size(116, 34);
            btFile.TabIndex = 3;
            btFile.Text = "File ...";
            btFile.UseVisualStyleBackColor = true;
            btFile.Click += btFile_Click;
            // 
            // Form13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btFile);
            Controls.Add(btRight);
            Controls.Add(btLeft);
            Controls.Add(pbImage);
            Name = "Form13";
            Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbImage;
        private Button btLeft;
        private Button btRight;
        private Button btFile;
    }
}