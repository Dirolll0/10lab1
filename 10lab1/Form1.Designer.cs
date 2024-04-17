namespace _10lab1
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
            baseATextBox = new TextBox();
            baseBTextBox = new TextBox();
            angleTextBox = new TextBox();
            button1 = new Button();
            resultLabel = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // baseATextBox
            // 
            baseATextBox.Location = new Point(168, 104);
            baseATextBox.Name = "baseATextBox";
            baseATextBox.Size = new Size(100, 23);
            baseATextBox.TabIndex = 0;
            baseATextBox.TextChanged += textBox1_TextChanged;
            // 
            // baseBTextBox
            // 
            baseBTextBox.Location = new Point(305, 104);
            baseBTextBox.Name = "baseBTextBox";
            baseBTextBox.Size = new Size(100, 23);
            baseBTextBox.TabIndex = 1;
            baseBTextBox.TextChanged += textBox2_TextChanged;
            // 
            // angleTextBox
            // 
            angleTextBox.Location = new Point(480, 104);
            angleTextBox.Name = "angleTextBox";
            angleTextBox.Size = new Size(100, 23);
            angleTextBox.TabIndex = 2;
            angleTextBox.TextChanged += textBox3_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(317, 154);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Решить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.Location = new Point(267, 183);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(176, 45);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "";
            resultLabel.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 86);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 5;
            label1.Text = "Большее основание A";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 86);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 6;
            label2.Text = "Меньшее основание B";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(443, 86);
            label3.Name = "label3";
            label3.Size = new Size(185, 15);
            label3.TabIndex = 7;
            label3.Text = "угол X при большем основании";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultLabel);
            Controls.Add(button1);
            Controls.Add(angleTextBox);
            Controls.Add(baseBTextBox);
            Controls.Add(baseATextBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox baseATextBox;
        private TextBox baseBTextBox;
        private TextBox angleTextBox;
        private Button button1;
        private RichTextBox resultLabel;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
