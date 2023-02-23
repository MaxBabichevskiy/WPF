using System.Windows.Forms;

namespace AirTickets
{
    public partial class Form1 : Form
    {
        int PassengerClass = 0;
        public Form1()
        {
            InitializeComponent();

            NameField.Text = "Введите Имя";
            NameField.ForeColor = Color.Gray;
            LstNameField.Text = "Введите Фамилию";
            LstNameField.ForeColor = Color.Gray;

            dateTime1.MinDate = DateTime.Today;
            label2.Text = String.Format("Дата вылета:");

            comboBox1.Items.AddRange(new string[] { "Киев - Варшава",
            "Киев - Стамбул","Киев - Прага","Киев - Будапешт","Киев - Нью-Йорк"});
            comboBox1.Text = "Выберите рейс";
            comboBox1.ForeColor = Color.Gray;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void purchaseButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseTab_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseTab_MouseEnter(object sender, EventArgs e)
        {
            CloseTab.ForeColor = Color.Red;
        }

        private void CloseTab_MouseLeave(object sender, EventArgs e)
        {
            CloseTab.ForeColor = Color.White;
        }

        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        Point lastPoint;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;

            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            String Name = NameField.Text;
            String LastName = LstNameField.Text;

            if (NameField.Text == "Введите Имя")
            {
                MessageBox.Show("Вы не ввели Имя!");
                return;
            }

            if (LstNameField.Text == "Введите Фамилию")
            {
                MessageBox.Show("Вы не ввели Фамилию!");
                return;
            }

            if (comboBox1.Text == "Выберите рейс")
            {
                MessageBox.Show("Вы не выбрали рейс!");
                return;
            }

            MessageBox.Show("Успешно!\nВаш билет: #12503278\n");
           

        }

        private void NameField_Enter(object sender, EventArgs e)
        {
            if (NameField.Text == "Введите Имя")
            {
                NameField.Text = "";
                NameField.ForeColor = Color.Black;
            }
            
        }

        private void NameField_Leave(object sender, EventArgs e)
        {
            if (NameField.Text == "")
            {
                NameField.Text = "Введите Имя";
                NameField.ForeColor = Color.Gray;
            }

        }

        private void LstNameField_Enter(object sender, EventArgs e)
        {
            if (LstNameField.Text == "Введите Фамилию")
            {
                LstNameField.Text = "";
                LstNameField.ForeColor = Color.Black;
            }
        }

        private void LstNameField_Leave(object sender, EventArgs e)
        {
            if (LstNameField.Text == "")
            {
                LstNameField.Text = "Введите Фамилию";
                LstNameField.ForeColor = Color.Gray;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTime1_ValueChanged(object sender, EventArgs e)
        {
            label2.Text = String.Format("Дата вылета: {0}", dateTime1.Value.ToLongDateString());
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Выберите рейс")
            {
                comboBox1.Text = "";
                comboBox1.ForeColor = Color.Black;
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "Выберите рейс";
                comboBox1.ForeColor = Color.Gray;
            }

            radioButton1.Text = "Економ  400";
            radioButton2.Text = "Бизнес   800";
            radioButton3.Text = "VIP          1500";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}