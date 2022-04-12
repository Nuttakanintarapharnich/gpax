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
            //อ่านเท็กบ็อก
            string input = this.textBox1.Text;
            string inputname = this.textBox4.Text;

            //แปลงสตริงที่อินพุตมา เเปลงจาก สตริง เป็นดับเบิิล
            double dInput = Convert.ToDouble(input);
            string dinputname = inputname ;
            //ครีเอต ออบเจก
            gpacalculater.setGPA(dInput);
            gpacalculater.setminmax(dInput);
            
            //นำ gpx จากออบเจค
            double gpax = gpacalculater.getGPAx();
            double maxx = gpacalculater.getmax();
            double minx = gpacalculater.getmin();
            //นำข้อมูลจากเทกบ็อกมาไส่ str mtr เพื่อเพิ่มลิส
            string str = textBox1.Text;
            string mtr = textBox4.Text;


            listBox1.Items.Add(str + "\t" + mtr);
            //listBox1.Items.Add(str + mtr)();


            //string str = textBox1.Text;
            //เเปลง ดับเบิ้ลเป็นสริง
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
