using System.Globalization;

namespace calc
{
    public partial class Form1 : Form
    {
        Decimal result;
        String operationPerformed = "";
        Boolean operationPressed = false;
        string memory = "0";
        
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ( textBox_Result.TextLength > 13)
            {
                if (textBox_Result.Text.Contains('.')) {
                    textBox_Result.Text = textBox_Result.Text.Remove(13);
                } else               
                textBox_Result.Text = "Error";
            }
        }

        private void numclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (textBox_Result.Text.Equals("0") || operationPressed  || textBox_Result.Text.Equals("Error"))
            {
                textBox_Result.Text = "";

                operationPressed = false;
            }
            textBox_Result.Text = textBox_Result.Text + button.Text;
            label1.Focus();

        }

        private void dotclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!textBox_Result.Text.Contains(button.Text))
            {
                textBox_Result.Text = textBox_Result.Text + button.Text;
            }
            if (operationPressed)
            {
                textBox_Result.Text = "0.";
                operationPressed = false;
            }
            label1.Focus();
        }

        private void cclick(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            result = 0;
            label1.Focus();
        }

        private void operatorclick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                button_Equals.PerformClick();
                operationPressed = true;
                operationPerformed = button.Text;
            }
            else
            {
                operationPerformed = button.Text;

                result = Decimal.Parse(textBox_Result.Text, CultureInfo.InvariantCulture);


                operationPressed = true;
                label1.Focus();
            }
        }

        private void ceclick(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            label1.Focus();
        }

        private void equalsclick(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    result = result + Decimal.Parse(textBox_Result.Text, CultureInfo.InvariantCulture);
                    break;
                case "-":
                    result = result -  Decimal.Parse(textBox_Result.Text, CultureInfo.InvariantCulture);
                    break;
                case "*":
                    result = result * Decimal.Parse(textBox_Result.Text, CultureInfo.InvariantCulture);
                    break;
                case "/":
                    try { result = result / Decimal.Parse(textBox_Result.Text, CultureInfo.InvariantCulture); } 
                    catch { textBox_Result.Text = "Error";
                    }
                    break;
            }
            if (textBox_Result.Text != "Error")
            {
                textBox_Result.Text = result.ToString(CultureInfo.InvariantCulture);
                if (textBox_Result.Text.Contains('.'))               
                    textBox_Result.Text = textBox_Result.Text.TrimEnd('0');
                operationPressed = true;//???
            }

            operationPerformed = "";
            label1.Focus();
        }

        private void previewkeydown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Down:
                case Keys.Up:
                    e.IsInputKey = true;
                    break;
            }
        }
        private void keydown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("hi");
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    button_1.PerformClick();
                    break;
                case Keys.NumPad2:
                    button_2.PerformClick();
                    break;
                case Keys.NumPad3:
                    button_3.PerformClick();
                    break;
                case Keys.NumPad4:
                    button_4.PerformClick();
                    break;
                case Keys.NumPad5:
                    button_5.PerformClick();
                    break;
                case Keys.NumPad6:
                    button_6.PerformClick();
                    break;
                case Keys.NumPad7:
                    button_7.PerformClick();
                    break;
                case Keys.NumPad8:
                    button_8.PerformClick();
                    break;
                case Keys.NumPad9:
                    button_9.PerformClick();
                    break;
                case Keys.NumPad0:
                    button_0.PerformClick();
                    break;
                case Keys.Decimal:
                    button11.PerformClick();
                    break;
                case Keys.Add:
                    button_Add.PerformClick();
                    break;
                case Keys.Subtract:
                    button_Sub.PerformClick();
                    break;
                case Keys.Multiply:
                    button_Mul.PerformClick();
                    break;
                case Keys.Divide:
                    button_Div.PerformClick();
                    break;
                case Keys.Enter:
                    button_Equals.PerformClick();
                    break;
                case Keys.F9:
                    button_plusminus.PerformClick();
                    break;
                case Keys.Delete:
                    button_CE.PerformClick();
                    break;
                case Keys.Escape:
                    button_C.PerformClick();
                    break;

            }
        }

        private void button_plusminus_Click(object sender, EventArgs e)
        {
            if (textBox_Result.Text[0] == '-')
            {
                textBox_Result.Text = textBox_Result.Text.Substring(1);
            }
            else
            {
                textBox_Result.Text = "-" + textBox_Result.Text;
            }

            operationPressed = false; //???
            label1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)  //MR
        {
            if (memory != ""){
                textBox_Result.Text = memory;
                label1.Focus();
            }
        }

        private void button_MC_Click(object sender, EventArgs e)
        {
            memory = "0";
            label2.Visible = false;
            label1.Focus();
        }

        private void button_MS_Click(object sender, EventArgs e)
        {
            memory = textBox_Result.Text;
            label2.Visible = true;
            label1.Focus();
        }

        private void button_MMinus_Click(object sender, EventArgs e)
        {
            if(memory != "")
                memory = (decimal.Parse(memory) - decimal.Parse(textBox_Result.Text)).ToString();
            label1.Focus();
        }

        private void button_MPlus_Click(object sender, EventArgs e)
        {
            if (memory != "")
                memory = (decimal.Parse(memory) + decimal.Parse(textBox_Result.Text)).ToString();
            label1.Focus();
        }
    }
}