namespace gpaxxxxxfinal
{
    public partial class Form1 : Form
    {
        gpacalcass gpacalculater = new gpacalcass();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //��ҹ�硺�͡
            string input = this.textBox1.Text;
            string inputname = this.textBox4.Text;

            //�ŧʵ�ԧ����Թ�ص�� ��ŧ�ҡ ʵ�ԧ �繴Ѻ����
            double dInput = Convert.ToDouble(input);
            string dinputname = inputname ;
            //����͵ �ͺਡ
            gpacalculater.setGPA(dInput);
            gpacalculater.setminmax(dInput);
            
            //�� gpx �ҡ�ͺਤ
            double gpax = gpacalculater.getGPAx();
            double maxx = gpacalculater.getmax();
            double minx = gpacalculater.getmin();
            //�Ӣ����Ũҡ෡��͡����� str mtr �����������
            string str = textBox1.Text;
            string mtr = textBox4.Text;


            listBox1.Items.Add(str + "\t" + mtr);
            //listBox1.Items.Add(str + mtr)();


            //string str = textBox1.Text;
            //��ŧ �Ѻ��������ԧ
            this.textBox2.Text = gpax.ToString();
            this.textBox3.Text = maxx.ToString();
            this.textBox5.Text = minx.ToString();
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("tasttsst");

        }

        

            

        }
    }
