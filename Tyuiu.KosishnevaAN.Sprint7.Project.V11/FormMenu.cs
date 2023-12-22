using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.KosishnevaAN.Sprint7.Project.V11.Lib;

namespace Tyuiu.KosishnevaAN.Sprint7.Project.V11
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        int index;
        private void button1_Click(object sender, EventArgs e)
        {
           //
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            //
        }
        DataService ds = new DataService();
        
        private void button2_Click(object sender, EventArgs e) //ОТКРЫТЬ базу данных
        {
            dataGridViewRabotniki_KAN.ColumnCount = 8;

            
            using (var reader = new StreamReader("encoded-база данных (2).csv"))                 
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    dataGridViewRabotniki_KAN.Rows.Add(values);
                }
            }
            

        }

        private void buttonPLUS_KAN_Click(object sender, EventArgs e)  //СОХРАНЕНИЕ
        {
            //
               
        }

        private void button1_Click_1(object sender, EventArgs e) // ДОБАВЛЕНИЕ
        {
            string name = textBoxFOI_KAN.Text;
            string position = textBoxDolgn_KAN.Text;
            string specialization = textBoxTel_KAN.Text;
            // заполнение
            dataGridViewRabotniki_KAN.Rows.Add(name, position, specialization);
            textBoxFOI_KAN.Text = "";
            textBoxDolgn_KAN.Text = "";
            textBoxTel_KAN.Text = "";
            dataGridViewRabotniki_KAN.CurrentCell = dataGridViewRabotniki_KAN.Rows[dataGridViewRabotniki_KAN.Rows.Count - 1].Cells[0];
        }

        private void buttonPOISK_KAN_Click(object sender, EventArgs e) // ПОИСК
        {
            string searchText = textBoxPOISK_KAN.Text.ToLower(); // Приведение введенного текста к нижнему регистру

            // Проверка, является ли строка поиска пустой
            if (string.IsNullOrWhiteSpace(searchText))
            {
                // Возвращение оригинального стиля для всех ячеек
                foreach (DataGridViewRow row in dataGridViewRabotniki_KAN.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Style.BackColor = dataGridViewRabotniki_KAN.DefaultCellStyle.BackColor;
                        cell.Style.ForeColor = dataGridViewRabotniki_KAN.DefaultCellStyle.ForeColor;
                    }
                }
                return;
            }

            // Проход по каждой ячейке в dataGridViewPC_SIA
            foreach (DataGridViewRow row in dataGridViewRabotniki_KAN.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        // Подсветка совпадающего слова
                        cell.Style.BackColor = Color.Silver;
                        cell.Style.ForeColor = Color.Black;
                    }
                    else
                    {
                        // Возвращение оригинального стиля ячейки
                        cell.Style.BackColor = dataGridViewRabotniki_KAN.DefaultCellStyle.BackColor;
                        cell.Style.ForeColor = dataGridViewRabotniki_KAN.DefaultCellStyle.ForeColor;
                    }
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e) // УДАЛИТЬ 
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить \nвыбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                index = dataGridViewRabotniki_KAN.CurrentCell.RowIndex;
                dataGridViewRabotniki_KAN.Rows.RemoveAt(index);
            }
            ;
        }
    }
    
}
