namespace _9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string relPath = textBox1.Text;

            StreamWriter streamWriter = new StreamWriter(relPath, true);

            streamWriter.WriteLine(textBox2.Text);

            streamWriter.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string absPath = textBox3.Text;

            StreamReader streamReader = new StreamReader(absPath);

            string line = "";

            textBox4.Clear();

            while ((line = streamReader.ReadLine()) != null)
            {
                textBox4.Text += line + " ";
            }
            streamReader.Close();
        }


    }
}