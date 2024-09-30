using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public DataRowView currentRow;
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = db44.mdb";
        private OleDbConnection newConnection;
        public int lastRowID;
        public int currentRowID;
        public Form2()
        {
            InitializeComponent();
            newConnection = new OleDbConnection(connectString);
            newConnection.Open();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            if (currentRow != null)
            {
                label15.Text = currentRowID.ToString();
                textBox1.Text = currentRow.Row["Модель"].ToString();
                dateTimePicker2.Value = Convert.ToDateTime(currentRow.Row["Год выпуска"]);
                textBox3.Text = currentRow.Row["Госномер"].ToString();
                textBox4.Text = currentRow.Row["Страховая стоимость"].ToString();
                textBox5.Text = currentRow.Row["ФИО владельца"].ToString();
                textBox6.Text = currentRow.Row["Данные паспорта владельца"].ToString();
                textBox7.Text = currentRow.Row["Вид нарушения ПДД"].ToString();
                textBox8.Text = currentRow.Row["Размер штрафа"].ToString();
                dateTimePicker1.Value = Convert.ToDateTime(currentRow.Row["Дата нарушения ПДД"]);
                textBox10.Text = currentRow.Row["ФИО водителя"].ToString();
                textBox11.Text = currentRow.Row["Право управления"].ToString();

                button1.Text = "Редактировать";
            }
            else
            {
                label15.Text = (lastRowID).ToString();
                button1.Text = "Добавить";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox10.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox11.Text == "")
            {
                MessageBox.Show("Ты не заполнил все поля");
                return;
            }
            int kod = Convert.ToInt32(label15.Text);
            string model = textBox1.Text;
            string vipusk = dateTimePicker2.Value.ToString();
            string nomer = textBox3.Text;
            string stoim = textBox4.Text;
            string fio_vlad = textBox5.Text;
            string passport = textBox6.Text;
            string vid_nar = textBox7.Text;
            string sum = textBox8.Text;
            string date_nar = dateTimePicker1.Value.ToString();
            string fio_vod = textBox10.Text;
            string pravo = textBox11.Text;
            string vznos = Convert.ToString(Convert.ToInt32(stoim)/10);
            string query = null;
            if (currentRow == null)
            {
                query = "INSERT INTO Учет (Код, [Модель], [Год выпуска], Госномер, [Страховая стоимость]," +
                     "[ФИО владельца], [Данные паспорта владельца], [Вид нарушения ПДД], [Размер штрафа]," +
                     "[Дата нарушения ПДД], [ФИО водителя], [Право управления], [Страховой взнос]) VALUES (" + kod + ", '" + model + "', '" + vipusk + "', " + nomer + ",  '" + stoim + "',  '" + fio_vlad + "'," +
                     "  '" + passport + "',  '" + vid_nar + "',  " + sum + ",  '" + date_nar + "',  '" + fio_vod + "',  '" + pravo + "',  " + vznos + ")";
            }
            else
            {
                query = $"UPDATE Учет SET [Модель] = '{model}',  [Год выпуска] = '{vipusk}', " +
                    $"Госномер = '{nomer}', [Страховая стоимость] = '{stoim}', " +
                    $"[ФИО владельца] = '{fio_vlad}', [Данные паспорта владельца] = '{passport}',  " +
                    $"[Вид нарушения ПДД] = '{vid_nar}', [Размер штрафа] = '{sum}', [Дата нарушения ПДД] = '{date_nar}', [ФИО водителя] = '{fio_vod}', [Право управления] = '{pravo}', [Страховой взнос] = '{vznos}' WHERE Код = {kod}";
            }
            Console.WriteLine(query);
            OleDbCommand command = new OleDbCommand(query, newConnection);
            command.ExecuteNonQuery();
            MessageBox.Show("Строка добавлена!");

            Close();
        }

    }
}
