
namespace DateTimePickerKontrola
{
    partial class Form1
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
            this.labelUnosDatuma = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.unosVremenaLabel = new System.Windows.Forms.Label();
            this.richTextBoxIspis = new System.Windows.Forms.RichTextBox();
            this.buttonRezervacija = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUnosDatuma
            // 
            this.labelUnosDatuma.AutoSize = true;
            this.labelUnosDatuma.Location = new System.Drawing.Point(13, 13);
            this.labelUnosDatuma.Name = "labelUnosDatuma";
            this.labelUnosDatuma.Size = new System.Drawing.Size(94, 13);
            this.labelUnosDatuma.TabIndex = 0;
            this.labelUnosDatuma.Text = "Upišite datum leta:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Value = new System.DateTime(2021, 2, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker2.Location = new System.Drawing.Point(136, 52);
            this.dateTimePicker2.MaxDate = new System.DateTime(2021, 2, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 2;
            this.dateTimePicker2.TabStop = false;
            this.dateTimePicker2.Value = new System.DateTime(2021, 2, 1, 0, 0, 0, 0);
            // 
            // unosVremenaLabel
            // 
            this.unosVremenaLabel.AutoSize = true;
            this.unosVremenaLabel.Location = new System.Drawing.Point(12, 52);
            this.unosVremenaLabel.Name = "unosVremenaLabel";
            this.unosVremenaLabel.Size = new System.Drawing.Size(118, 13);
            this.unosVremenaLabel.TabIndex = 3;
            this.unosVremenaLabel.Text = "Upišite vrijeme polaska:";
            // 
            // richTextBoxIspis
            // 
            this.richTextBoxIspis.Location = new System.Drawing.Point(16, 80);
            this.richTextBoxIspis.Name = "richTextBoxIspis";
            this.richTextBoxIspis.Size = new System.Drawing.Size(320, 244);
            this.richTextBoxIspis.TabIndex = 4;
            this.richTextBoxIspis.Text = "";
            // 
            // buttonRezervacija
            // 
            this.buttonRezervacija.Location = new System.Drawing.Point(136, 351);
            this.buttonRezervacija.Name = "buttonRezervacija";
            this.buttonRezervacija.Size = new System.Drawing.Size(75, 23);
            this.buttonRezervacija.TabIndex = 5;
            this.buttonRezervacija.Text = "Rezervacija";
            this.buttonRezervacija.UseVisualStyleBackColor = true;
            this.buttonRezervacija.Click += new System.EventHandler(this.buttonRezervacija_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 386);
            this.Controls.Add(this.buttonRezervacija);
            this.Controls.Add(this.richTextBoxIspis);
            this.Controls.Add(this.unosVremenaLabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.labelUnosDatuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUnosDatuma;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label unosVremenaLabel;
        private System.Windows.Forms.RichTextBox richTextBoxIspis;
        private System.Windows.Forms.Button buttonRezervacija;
    }
}

