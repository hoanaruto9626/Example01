namespace Example01
{
    partial class Form14
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
            components = new System.ComponentModel.Container();
            tmStopwatch = new System.Windows.Forms.Timer(components);
            lblDisplay = new Label();
            btStart = new Button();
            btStop = new Button();
            SuspendLayout();
            // 
            // tmStopwatch
            // 
            tmStopwatch.Tick += tmStopwatch_Tick;
            // 
            // lblDisplay
            // 
            lblDisplay.AutoSize = true;
            lblDisplay.Font = new Font("Segoe UI", 18F);
            lblDisplay.Location = new Point(204, 85);
            lblDisplay.Name = "lblDisplay";
            lblDisplay.Size = new Size(105, 41);
            lblDisplay.TabIndex = 0;
            lblDisplay.Text = "00 : 00";
            // 
            // btStart
            // 
            btStart.FlatStyle = FlatStyle.Flat;
            btStart.Location = new Point(296, 202);
            btStart.Name = "btStart";
            btStart.Size = new Size(94, 29);
            btStart.TabIndex = 3;
            btStart.Text = "Start";
            btStart.UseVisualStyleBackColor = true;
            btStart.Click += btStart_Click;
            // 
            // btStop
            // 
            btStop.FlatStyle = FlatStyle.Flat;
            btStop.Location = new Point(428, 202);
            btStop.Name = "btStop";
            btStop.Size = new Size(94, 29);
            btStop.TabIndex = 4;
            btStop.Text = "Stop";
            btStop.UseVisualStyleBackColor = true;
            btStop.Click += btStop_Click;
            // 
            // Form14
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 274);
            Controls.Add(btStop);
            Controls.Add(btStart);
            Controls.Add(lblDisplay);
            Name = "Form14";
            Text = "Form14";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmStopwatch;
        private Label lblDisplay;
        private Button btStart;
        private Button btStop;
    }
}