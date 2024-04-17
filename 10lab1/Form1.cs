namespace _10lab1
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(baseATextBox.Text);
                double b = double.Parse(baseBTextBox.Text);
                double angle = double.Parse(angleTextBox.Text);

                if (angle < 0 || angle > 180)
                {
                    MessageBox.Show("Угол должен быть в пределах от 0 до 180 градусов.");
                    return;
                }
                if (b > a)
                {
                    MessageBox.Show("Значени a должно быть больше b");
                    return;
                }

                double angleInRadians = angle * Math.PI / 180.0;

                double area = ((a + b) / 2) * ((a - b) / 2) * Math.Tan(angleInRadians);

                resultLabel.Text = $"Площадь трапеции: {area:F2}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
