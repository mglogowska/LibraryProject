namespace Projekt.Formularze
{
    partial class EdytujKlientaForm
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
            this.edytujKlientaLabel = new System.Windows.Forms.Label();
            this.daneKlienta1 = new Komponenty.DaneKlienta();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.wrodzButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edytujKlientaLabel
            // 
            this.edytujKlientaLabel.AutoSize = true;
            this.edytujKlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujKlientaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.edytujKlientaLabel.Location = new System.Drawing.Point(12, 20);
            this.edytujKlientaLabel.Name = "edytujKlientaLabel";
            this.edytujKlientaLabel.Size = new System.Drawing.Size(172, 20);
            this.edytujKlientaLabel.TabIndex = 6;
            this.edytujKlientaLabel.Text = "Edytuj Dane Klienta:";
            // 
            // daneKlienta1
            // 
            this.daneKlienta1.BackColor = System.Drawing.Color.White;
            this.daneKlienta1.Imie = null;
            this.daneKlienta1.Location = new System.Drawing.Point(26, 53);
            this.daneKlienta1.Name = "daneKlienta1";
            this.daneKlienta1.Nazwisko = null;
            this.daneKlienta1.Size = new System.Drawing.Size(245, 78);
            this.daneKlienta1.TabIndex = 7;
            // 
            // zapiszButton
            // 
            this.zapiszButton.BackColor = System.Drawing.Color.White;
            this.zapiszButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zapiszButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zapiszButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.zapiszButton.Location = new System.Drawing.Point(12, 137);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(119, 33);
            this.zapiszButton.TabIndex = 8;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = false;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_ClickAsync);
            // 
            // wrodzButton
            // 
            this.wrodzButton.BackColor = System.Drawing.Color.White;
            this.wrodzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrodzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrodzButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wrodzButton.Location = new System.Drawing.Point(137, 137);
            this.wrodzButton.Name = "wrodzButton";
            this.wrodzButton.Size = new System.Drawing.Size(119, 33);
            this.wrodzButton.TabIndex = 9;
            this.wrodzButton.Text = "Powrót";
            this.wrodzButton.UseVisualStyleBackColor = false;
            this.wrodzButton.Click += new System.EventHandler(this.wrodzButton_Click);
            // 
            // EdytujKlientaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(277, 228);
            this.Controls.Add(this.wrodzButton);
            this.Controls.Add(this.zapiszButton);
            this.Controls.Add(this.daneKlienta1);
            this.Controls.Add(this.edytujKlientaLabel);
            this.Name = "EdytujKlientaForm";
            this.Text = "EdytujKlientaForm";
            this.Load += new System.EventHandler(this.EdytujKlientaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label edytujKlientaLabel;
        private Komponenty.DaneKlienta daneKlienta1;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.Button wrodzButton;
    }
}