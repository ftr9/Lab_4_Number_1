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