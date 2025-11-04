using System.Collections;
using System.Text;

namespace Caculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int parentheses1 = 0;
        int parentheses2 = 0;
       

        StringBuilder input = new StringBuilder();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            parentheses1++;
            input.Append("(");
          
            textBox1.Text = input.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            parentheses2++;
            input.Append(")");
            
            textBox1.Text = input.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            input.Append("0");
            textBox1.Text = input.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            input.Append("1");
            textBox1.Text = input.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            input.Append("2");
            textBox1.Text = input.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            input.Append("3");
            textBox1.Text = input.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            input.Append("4");
            textBox1.Text = input.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            input.Append("5");
            textBox1.Text = input.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            input.Append("6");
            textBox1.Text = input.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            input.Append("7");
            textBox1.Text = input.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            input.Append("8");
            textBox1.Text = input.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            input.Append("9");
            textBox1.Text = input.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {// =
            if (parentheses1 != parentheses2) { 
                MessageBox.Show("Error: Unmatched parentheses");
                return;
            }
            textBox1.Text = Calculate(input.ToString()).ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {//ac
            input.Clear();
            textBox1.Clear();
        }

        private void button19_Click(object sender, EventArgs e)
        {// del
            if (input.Length > 0)
            {
                input.Remove(input.Length - 1, 1);
                textBox1.Text = input.ToString();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            input.Append("+");
            textBox1.Text = input.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            input.Append("-");
            textBox1.Text = input.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            input.Append("*");
            textBox1.Text = input.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            input.Append("/");
            textBox1.Text = input.ToString();
        }

        public int Calculate(string s)
        {
            s = s.Trim();
            s = s.Replace(" ", "");

            string[] numa = Tonumarr(s);
            if (numa[0] == "-")
            {
                s = "0" + s;
                numa = Tonumarr(s);
            } // add 0 before - , or add 0 after (  before - to prevent operation = number of nums  like -2-1 (unary minus)
            string[] rpn = ToRPN(numa);

            int ans = CaculateRPN(rpn);
            return ans;
        }

        public  string[] Tonumarr(string input)
        {
            List<string> res = new List<string>();
            string currentnum = "";
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i])) { currentnum += input[i]; }
                else
                {
                    if (currentnum != "")
                    {
                        res.Add(currentnum);
                        currentnum = "";
                    }
                    res.Add(input[i].ToString());
                }
            }
            if (currentnum != "") { res.Add(currentnum); }


            string[] output = res.ToArray();
            return output;
        }


        public string[] ToRPN(string[] arr)
        {
            List<string> res = new List<string>();
            Stack operations = new Stack();
            Hashtable precedence = new Hashtable();
            precedence.Add("(", 0);
            precedence.Add("+", 1);
            precedence.Add("-", 1);
            precedence.Add("*", 2);
            precedence.Add("/", 2);
            //precedence.Add(")", 3); // don't need , bcs never reach ;)


            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] != "+" && arr[i] != "-" && arr[i] != "*" && arr[i] != "/" && arr[i] != "(" && arr[i] != ")")
                {
                    res.Add(arr[i]);
                }


                else if (operations.Count == 0)
                {
                    operations.Push(arr[i]);
                }

                else if (arr[i] == "(")
                {
                    operations.Push(arr[i]);
                    if (arr[i + 1] == "-") { res.Add("0"); }
                }

                else if (arr[i] == ")")
                {
                    while (operations.Peek().ToString() != "(")
                    {
                        res.Add(operations.Pop().ToString());
                    }
                    operations.Pop();
                }
                // when meet ) , pop all until met ( 

                else if (int.Parse(precedence[operations.Peek()].ToString()) > int.Parse(precedence[arr[i]].ToString())) // added precedence of "(" , to compare
                {

                    int temp = operations.Count;
                    for (global::System.Int32 j = 0; j < temp; j++)
                    {
                        res.Add(operations.Pop().ToString());
                    }
                    operations.Push(arr[i]);
                }
                else if (int.Parse(precedence[operations.Peek()].ToString()) == int.Parse(precedence[arr[i]].ToString()))
                {

                    res.Add(operations.Pop().ToString());
                    operations.Push(arr[i]);
                }

                else
                {
                    operations.Push(arr[i]);
                }

            }

            while (operations.Count != 0)
            {
                res.Add(operations.Pop().ToString());
            }


            string[] output = res.ToArray();
            textBox1.Text = string.Join(" ", output);
            return output;
        }


        public int CaculateRPN(string[] arr)
        {

            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != "+" && arr[i] != "-" && arr[i] != "*" && arr[i] != "/")
                {
                    nums.Push(int.Parse(arr[i]));
                }
                else if (arr[i] == "+")
                {
                    int out1 = nums.Pop();
                    int out2 = nums.Pop();
                    nums.Push(out2 + out1);
                }
                else if (arr[i] == "-")
                {
                    int out1 = nums.Pop();
                    int out2 = nums.Pop();
                    nums.Push(out2 - out1);
                }
                else if (arr[i] == "*")
                {
                    int out1 = nums.Pop();
                    int out2 = nums.Pop();
                    nums.Push(out2 * out1);
                }
                else if (arr[i] == "/")
                {
                    int out1 = nums.Pop();
                    int out2 = nums.Pop();
                    nums.Push(out2 / out1);
                }
            }

            int output = nums.Pop();
            return output;
        }

    }
}
