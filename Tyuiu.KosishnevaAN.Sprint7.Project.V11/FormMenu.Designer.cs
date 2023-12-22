
namespace Tyuiu.KosishnevaAN.Sprint7.Project.V11
{
    partial class FormMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPOISK_KAN = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonSOHR_KAN = new System.Windows.Forms.Button();
            this.dataGridViewRabotniki_KAN = new System.Windows.Forms.DataGridView();
            this.buttonADD_KAN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBoxADD_KAN = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDolgn_KAN = new System.Windows.Forms.TextBox();
            this.textBoxTel_KAN = new System.Windows.Forms.TextBox();
            this.textBoxFOI_KAN = new System.Windows.Forms.TextBox();
            this.openFileDialogBD = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogBD = new System.Windows.Forms.SaveFileDialog();
            this.buttonPOISK_KAN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonDob_VKL = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRabotniki_KAN)).BeginInit();
            this.groupBoxADD_KAN.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelSort);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBoxADD_KAN);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonPOISK_KAN);
            this.panel1.Controls.Add(this.buttonSOHR_KAN);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxPOISK_KAN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1212, 180);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "главное меню";
            // 
            // textBoxPOISK_KAN
            // 
            this.textBoxPOISK_KAN.Location = new System.Drawing.Point(12, 50);
            this.textBoxPOISK_KAN.Multiline = true;
            this.textBoxPOISK_KAN.Name = "textBoxPOISK_KAN";
            this.textBoxPOISK_KAN.Size = new System.Drawing.Size(292, 26);
            this.textBoxPOISK_KAN.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridViewRabotniki_KAN);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 180);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 598);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "показать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonSOHR_KAN
            // 
            this.buttonSOHR_KAN.Location = new System.Drawing.Point(102, 82);
            this.buttonSOHR_KAN.Name = "buttonSOHR_KAN";
            this.buttonSOHR_KAN.Size = new System.Drawing.Size(90, 44);
            this.buttonSOHR_KAN.TabIndex = 5;
            this.buttonSOHR_KAN.Text = "Сохранить изменения";
            this.buttonSOHR_KAN.UseVisualStyleBackColor = true;
            this.buttonSOHR_KAN.Click += new System.EventHandler(this.buttonPLUS_KAN_Click);
            // 
            // dataGridViewRabotniki_KAN
            // 
            this.dataGridViewRabotniki_KAN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRabotniki_KAN.Location = new System.Drawing.Point(12, 6);
            this.dataGridViewRabotniki_KAN.Name = "dataGridViewRabotniki_KAN";
            this.dataGridViewRabotniki_KAN.RowHeadersWidth = 51;
            this.dataGridViewRabotniki_KAN.RowTemplate.Height = 24;
            this.dataGridViewRabotniki_KAN.Size = new System.Drawing.Size(626, 632);
            this.dataGridViewRabotniki_KAN.TabIndex = 0;
            // 
            // buttonADD_KAN
            // 
            this.buttonADD_KAN.Location = new System.Drawing.Point(387, 100);
            this.buttonADD_KAN.Name = "buttonADD_KAN";
            this.buttonADD_KAN.Size = new System.Drawing.Size(156, 59);
            this.buttonADD_KAN.TabIndex = 2;
            this.buttonADD_KAN.Text = "добавить";
            this.buttonADD_KAN.UseVisualStyleBackColor = true;
            this.buttonADD_KAN.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(644, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(568, 598);
            this.panel3.TabIndex = 2;
            // 
            // groupBoxADD_KAN
            // 
            this.groupBoxADD_KAN.Controls.Add(this.label5);
            this.groupBoxADD_KAN.Controls.Add(this.buttonDob_VKL);
            this.groupBoxADD_KAN.Controls.Add(this.label4);
            this.groupBoxADD_KAN.Controls.Add(this.label3);
            this.groupBoxADD_KAN.Controls.Add(this.buttonADD_KAN);
            this.groupBoxADD_KAN.Controls.Add(this.textBoxDolgn_KAN);
            this.groupBoxADD_KAN.Controls.Add(this.textBoxTel_KAN);
            this.groupBoxADD_KAN.Controls.Add(this.textBoxFOI_KAN);
            this.groupBoxADD_KAN.Location = new System.Drawing.Point(601, 9);
            this.groupBoxADD_KAN.Name = "groupBoxADD_KAN";
            this.groupBoxADD_KAN.Size = new System.Drawing.Size(576, 165);
            this.groupBoxADD_KAN.TabIndex = 6;
            this.groupBoxADD_KAN.TabStop = false;
            this.groupBoxADD_KAN.Text = "новый сотрудник";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "номер телефона";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(133, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ФИО";
            // 
            // textBoxDolgn_KAN
            // 
            this.textBoxDolgn_KAN.Location = new System.Drawing.Point(136, 73);
            this.textBoxDolgn_KAN.Name = "textBoxDolgn_KAN";
            this.textBoxDolgn_KAN.Size = new System.Drawing.Size(416, 22);
            this.textBoxDolgn_KAN.TabIndex = 2;
            // 
            // textBoxTel_KAN
            // 
            this.textBoxTel_KAN.Location = new System.Drawing.Point(136, 118);
            this.textBoxTel_KAN.Name = "textBoxTel_KAN";
            this.textBoxTel_KAN.Size = new System.Drawing.Size(187, 22);
            this.textBoxTel_KAN.TabIndex = 1;
            // 
            // textBoxFOI_KAN
            // 
            this.textBoxFOI_KAN.Location = new System.Drawing.Point(136, 26);
            this.textBoxFOI_KAN.Name = "textBoxFOI_KAN";
            this.textBoxFOI_KAN.Size = new System.Drawing.Size(416, 22);
            this.textBoxFOI_KAN.TabIndex = 0;
            // 
            // openFileDialogBD
            // 
            this.openFileDialogBD.FileName = "openFileDialog1";
            // 
            // buttonPOISK_KAN
            // 
            this.buttonPOISK_KAN.Location = new System.Drawing.Point(310, 50);
            this.buttonPOISK_KAN.Name = "buttonPOISK_KAN";
            this.buttonPOISK_KAN.Size = new System.Drawing.Size(75, 23);
            this.buttonPOISK_KAN.TabIndex = 2;
            this.buttonPOISK_KAN.Text = "поиск";
            this.buttonPOISK_KAN.UseVisualStyleBackColor = true;
            this.buttonPOISK_KAN.Click += new System.EventHandler(this.buttonPOISK_KAN_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 44);
            this.button1.TabIndex = 6;
            this.button1.Text = "удалить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // buttonDob_VKL
            // 
            this.buttonDob_VKL.Location = new System.Drawing.Point(43, 61);
            this.buttonDob_VKL.Name = "buttonDob_VKL";
            this.buttonDob_VKL.Size = new System.Drawing.Size(46, 45);
            this.buttonDob_VKL.TabIndex = 7;
            this.buttonDob_VKL.Text = "+";
            this.buttonDob_VKL.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(420, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 7;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(420, 27);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(86, 17);
            this.labelSort.TabIndex = 8;
            this.labelSort.Text = "Сортировка";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 778);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRabotniki_KAN)).EndInit();
            this.groupBoxADD_KAN.ResumeLayout(false);
            this.groupBoxADD_KAN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonADD_KAN;
        private System.Windows.Forms.TextBox textBoxPOISK_KAN;
        private System.Windows.Forms.DataGridView dataGridViewRabotniki_KAN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialogBD;
        private System.Windows.Forms.Button buttonSOHR_KAN;
        private System.Windows.Forms.SaveFileDialog saveFileDialogBD;
        private System.Windows.Forms.GroupBox groupBoxADD_KAN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDolgn_KAN;
        private System.Windows.Forms.TextBox textBoxTel_KAN;
        private System.Windows.Forms.TextBox textBoxFOI_KAN;
        private System.Windows.Forms.Button buttonPOISK_KAN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button buttonDob_VKL;
    }
}