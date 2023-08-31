namespace Lab_4_Number_1
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
            Input1 = new TextBox();
            Input2 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // Input1
            // 
            Input1.Location = new Point(165, 125);
            Input1.Name = "Input1";
            Input1.PlaceholderText = "Enter Number 1";
            Input1.Size = new Size(162, 27);
            Input1.TabIndex = 0;
            // 
            // Input2
            // 
            Input2.Location = new Point(471, 125);
            Input2.Name = "Input2";
            Input2.PlaceholderText = "Enter Number 2";
            Input2.Size = new Size(157, 27);
            Input2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(329, 32);
            label1.Name = "label1";
            label1.Size = new Size(144, 28);
            label1.TabIndex = 2;
            label1.Text = "Display Largest";
            // 
            // button1
            // 
            button1.Location = new Point(286, 229);
            button1.Name = "button1";
            button1.Size = new Size(181, 50);
            button1.TabIndex = 3;
            button1.Text = "Compare";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Input2);
            Controls.Add(Input1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input1;
        private TextBox Input2;
        private Label label1;
        private Button button1;
    }
}