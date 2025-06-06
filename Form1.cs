namespace DotNetCore
{
    public partial class Form1_Main : Form
    {
        public Form1_Main()
        {
            InitializeComponent();

            this.FormBorderStyle = FormBorderStyle.Sizable;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.ControlBox = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

     

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            //check if inputs are empty
            if (string.IsNullOrWhiteSpace(textBox1_Num1.Text) ||
                string.IsNullOrWhiteSpace(textBox2.Text))
            { 
                MessageBox.Show("please enter both numbers.", "Input Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            //check if operation is selected
            if (comboBox1_Operations.SelectedIndex == null)
            {
                MessageBox.Show("Please select an operation.", "Operation missing");
            }

            double num1 = double.Parse(textBox1_Num1.Text);
            double num2 = double.Parse((textBox2.Text).Trim());
            string operation = comboBox1_Operations.SelectedItem.ToString();
            double result = 0;


            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        MessageBox.Show("Cannot divide by zero.", "Math Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    result = num1 / num2;
                    break;
            }

            label_Result.Text = $"Result: {result}";
        }

        private void label_Result_Click(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            textBox1_Num1.Clear();
            textBox2.Clear();

            label_Result.Text = "Result:";


        }
    }
}
