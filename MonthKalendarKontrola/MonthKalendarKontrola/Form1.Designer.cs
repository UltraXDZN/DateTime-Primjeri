
namespace MonthKalendarKontrola
{
    partial class Zaglavlje
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
            this.terminButton = new System.Windows.Forms.Button();
            this.kalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // terminButton
            // 
            this.terminButton.Location = new System.Drawing.Point(99, 194);
            this.terminButton.Name = "terminButton";
            this.terminButton.Size = new System.Drawing.Size(137, 23);
            this.terminButton.TabIndex = 1;
            this.terminButton.Text = "Odaberite termin";
            this.terminButton.UseVisualStyleBackColor = true;
            this.terminButton.Click += new System.EventHandler(this.terminButton_Click);
            // 
            // kalendar
            // 
            this.kalendar.Location = new System.Drawing.Point(52, 18);
            this.kalendar.MaxSelectionCount = 99;
            this.kalendar.Name = "kalendar";
            this.kalendar.TabIndex = 2;
            // 
            // Zaglavlje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 229);
            this.Controls.Add(this.kalendar);
            this.Controls.Add(this.terminButton);
            this.Name = "Zaglavlje";
            this.Text = "Upotreba MonthCalendar kontrole";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button terminButton;
        private System.Windows.Forms.MonthCalendar kalendar;
    }
}

