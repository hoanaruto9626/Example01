namespace Example01
{
    partial class Form04
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
            tbDisplay = new TextBox();
            bt0 = new Button();
            bt1 = new Button();
            bt2 = new Button();
            bt3 = new Button();
            btEquals = new Button();
            button6 = new Button();
            btMul = new Button();
            btPlus = new Button();
            SuspendLayout();
            // 
            // tbDisplay
            // 
            tbDisplay.BorderStyle = BorderStyle.None;
            tbDisplay.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbDisplay.Location = new Point(12, 27);
            tbDisplay.Multiline = true;
            tbDisplay.Name = "tbDisplay";
            tbDisplay.Size = new Size(290, 43);
            tbDisplay.TabIndex = 0;
            // 
            // bt0
            // 
            bt0.FlatStyle = FlatStyle.Popup;
            bt0.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt0.Location = new Point(12, 86);
            bt0.Name = "bt0";
            bt0.Size = new Size(68, 54);
            bt0.TabIndex = 1;
            bt0.Text = "0";
            bt0.UseVisualStyleBackColor = true;
            bt0.Click += bt0_Click;
            // 
            // bt1
            // 
            bt1.FlatStyle = FlatStyle.Popup;
            bt1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt1.Location = new Point(86, 86);
            bt1.Name = "bt1";
            bt1.Size = new Size(68, 54);
            bt1.TabIndex = 2;
            bt1.Text = "1";
            bt1.UseVisualStyleBackColor = true;
            bt1.Click += bt1_Click;
            // 
            // bt2
            // 
            bt2.FlatStyle = FlatStyle.Popup;
            bt2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            bt2.Location = new Point(160, 86);
            bt2.Name = "bt2";
            bt2.Size = new Size(68, 54);
            bt2.TabIndex = 3;
            bt2.Text = "2";
            bt2.UseVisualStyleBackColor = true;
            bt2.Click += bt2_Click;
            // 
            // bt3
            // 
            bt3.FlatStyle = FlatStyle.Popup;
            bt3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            bt3.Location = new Point(234, 86);
            bt3.Name = "bt3";
            bt3.Size = new Size(68, 54);
            bt3.TabIndex = 4;
            bt3.Text = "3";
            bt3.UseVisualStyleBackColor = true;
            bt3.Click += bt3_Click;
            // 
            // btEquals
            // 
            btEquals.FlatStyle = FlatStyle.Popup;
            btEquals.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btEquals.Location = new Point(234, 146);
            btEquals.Name = "btEquals";
            btEquals.Size = new Size(68, 54);
            btEquals.TabIndex = 8;
            btEquals.Text = "=";
            btEquals.UseVisualStyleBackColor = true;
            btEquals.Click += btEquals_Click;
            // 
            // button6
            // 
            button6.FlatStyle = FlatStyle.Popup;
            button6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            button6.Location = new Point(160, 146);
            button6.Name = "button6";
            button6.Size = new Size(68, 54);
            button6.TabIndex = 7;
            button6.Text = ".";
            button6.UseVisualStyleBackColor = true;
            // 
            // btMul
            // 
            btMul.FlatStyle = FlatStyle.Popup;
            btMul.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btMul.Location = new Point(86, 146);
            btMul.Name = "btMul";
            btMul.Size = new Size(68, 54);
            btMul.TabIndex = 6;
            btMul.Text = "*";
            btMul.UseVisualStyleBackColor = true;
            btMul.Click += btMul_Click;
            // 
            // btPlus
            // 
            btPlus.FlatStyle = FlatStyle.Popup;
            btPlus.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold);
            btPlus.Location = new Point(12, 146);
            btPlus.Name = "btPlus";
            btPlus.Size = new Size(68, 54);
            btPlus.TabIndex = 5;
            btPlus.Text = "+";
            btPlus.UseVisualStyleBackColor = true;
            btPlus.Click += btPlus_Click;
            // 
            // Form04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 214);
            Controls.Add(btEquals);
            Controls.Add(button6);
            Controls.Add(btMul);
            Controls.Add(btPlus);
            Controls.Add(bt3);
            Controls.Add(bt2);
            Controls.Add(bt1);
            Controls.Add(bt0);
            Controls.Add(tbDisplay);
            Name = "Form04";
            Text = "Form04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDisplay;
        private Button bt0;
        private Button bt1;
        private Button bt2;
        private Button bt3;
        private Button btEquals;
        private Button button6;
        private Button btMul;
        private Button btPlus;
    }
}