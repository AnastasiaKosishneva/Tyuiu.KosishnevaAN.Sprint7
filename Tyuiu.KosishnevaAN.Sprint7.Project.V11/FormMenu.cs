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
using System.Windows.Forms.DataVisualization.Charting;

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
        static string openFilePath;
        static int rows;
        static int columns;
        private void button2_Click(object sender, EventArgs e) //ОТКРЫТЬ базу данных
        {

            try
            {
                openFileDialogBD.ShowDialog();
                openFilePath = openFileDialogBD.FileName;

                string[,] matrix = ds.LoadFromDataFile(openFilePath);

                rows = matrix.GetLength(0);
                columns = matrix.GetLength(1);

                dataGridViewRabotniki_KAN.RowCount = rows + 1;
                dataGridViewRabotniki_KAN.ColumnCount = columns;

                //добавление данных
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewRabotniki_KAN.Rows[i].Cells[j].Value = matrix[i, j];
                    }
                }
                dataGridViewRabotniki_KAN.AutoResizeColumns();
                dataGridViewRabotniki_KAN.ScrollBars = ScrollBars.Both;
                dataGridViewRabotniki_KAN.Rows.RemoveAt(0);
            }
            catch
            {
                MessageBox.Show("Файл не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //dataGridViewRabotniki_KAN.ColumnCount = 9;


            //using (var reader = new StreamReader("БАЗА ДАННЫХ.csv"))                 
            //{
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var values = line.Split(';');

            //        dataGridViewRabotniki_KAN.Rows.Add(values);
            //    }
            //    dataGridViewRabotniki_KAN.Rows.RemoveAt(0);

            //}


        }

        private void buttonPLUS_KAN_Click(object sender, EventArgs e)  //СОХРАНЕНИЕ
        {
            saveFileDialogBD.FileName = openFilePath;
            saveFileDialogBD.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogBD.ShowDialog();

            string path = saveFileDialogBD.FileName;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridViewRabotniki_KAN.RowCount;
            int columns = dataGridViewRabotniki_KAN.ColumnCount;

            string str = "";



            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewRabotniki_KAN.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridViewRabotniki_KAN.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }

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

        private void buttonAnaliz_Click(object sender, EventArgs e) // количество работников, средний стаж
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

                int summalet = 0;
                int k = 0;
                double srzn = 0;
                for (int i = 0; i < rows - 1; i++)
                {
                    summalet += Convert.ToInt32(dataGridViewRabotniki_KAN.Rows[i].Cells[7].Value);
                    k++;
                    textBoxKol.Text = k.ToString();

                }
                srzn = (summalet / k);
                //srzn = Math.Round(srzn, 3);
                //textBoxSrdn.Text = srzn.ToString();
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
            int b = 0;
            int ii = 0;
            int ss = 0;
            int mm = 0;
            int zeml = 0;
            int glbug = 0;
            int ekonom = 0;
            int kadrovik = 0;
            //string matrix = ds.LoadFromDataFile();
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
                if (matrix[i, 3] == "землеустроитель")
                {
                    zeml++;
                }
                if (matrix[i, 3] == "Главный бухгалтер")
                {
                    glbug++;
                }
                if (matrix[i, 3] == "экоаналитик")
                {
                    ekonom++;
                }
                if (matrix[i, 3] == "кадровик")
                {
                    kadrovik++;
                }
            }
            textBoxBUG.Text = b.ToString();
            textBoxGEOLOG.Text = ii.ToString();
            textBoxSECR.Text = ss.ToString();
            textBoxMENEDG.Text = mm.ToString();
            textBoxZEML.Text = zeml.ToString();
            textBoxGLBUG.Text = glbug.ToString();
            textBoxEKOanalitic.Text = ekonom.ToString();
            textBoxKADRovik.Text = kadrovik.ToString();
        }
        public string[,] valueArray;
        public int routeId;
        
        
        private void buttonChart_KAN_Click(object sender, EventArgs e)
        {
            int min = 0;
            
            textBoxBUG.Text = min.ToString();

            int b = 0;
            int ii = 0;
            int ss = 0;
            int mm = 0;
            int zeml = 0;
            int glbug = 0;
            int ekonom = 0;
            int kadrovik = 0;
            int rows = dataGridViewRabotniki_KAN.RowCount;
            int columns = dataGridViewRabotniki_KAN.ColumnCount;
            string str;
            string[,] matrix = new string[rows, columns];
            string[] matrixx;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    str = "";
                    str += dataGridViewRabotniki_KAN.Rows[i].Cells[j].Value;
                    matrix[i, j] = str;

                    if (j == 7)
                    {
                        str = "";
                        str = str + dataGridViewRabotniki_KAN.Rows[i].Cells[j].Value;
                        //matrixx = matrixx.Append(str);
                    }
                }

            }
            
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
                if (matrix[i, 3] == "землеустроитель")
                {
                    zeml++;
                }
                if (matrix[i, 3] == "Главный бухгалтер")
                {
                    glbug++;
                }
                if (matrix[i, 3] == "экоаналитик")
                {
                    ekonom++;
                }
                if (matrix[i, 3] == "кадровик")
                {
                    kadrovik++;
                }
            }
            // Data arrays.
            string[] seriesArray = { "бухгалтер", "геолог - нефтяник", "секретарь", "менеджер", "землеустроитель", "Главный бухгалтер", "экоаналитик", "кадровик" };
            int[] pointsArray = { b, ii, ss, mm, zeml, glbug, ekonom, kadrovik};

            // Set palette.
            chart1.Palette = ChartColorPalette.SeaGreen;

            // Set title.
            chart1.Titles.Add("Должности");
            chart1.ChartAreas[0].AxisX.Interval = 2;


            // Add series.
            for (int i = 0; i < seriesArray.Length; i++)
            {
                // Add series.
                Series series = chart1.Series.Add(seriesArray[i]);
                //chart1.Series[0].Points.AddXY(dataGridViewRabotniki_KAN.Rows[i].Cells[0].Value, dataGridViewRabotniki_KAN.Rows[i].Cells[7].Value);
                // Add point.
                series.Points.Add(pointsArray[i]);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {


            //
        }
    }
    
}
