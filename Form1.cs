namespace Umnik2
{
    public partial class Form1 : Form
    {
        public int x, y, sum, t2iter;
        
        public int nPosLog;

        public bool answer = false;

        //Function to get random number
        private static readonly Random getrandom = new Random();

        public static int GetRandomNumber(int min, int max)
        {
            lock (getrandom) // synchronize
            {
                return getrandom.Next(min, max);
            }
        }

        private void LabelsSetRandomValue()
        {
            x = GetRandomNumber(10, 99);
            y = GetRandomNumber(10, 99);
            sum = x + y;
            label1.Text = x.ToString();
            label2.Text = y.ToString();
            t2iter = 10; // decrement
        }

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 10000; // �������� �������� ����� ������
            timer2.Interval = 1000; // �������� �����������
            timer1.Enabled = false; // ���������
            timer2.Enabled = false;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer2.Tick += new EventHandler(timer2_Tick);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            label4.Text = "";
            nPosLog = 1;
        }

        private void timer1_Tick(object sender, EventArgs e) // ����� �����
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false; // ������������� ������ 1
                timer2.Enabled = false; // ������������� ������ 2

                answer = false;

                Logging();
                GenData();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                label10.Text = t2iter.ToString(); // ����������
                t2iter--;
            }
        }

        private void GenData()
        {
            timer1.Enabled = false;
            timer2.Enabled = false;

            LabelsSetRandomValue();

            timer1.Enabled = true; // ������ �������� ����� ������ ����� 10 sec
            timer2.Enabled = true; // every second
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            textBox1.Enabled = true;
            GenData();
            textBox1.Select();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;  // ����� �� ������������ ���� �������������� � �����
                e.SuppressKeyPress = true;
            }
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e) // �������� ������������
        {
            if (e.KeyCode == Keys.Enter)
            {
                timer1.Enabled = false; // ������������� ��
                timer2.Enabled = false;

                answer = textBox1.Text.Equals(sum.ToString());

                Logging();
                GenData();
                textBox1.Text = string.Empty; // ������� ������� ��������
            }
        }

        private void Logging()
        {
            if (answer)
            {
                label4.Text += "1"; // valid answer
            }
            else
            {
                label4.Text += "0"; // invalid answer
            }
            String str = $"{nPosLog} : {x} + {y} = {sum} �����: " + textBox1.Text + $"; ���������: {answer}";
            listBox1.Items.Insert(0, str);
            nPosLog++;
        }
    }
}
