namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }





        private void panel2_Resize(object sender, EventArgs e)
        {
            button1.Height = panel2.Height / 6;
            button2.Height = panel2.Height / 6;
            button3.Height = panel2.Height / 6;
            button4.Height = panel2.Height / 6;
            button5.Height = panel2.Height / 6;
            button6.Height = panel2.Height / 6;
            button7.Height = panel2.Height / 6;
            button8.Height = panel2.Height / 6;
            button9.Height = panel2.Height / 6;
            button10.Height = panel2.Height / 6;
            button11.Height = panel2.Height / 6;
            button12.Height = panel2.Height / 6;
            button13.Height = panel2.Height / 6;
            button14.Height = panel2.Height / 6;
            button15.Height = panel2.Height / 6;
            button16.Height = panel2.Height / 6;
            button17.Height = panel2.Height / 6;
            button18.Height = panel2.Height / 6;
            button19.Height = panel2.Height / 6;
            button20.Height = panel2.Height / 6;
            button21.Height = panel2.Height / 6;
            button22.Height = panel2.Height / 6;
            button23.Height = panel2.Height / 6;
            button24.Height = panel2.Height / 6;

            button1.Width = panel2.Width / 4;
            button2.Width = panel2.Width / 4;
            button3.Width = panel2.Width / 4;
            button4.Width = panel2.Width / 4;
            button5.Width = panel2.Width / 4;
            button6.Width = panel2.Width / 4;
            button7.Width = panel2.Width / 4;
            button8.Width = panel2.Width / 4;
            button9.Width = panel2.Width / 4;
            button10.Width = panel2.Width / 4;
            button11.Width = panel2.Width / 4;
            button12.Width = panel2.Width / 4;
            button13.Width = panel2.Width / 4;
            button14.Width = panel2.Width / 4;
            button15.Width = panel2.Width / 4;
            button16.Width = panel2.Width / 4;
            button17.Width = panel2.Width / 4;
            button18.Width = panel2.Width / 4;
            button19.Width = panel2.Width / 4;
            button20.Width = panel2.Width / 4;
            button21.Width = panel2.Width / 4;
            button22.Width = panel2.Width / 4;
            button23.Width = panel2.Width / 4;
            button24.Width = panel2.Width / 4;

            button1.Top = 0;
            button2.Top = 0;
            button3.Top = 0;
            button4.Top = 0;

            button5.Top = panel2.Height / 6;
            button6.Top = panel2.Height / 6;
            button7.Top = panel2.Height / 6;
            button8.Top = panel2.Height / 6;

            button9.Top = panel2.Height * 2 / 6;
            button10.Top = panel2.Height * 2 / 6;
            button11.Top = panel2.Height * 2 / 6;
            button12.Top = panel2.Height * 2 / 6;

            button13.Top = panel2.Height * 3 / 6;
            button14.Top = panel2.Height * 3 / 6;
            button15.Top = panel2.Height * 3 / 6;
            button16.Top = panel2.Height * 3 / 6;

            button17.Top = panel2.Height * 4 / 6;
            button18.Top = panel2.Height * 4 / 6;
            button19.Top = panel2.Height * 4 / 6;
            button20.Top = panel2.Height * 4 / 6;

            button21.Top = panel2.Height * 5 / 6;
            button22.Top = panel2.Height * 5 / 6;
            button23.Top = panel2.Height * 5 / 6;
            button24.Top = panel2.Height * 5 / 6;

            button1.Left = 0;
            button5.Left = 0;
            button9.Left = 0;
            button13.Left = 0;
            button17.Left = 0;
            button21.Left = 0;

            button2.Left = panel2.Width / 4;
            button6.Left = panel2.Width / 4;
            button10.Left = panel2.Width / 4;
            button14.Left = panel2.Width / 4;
            button18.Left = panel2.Width / 4;
            button22.Left = panel2.Width / 4;

            button3.Left = panel2.Width / 2;
            button7.Left = panel2.Width / 2;
            button11.Left = panel2.Width / 2;
            button15.Left = panel2.Width / 2;
            button19.Left = panel2.Width / 2;
            button23.Left = panel2.Width / 2;

            button4.Left = panel2.Width * 3 / 4;
            button8.Left = panel2.Width * 3 / 4;
            button12.Left = panel2.Width * 3 / 4;
            button16.Left = panel2.Width * 3 / 4;
            button20.Left = panel2.Width * 3 / 4;
            button24.Left = panel2.Width * 3 / 4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel2_Resize(sender, e);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            if (textBox1.Text.IndexOf(",") > 0 && b.Text == ",")
            {
                return;
            }
            textBox1.Text = textBox1.Text + b.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length - 1 == 0)
            {
                textBox1.Text = "0";
            }
            else
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        String action;
        String number1;
        private void button20_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || textBox1.Text == "")
            {
                textBox1.Text = "-";

            }
            else
            {
                Button b = (Button)sender;
                action = b.Text;
                number1 = textBox1.Text;
                textBox1.Text = "";
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (action == "+")
                textBox1.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(number1)).ToString();
            if (action == "-")
                textBox1.Text = (Convert.ToDouble(number1) - Convert.ToDouble(textBox1.Text)).ToString();
            if (action == "*")
                textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(number1)).ToString();
            if (action == "/")
                textBox1.Text = (Convert.ToDouble(number1) / Convert.ToDouble(textBox1.Text)).ToString();
            if(action=="%")
                textBox1.Text = (Convert.ToDouble(number1) / 100 * Convert.ToDouble(textBox1.Text)).ToString();
            action = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = (1 / Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = (Math.Sqrt(Convert.ToDouble(textBox1.Text))).ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = (-Convert.ToDouble(textBox1.Text)).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            action = "%";
            number1 = textBox1.Text;
            textBox1.Text = "";
        }
    }
}
