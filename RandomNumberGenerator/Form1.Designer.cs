namespace RandomNumberGenerator
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
            button1 = new Button();
            amountMaskedTextBox = new MaskedTextBox();
            label1 = new Label();
            label2 = new Label();
            lowerLimitMaskedTextBox = new MaskedTextBox();
            label3 = new Label();
            upperLimitMaskedTextBox = new MaskedTextBox();
            button2 = new Button();
            hotkey1Label = new Label();
            hotkey2Label = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatAppearance.BorderColor = SystemColors.Control;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = RandomNumberGeneratorResources.Dice;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(12, 95);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 0;
            button1.Text = "Roll One";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // amountMaskedTextBox
            // 
            amountMaskedTextBox.BackColor = SystemColors.ActiveCaptionText;
            amountMaskedTextBox.ForeColor = SystemColors.Control;
            amountMaskedTextBox.Location = new Point(201, 12);
            amountMaskedTextBox.Mask = "00000";
            amountMaskedTextBox.Name = "amountMaskedTextBox";
            amountMaskedTextBox.Size = new Size(33, 23);
            amountMaskedTextBox.TabIndex = 2;
            amountMaskedTextBox.Text = "2";
            amountMaskedTextBox.ValidatingType = typeof(int);
            amountMaskedTextBox.TextChanged += amountMaskedTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 3;
            label1.Text = "How many numbers to generate?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Between";
            // 
            // lowerLimitMaskedTextBox
            // 
            lowerLimitMaskedTextBox.BackColor = SystemColors.ActiveCaptionText;
            lowerLimitMaskedTextBox.ForeColor = SystemColors.Control;
            lowerLimitMaskedTextBox.Location = new Point(79, 47);
            lowerLimitMaskedTextBox.Mask = "000000000";
            lowerLimitMaskedTextBox.Name = "lowerLimitMaskedTextBox";
            lowerLimitMaskedTextBox.Size = new Size(53, 23);
            lowerLimitMaskedTextBox.TabIndex = 4;
            lowerLimitMaskedTextBox.Text = "1";
            lowerLimitMaskedTextBox.ValidatingType = typeof(int);
            lowerLimitMaskedTextBox.TextChanged += lowerLimitMaskedTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(143, 50);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 7;
            label3.Text = "and";
            // 
            // upperLimitMaskedTextBox
            // 
            upperLimitMaskedTextBox.BackColor = SystemColors.ActiveCaptionText;
            upperLimitMaskedTextBox.ForeColor = SystemColors.Control;
            upperLimitMaskedTextBox.Location = new Point(181, 47);
            upperLimitMaskedTextBox.Mask = "000000000";
            upperLimitMaskedTextBox.Name = "upperLimitMaskedTextBox";
            upperLimitMaskedTextBox.Size = new Size(53, 23);
            upperLimitMaskedTextBox.TabIndex = 8;
            upperLimitMaskedTextBox.Text = "100";
            upperLimitMaskedTextBox.ValidatingType = typeof(int);
            upperLimitMaskedTextBox.TextChanged += upperLimitMaskedTextBox_TextChanged;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderColor = SystemColors.Control;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Image = RandomNumberGeneratorResources.Dice;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(127, 95);
            button2.Name = "button2";
            button2.Size = new Size(107, 35);
            button2.TabIndex = 9;
            button2.Text = "Roll Many";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // hotkey1Label
            // 
            hotkey1Label.AutoSize = true;
            hotkey1Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            hotkey1Label.ForeColor = SystemColors.Control;
            hotkey1Label.Location = new Point(12, 77);
            hotkey1Label.Name = "hotkey1Label";
            hotkey1Label.Size = new Size(56, 15);
            hotkey1Label.TabIndex = 10;
            hotkey1Label.Text = "CTRL + 1";
            // 
            // hotkey2Label
            // 
            hotkey2Label.AutoSize = true;
            hotkey2Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            hotkey2Label.ForeColor = SystemColors.Control;
            hotkey2Label.Location = new Point(178, 77);
            hotkey2Label.Name = "hotkey2Label";
            hotkey2Label.Size = new Size(56, 15);
            hotkey2Label.TabIndex = 11;
            hotkey2Label.Text = "CTRL + 2";
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(244, 137);
            Controls.Add(hotkey2Label);
            Controls.Add(hotkey1Label);
            Controls.Add(button2);
            Controls.Add(upperLimitMaskedTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lowerLimitMaskedTextBox);
            Controls.Add(label1);
            Controls.Add(amountMaskedTextBox);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private MaskedTextBox amountMaskedTextBox;
        private Label label1;
        private Label label2;
        private MaskedTextBox lowerLimitMaskedTextBox;
        private Label label3;
        private MaskedTextBox upperLimitMaskedTextBox;
        private Button button2;
        private Label hotkey1Label;
        private Label hotkey2Label;
    }
}