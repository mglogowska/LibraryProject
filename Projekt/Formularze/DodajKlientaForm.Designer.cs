namespace Projekt.Formularze
{
    partial class DodajKlientaForm
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
            this.dodajKlientaLabel = new System.Windows.Forms.Label();
            this.dodajKlientaButton = new System.Windows.Forms.Button();
            this.daneKlienta1 = new Komponenty.DaneKlienta();
            this.powrotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodajKlientaLabel
            // 
            this.dodajKlientaLabel.AutoSize = true;
            this.dodajKlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajKlientaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dodajKlientaLabel.Location = new System.Drawing.Point(53, 44);
            this.dodajKlientaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.dodajKlientaLabel.Name = "dodajKlientaLabel";
            this.dodajKlientaLabel.Size = new System.Drawing.Size(228, 20);
            this.dodajKlientaLabel.TabIndex = 4;
            this.dodajKlientaLabel.Text = "Dodawanie nowego klienta:";
            // 
            // dodajKlientaButton
            // 
            this.dodajKlientaButton.BackColor = System.Drawing.Color.White;
            this.dodajKlientaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajKlientaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajKlientaButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.dodajKlientaButton.Location = new System.Drawing.Point(106, 343);
            this.dodajKlientaButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dodajKlientaButton.Name = "dodajKlientaButton";
            this.dodajKlientaButton.Size = new System.Drawing.Size(336, 90);
            this.dodajKlientaButton.TabIndex = 5;
            this.dodajKlientaButton.Text = "Dodaj Klienta";
            this.dodajKlientaButton.UseVisualStyleBackColor = false;
            this.dodajKlientaButton.Click += new System.EventHandler(this.dodajKlientaButton_ClickAsync);
            // 
            // daneKlienta1
            // 
            this.daneKlienta1.BackColor = System.Drawing.Color.White;
            this.daneKlienta1.Imie = null;
            this.daneKlienta1.Location = new System.Drawing.Point(40, 138);
            this.daneKlienta1.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.daneKlienta1.Name = "daneKlienta1";
            this.daneKlienta1.Nazwisko = null;
            this.daneKlienta1.Size = new System.Drawing.Size(449, 144);
            this.daneKlienta1.TabIndex = 6;
            // 
            // powrotButton
            // 
            this.powrotButton.BackColor = System.Drawing.Color.White;
            this.powrotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powrotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powrotButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.powrotButton.Location = new System.Drawing.Point(106, 445);
            this.powrotButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.powrotButton.Name = "powrotButton";
            this.powrotButton.Size = new System.Drawing.Size(336, 90);
            this.powrotButton.TabIndex = 7;
            this.powrotButton.Text = "Zamknij";
            this.powrotButton.UseVisualStyleBackColor = false;
            this.powrotButton.Click += new System.EventHandler(this.powrotButton_Click);
            // 
            // DodajKlientaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(550, 604);
            this.Controls.Add(this.powrotButton);
            this.Controls.Add(this.daneKlienta1);
            this.Controls.Add(this.dodajKlientaButton);
            this.Controls.Add(this.dodajKlientaLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DodajKlientaForm";
            this.Text = "DodajKlientaForm";
            this.Load += new System.EventHandler(this.DodajKlientaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dodajKlientaLabel;
        private System.Windows.Forms.Button dodajKlientaButton;
        private Komponenty.DaneKlienta daneKlienta1;
        private System.Windows.Forms.Button powrotButton;
    }
}