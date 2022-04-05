namespace test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();       //name the textbox to get focus on it 
        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            listBox1.Sorted=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}