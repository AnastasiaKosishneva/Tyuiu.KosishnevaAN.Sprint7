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

            
            using (var reader = new StreamReader("encoded-база данных (1).csv"))                 
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
            try
            {
                //Сохраняем изменения обратно в CSV файл
                using (var writer = new StreamWriter("encoded-база данных (1).csv"))
                {
                    foreach (DataGridViewRow row in dataGridViewRabotniki_KAN.Rows)
                    {
                        writer.WriteLine(string.Join(";", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>().ToArray(), cell => cell.Value.ToString())));
                    }
                }
                MessageBox.Show("Данные успешно сохранены!");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении данных: {ex.Message}");
            }
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
    }
    
}
