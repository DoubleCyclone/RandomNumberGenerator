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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            label1 = new Label();
            amountMaskedTextBox = new MaskedTextBox();
            panel2 = new Panel();
            upperLimitMaskedTextBox = new MaskedTextBox();
            label3 = new Label();
            label2 = new Label();
            lowerLimitMaskedTextBox = new MaskedTextBox();
            panel3 = new Panel();
            hotkey2Label = new Label();
            hotkey1Label = new Label();
            button2 = new Button();
            button1 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(amountMaskedTextBox);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 54);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(3, 22);
            label1.Name = "label1";
            label1.Size = new Size(183, 15);
            label1.TabIndex = 5;
            label1.Text = "How many numbers to generate?";
            // 
            // amountMaskedTextBox
            // 
            amountMaskedTextBox.Anchor = AnchorStyles.Right;
            amountMaskedTextBox.BackColor = SystemColors.ActiveCaptionText;
            amountMaskedTextBox.ForeColor = SystemColors.Control;
            amountMaskedTextBox.HidePromptOnLeave = true;
            amountMaskedTextBox.Location = new Point(274, 19);
            amountMaskedTextBox.Mask = "00000";
            amountMaskedTextBox.Name = "amountMaskedTextBox";
            amountMaskedTextBox.PromptChar = ' ';
            amountMaskedTextBox.Size = new Size(33, 23);
            amountMaskedTextBox.TabIndex = 4;
            amountMaskedTextBox.Text = "2";
            amountMaskedTextBox.ValidatingType = typeof(int);
            amountMaskedTextBox.TextChanged += amountMaskedTextBox_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(upperLimitMaskedTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(lowerLimitMaskedTextBox);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(314, 54);
            panel2.TabIndex = 6;
            // 
            // upperLimitMaskedTextBox
            // 
            upperLimitMaskedTextBox.Anchor = AnchorStyles.Right;
            upperLimitMaskedTextBox.BackColor = SystemColors.ActiveCaptionText;
            upperLimitMaskedTextBox.ForeColor = SystemColors.Control;
            upperLimitMaskedTextBox.HidePromptOnLeave = true;
            upperLimitMaskedTextBox.Location = new Point(254, 12);
            upperLimitMaskedTextBox.Mask = "000000000";
            upperLimitMaskedTextBox.Name = "upperLimitMaskedTextBox";
            upperLimitMaskedTextBox.PromptChar = ' ';
            upperLimitMaskedTextBox.Size = new Size(53, 23);
            upperLimitMaskedTextBox.TabIndex = 12;
            upperLimitMaskedTextBox.Text = "100";
            upperLimitMaskedTextBox.ValidatingType = typeof(int);
            upperLimitMaskedTextBox.TextChanged += upperLimitMaskedTextBox_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(204, 15);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 11;
            label3.Text = "and";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left;
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(7, 15);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 10;
            label2.Text = "Between";
            // 
            // lowerLimitMaskedTextBox
            // 
            lowerLimitMaskedTextBox.Anchor = AnchorStyles.Right;
            lowerLimitMaskedTextBox.BackColor = SystemColors.ActiveCaptionText;
            lowerLimitMaskedTextBox.ForeColor = SystemColors.Control;
            lowerLimitMaskedTextBox.HidePromptOnLeave = true;
            lowerLimitMaskedTextBox.Location = new Point(134, 12);
            lowerLimitMaskedTextBox.Mask = "000000000";
            lowerLimitMaskedTextBox.Name = "lowerLimitMaskedTextBox";
            lowerLimitMaskedTextBox.PromptChar = ' ';
            lowerLimitMaskedTextBox.Size = new Size(53, 23);
            lowerLimitMaskedTextBox.TabIndex = 9;
            lowerLimitMaskedTextBox.Text = "1";
            lowerLimitMaskedTextBox.ValidatingType = typeof(int);
            lowerLimitMaskedTextBox.TextChanged += lowerLimitMaskedTextBox_TextChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(hotkey2Label);
            panel3.Controls.Add(hotkey1Label);
            panel3.Controls.Add(button2);
            panel3.Controls.Add(button1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 108);
            panel3.Name = "panel3";
            panel3.Size = new Size(314, 91);
            panel3.TabIndex = 13;
            // 
            // hotkey2Label
            // 
            hotkey2Label.Anchor = AnchorStyles.Right;
            hotkey2Label.AutoSize = true;
            hotkey2Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            hotkey2Label.ForeColor = SystemColors.Control;
            hotkey2Label.Location = new Point(251, 24);
            hotkey2Label.Name = "hotkey2Label";
            hotkey2Label.Size = new Size(56, 15);
            hotkey2Label.TabIndex = 15;
            hotkey2Label.Text = "CTRL + 2";
            // 
            // hotkey1Label
            // 
            hotkey1Label.Anchor = AnchorStyles.Left;
            hotkey1Label.AutoSize = true;
            hotkey1Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            hotkey1Label.ForeColor = SystemColors.Control;
            hotkey1Label.Location = new Point(7, 24);
            hotkey1Label.Name = "hotkey1Label";
            hotkey1Label.Size = new Size(56, 15);
            hotkey1Label.TabIndex = 14;
            hotkey1Label.Text = "CTRL + 1";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.FlatAppearance.BorderColor = SystemColors.Control;
            button2.FlatAppearance.MouseDownBackColor = Color.Gray;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.Control;
            button2.Image = RandomNumberGeneratorResources.Dice;
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(200, 42);
            button2.Name = "button2";
            button2.Size = new Size(107, 35);
            button2.TabIndex = 13;
            button2.Text = "Roll Many";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.FlatAppearance.BorderColor = SystemColors.Control;
            button1.FlatAppearance.MouseDownBackColor = Color.Gray;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 64, 64);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.Control;
            button1.Image = RandomNumberGeneratorResources.Dice;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(7, 42);
            button1.Name = "button1";
            button1.Size = new Size(107, 35);
            button1.TabIndex = 12;
            button1.Text = "Roll One";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(314, 201);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RandomNumberGenerator by 8BitHero";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private MaskedTextBox amountMaskedTextBox;
        private Panel panel2;
        private MaskedTextBox upperLimitMaskedTextBox;
        private Label label3;
        private Label label2;
        private MaskedTextBox lowerLimitMaskedTextBox;
        private Panel panel3;
        private Label hotkey2Label;
        private Label hotkey1Label;
        private Button button2;
        private Button button1;
    }
}