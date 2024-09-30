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

    public partial class Form3 : Form
    {
        public static string connectString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = db44.mdb";
        private OleDbConnection newConnection;
        public Form3()
        {
            InitializeComponent();
            newConnection = new OleDbConnection(connectString);
            newConnection.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = $"SELECT [Код], [Модель], [Год выпуска], [Госномер], [Страховая стоимость], [ФИО владельца], [Данные паспорта владельца] FROM Учет ";
            Console.WriteLine(query);
            OleDbDataAdapter command = new OleDbDataAdapter(query, newConnection);
            DataTable d = new DataTable();
            command.Fill(d);
            dataGridView1.DataSource = d;
            newConnection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = $"SELECT [Код], [Вид нарушения ПДД], [Размер штрафа] FROM Учет ";
            Console.WriteLine(query);
            OleDbDataAdapter command = new OleDbDataAdapter(query, newConnection);
            DataTable d = new DataTable();
            command.Fill(d);
            dataGridView1.DataSource = d;
            newConnection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = $"SELECT [Код], [Вид нарушения ПДД], [Дата нарушения ПДД], [ФИО водителя], [Право управления] FROM Учет ";
            Console.WriteLine(query);
            OleDbDataAdapter command = new OleDbDataAdapter(query, newConnection);
            DataTable d = new DataTable();
            command.Fill(d);
            dataGridView1.DataSource = d;
            newConnection.Close();
        }
    }
}
