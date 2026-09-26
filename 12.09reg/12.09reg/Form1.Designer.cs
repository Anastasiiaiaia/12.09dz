namespace _12._09reg
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            okButton = new Button();
            settingsLabel = new Label();
            colorLabel = new Label();
            colorChoose = new ComboBox();
            sizeChoose = new ComboBox();
            sizeLabel = new Label();
            SuspendLayout();
            // 
            // okButton
            // 
            okButton.Location = new Point(210, 331);
            okButton.Name = "okButton";
            okButton.Size = new Size(194, 59);
            okButton.TabIndex = 0;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // settingsLabel
            // 
            settingsLabel.AutoSize = true;
            settingsLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            settingsLabel.Location = new Point(210, 28);
            settingsLabel.Name = "settingsLabel";
            settingsLabel.Size = new Size(195, 62);
            settingsLabel.TabIndex = 1;
            settingsLabel.Text = "Settings";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            colorLabel.Location = new Point(82, 135);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new Size(281, 38);
            colorLabel.TabIndex = 2;
            colorLabel.Text = "Choose the text color";
            // 
            // colorChoose
            // 
            colorChoose.FormattingEnabled = true;
            colorChoose.Items.AddRange(new object[] { "Black", "Grey", "Red", "Blue", "Green" });
            colorChoose.Location = new Point(369, 146);
            colorChoose.Name = "colorChoose";
            colorChoose.Size = new Size(151, 28);
            colorChoose.TabIndex = 3;
            // 
            // sizeChoose
            // 
            sizeChoose.FormattingEnabled = true;
            sizeChoose.Items.AddRange(new object[] { "10", "12", "14", "16", "18", "20", "24" });
            sizeChoose.Location = new Point(354, 244);
            sizeChoose.Name = "sizeChoose";
            sizeChoose.Size = new Size(151, 28);
            sizeChoose.TabIndex = 5;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            sizeLabel.Location = new Point(82, 234);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(266, 38);
            sizeLabel.TabIndex = 4;
            sizeLabel.Text = "Choose the text size";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 453);
            Controls.Add(sizeChoose);
            Controls.Add(sizeLabel);
            Controls.Add(colorChoose);
            Controls.Add(colorLabel);
            Controls.Add(settingsLabel);
            Controls.Add(okButton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button okButton;
        private Label settingsLabel;
        private Label colorLabel;
        private ComboBox colorChoose;
        private ComboBox sizeChoose;
        private Label sizeLabel;
    }
}
