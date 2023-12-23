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
            dataGridViewRabotniki_KAN.ColumnCount = 9;

            
            using (var reader = new StreamReader("БАЗА ДАННЫХ.csv"))                 
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    dataGridViewRabotniki_KAN.Rows.Add(values);
                }
                dataGridViewRabotniki_KAN.Rows.RemoveAt(0);

            }
            

        }

        private void buttonPLUS_KAN_Click(object sender, EventArgs e)  //СОХРАНЕНИЕ
        {
            //
               
        }

        private void button1_Click_1(object sender, EventArgs e) // ДОБАВЛЕНИЕ
        {
            string fame = textBoxF_KAN.Text;
            string name = textBoxI_KAN.Text;
            string otestv = textBoxO_KAN.Text;
            string dolgnost = textBoxD.Text;
            string telephon = textBoxN_KAN.Text;
            string datarogd = textBoxDR_KAN.Text;
            string datazachisl = textBoxDZ_KAN.Text;
            string stag = textBoxST_KAN.Text;
            string obr = textBoxOBR_KAN.Text;

            // заполнение
            dataGridViewRabotniki_KAN.Rows.Add(fame, name, otestv, dolgnost, telephon, datarogd, datazachisl, stag, obr);
            textBoxF_KAN.Text = "";
            textBoxI_KAN.Text = "";
            textBoxO_KAN.Text = "";
            textBoxD.Text = "";
            textBoxN_KAN.Text = "";
            textBoxDR_KAN.Text = "";
            textBoxDZ_KAN.Text = "";
            textBoxST_KAN.Text = "";
            textBoxOBR_KAN.Text = "";
            dataGridViewRabotniki_KAN.CurrentCell = dataGridViewRabotniki_KAN.Rows[dataGridViewRabotniki_KAN.Rows.Count - 1].Cells[0];


        }

        private void buttonPOISK_KAN_Click(object sender, EventArgs e) // ПОИСК
        {
            //
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //
        }

        private void dataGridViewRabotniki_KAN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //
        }

        private void buttonDob_VKL_Click(object sender, EventArgs e)
        {
            //groupBoxADD_KAN
            groupBoxADD_KAN.Enabled = true;
            buttonADD_KAN.Enabled = true;
            buttonDob_VKL.Enabled = 
            button3.Enabled = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBoxADD_KAN.Enabled = false;
            buttonADD_KAN.Enabled = false;
        }

        private void textBoxPOISK_KAN_TextChanged(object sender, EventArgs e)
        {
            string searchText = textBoxPOISK_KAN.Text.ToLower(); //приведение к нижнему регистру
            foreach (DataGridViewRow row in dataGridViewRabotniki_KAN.Rows)
            {
                if (row.Cells["ColumnF"].Value != null && row.Cells["ColumnI"].Value != null)
                {
                    string column2Text = row.Cells["ColumnF"].Value.ToString().ToLower();
                    string column3Text = row.Cells["ColumnI"].Value.ToString().ToLower();

                    if (column2Text.Contains(searchText) || column3Text.Contains(searchText))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null)
            {
                int columnIndex = 7;
                string selectedItem = comboBox1.SelectedItem.ToString();
                foreach (DataGridViewRow row in dataGridViewRabotniki_KAN.Rows)
                {
                    int cellValue;
                    if (row.Cells[columnIndex].Value != null && int.TryParse(row.Cells[columnIndex].Value.ToString(), out cellValue))
                    {
                        row.Cells[columnIndex].Value = cellValue;
                    }
                }
                try
                {
                    DataGridViewColumn column = dataGridViewRabotniki_KAN.Columns[7];

                    if (selectedItem == "по возрастанию")
                    {
                        dataGridViewRabotniki_KAN.Sort(column, ListSortDirection.Ascending);
                    }
                    if (selectedItem == "по убыванию")
                    {
                        dataGridViewRabotniki_KAN.Sort(column, ListSortDirection.Descending);
                    }
                }
                catch
                {
                    MessageBox.Show("Невозможно выполнить сортировку", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonAnaliz_Click(object sender, EventArgs e)
        {
            {
                int rows = dataGridViewRabotniki_KAN.RowCount;
                int columns = dataGridViewRabotniki_KAN.ColumnCount;
                string str;
                string[,] matrix = new string[rows, columns];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        str = "";
                        str += dataGridViewRabotniki_KAN.Rows[i].Cells[j].Value;
                        matrix[i, j] = str;
                    }

                }

                int k = 0;

                for (int i = 0; i < rows - 1; i++)
                {
                    k++;
                    textBoxKol.Text = k.ToString();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void label21_Click(object sender, EventArgs e)
        {
            //
        }

        private void buttonAnaliz2_Click(object sender, EventArgs e)
        {

            int rows = dataGridViewRabotniki_KAN.RowCount;
            int columns = dataGridViewRabotniki_KAN.ColumnCount;
            string str;
            string[,] matrix = new string[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    str = "";
                    str += dataGridViewRabotniki_KAN.Rows[i].Cells[j].Value;
                    matrix[i, j] = str;
                }

            }


            int b = 0;
            int ii = 0;
            int ss = 0;
            int mm = 0;

            for (int i = 0; i < rows - 1; i++)
            {
                if (matrix[i, 3] == "бухгалтер")
                {
                    b++;
                }
                if (matrix[i, 3] == "геолог-нефтяник")
                {
                    ii++;
                }
                if (matrix[i, 3] == "секретарь")
                {
                    ss++;
                }
                if (matrix[i, 3] == "менеджер")
                {
                    mm++;
                }
            }
            textBoxBUG.Text = b.ToString();
            textBoxGEOLOG.Text = ii.ToString();
            textBoxSECR.Text = ss.ToString();
            textBoxMENEDG.Text = mm.ToString();

        }

        private void buttonChart_KAN_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            for (int i = 0; i < dataGridViewRabotniki_KAN.RowCount - 1; i++)
            {
                chart1.Series[1].Points.AddXY(i + 1, dataGridViewRabotniki_KAN.Rows[i].Cells[5].Value);
            }
            //chart1.Series[0].Points.AddXY(1, Convert.ToInt32(textBoxBUG.Text));
            //chart1.Series[1].Points.AddXY(2, Convert.ToInt32(textBoxGEOLOG.Text));
            //chart1.Series[2].Points.AddXY(3, Convert.ToInt32(textBoxSECR.Text));
            //chart1.Series[3].Points.AddXY(4, Convert.ToInt32(textBoxMENEDG.Text));
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
        }
    }
    
}
