
namespace Tyuiu.KosishnevaAN.Sprint7.Project.V11
{
    partial class FormMainPUSK_KAN
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelPUSK_KAN = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(234, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "Запустить программу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPUSK_KAN
            // 
            this.labelPUSK_KAN.AutoSize = true;
            this.labelPUSK_KAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPUSK_KAN.Location = new System.Drawing.Point(216, 142);
            this.labelPUSK_KAN.Name = "labelPUSK_KAN";
            this.labelPUSK_KAN.Size = new System.Drawing.Size(173, 29);
            this.labelPUSK_KAN.TabIndex = 1;
            this.labelPUSK_KAN.Text = "Отдел кадров";
            // 
            // FormMainPUSK_KAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 422);
            this.Controls.Add(this.labelPUSK_KAN);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMainPUSK_KAN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пуск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelPUSK_KAN;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

