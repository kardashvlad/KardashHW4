using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task5.Classes;

namespace Task5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SetupDataGridView()
        {
            mainDataGridView.Rows.Clear();
            mainDataGridView.ColumnCount = 8;
            mainDataGridView.Columns[0].Name = "Назва";
            mainDataGridView.Columns[1].Name = "Країна";
            mainDataGridView.Columns[2].Name = "Ціна";
            mainDataGridView.Columns[3].Name = "Дата";
            mainDataGridView.Columns[4].Name = "Опис";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupDataGridView();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Food food = new Food(
                textBox1.Text,
                int.Parse(textBox2.Text),
                textBox3.Text,
                double.Parse(textBox4.Text),
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text
                );
            mainDataGridView.Rows.Add(food.GetData());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Book book = new Book(
                int.Parse(textBox1.Text),
                textBox2.Text,
                textBox3.Text,
                double.Parse(textBox4.Text),
                textBox5.Text,
                textBox6.Text,
                textBox7.Text,
                textBox8.Text
                );
            mainDataGridView.Rows.Add(book.GetData());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            if(mainDataGridView.RowCount > 1)
            {
                mainDataGridView.Rows.RemoveAt(mainDataGridView.RowCount - 2);
            }
        }
    }
}
