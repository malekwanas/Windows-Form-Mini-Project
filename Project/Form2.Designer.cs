namespace Lab_8
{
    partial class Form2
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
            Font = new TabControl();
            tabPage1 = new TabPage();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tabPage2 = new TabPage();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            tabPage3 = new TabPage();
            button4 = new Button();
            tabPage4 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            NewText = new TextBox();
            OldText = new TextBox();
            button1 = new Button();
            button2 = new Button();
            Font.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // Font
            // 
            Font.Controls.Add(tabPage1);
            Font.Controls.Add(tabPage2);
            Font.Controls.Add(tabPage3);
            Font.Controls.Add(tabPage4);
            Font.Location = new Point(98, 12);
            Font.Name = "Font";
            Font.SelectedIndex = 0;
            Font.Size = new Size(649, 266);
            Font.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(radioButton3);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(641, 238);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Font";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Courier New", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            radioButton3.Location = new Point(17, 151);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(112, 26);
            radioButton3.TabIndex = 2;
            radioButton3.Text = "Courier";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Arial", 15F);
            radioButton2.Location = new Point(17, 88);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 27);
            radioButton2.TabIndex = 1;
            radioButton2.Text = "Arial";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Times New Roman", 15F);
            radioButton1.Location = new Point(17, 27);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(179, 26);
            radioButton1.TabIndex = 0;
            radioButton1.Text = "Times New Roman";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(radioButton6);
            tabPage2.Controls.Add(radioButton5);
            tabPage2.Controls.Add(radioButton4);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(641, 238);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Size";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Segoe UI", 24F);
            radioButton6.Location = new Point(36, 189);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(72, 49);
            radioButton6.TabIndex = 2;
            radioButton6.Text = "24";
            radioButton6.UseVisualStyleBackColor = true;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Segoe UI", 20F);
            radioButton5.Location = new Point(36, 102);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(65, 41);
            radioButton5.TabIndex = 1;
            radioButton5.Text = "20";
            radioButton5.UseVisualStyleBackColor = true;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Segoe UI", 16F);
            radioButton4.Location = new Point(36, 29);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(55, 34);
            radioButton4.TabIndex = 0;
            radioButton4.Text = "16";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(641, 238);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Color";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(248, 81);
            button4.Name = "button4";
            button4.Size = new Size(155, 83);
            button4.TabIndex = 0;
            button4.Text = "Open Color Dialog Box";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(label1);
            tabPage4.Controls.Add(NewText);
            tabPage4.Controls.Add(OldText);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(641, 238);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Text";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(134, 117);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 3;
            label2.Text = "New Value";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(134, 28);
            label1.Name = "label1";
            label1.Size = new Size(96, 28);
            label1.TabIndex = 2;
            label1.Text = "Old Value";
            // 
            // NewText
            // 
            NewText.Location = new Point(257, 122);
            NewText.Name = "NewText";
            NewText.Size = new Size(204, 23);
            NewText.TabIndex = 1;
            // 
            // OldText
            // 
            OldText.Location = new Point(257, 33);
            OldText.Name = "OldText";
            OldText.ReadOnly = true;
            OldText.Size = new Size(204, 23);
            OldText.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(102, 298);
            button1.Name = "button1";
            button1.Size = new Size(130, 64);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(613, 298);
            button2.Name = "button2";
            button2.Size = new Size(130, 64);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 374);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(Font);
            Name = "Form2";
            Text = "Form2";
            Font.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl Font;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Button button1;
        private Button button2;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private Button button4;
        private Label label2;
        private Label label1;
        private TextBox NewText;
        private TextBox OldText;
    }
}