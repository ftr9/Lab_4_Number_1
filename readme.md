## Write a Program to compare two numbers and display the largest number using form application

# Step - 1 - in Program.cs file

```
namespace Lab_4_Number_1
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

```

# Step -2 in Form1.Designer.cs file

```
namespace Lab_4_Number_1
{
    partial class Form1
    {

        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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

```

# Step - 3 - Draw the UI

![image](https://github.com/ftr9/Lab_4_Number_1/assets/60734475/2ba74ce5-62be-4c05-9431-24f636485855)

# Step - 4 - in Form1.cs file

```
namespace Lab_4_Number_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void _CompareAndDisplayResult(int num1,int num2)
        {
            if (num1 > num2)
            {
                MessageBox.Show($"num1 - {num1} is greater than num2 - {num2}");
            }
            else if (num1 < num2)
            {
                MessageBox.Show($"num2 - {num2} is greater than num1 - {num1}");
            }
            else
            {
                MessageBox.Show($"num1 - {num1} and num2 - {num2} are equal");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(Input1.Text);
                int num2 = int.Parse(Input2.Text);
                this._CompareAndDisplayResult(num1, num2);

            //Raised if input value fails to convert into Number
            }catch(FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
    }
}

```

# Step - 5 - Draw the result

![image](https://github.com/ftr9/Lab_4_Number_1/assets/60734475/14126bba-25d0-4164-9664-cde4a8a5944d)
