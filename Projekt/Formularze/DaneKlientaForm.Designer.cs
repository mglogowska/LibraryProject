namespace Projekt.Formularze
{
    partial class DaneKlientaForm
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
            this.daneKlientaLabel = new System.Windows.Forms.Label();
            this.daneKlienta1 = new Komponenty.DaneKlienta();
            this.edytujKlientaButton = new System.Windows.Forms.Button();
            this.usunKlientaButton = new System.Windows.Forms.Button();
            this.powrotButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // daneKlientaLabel
            // 
            this.daneKlientaLabel.AutoSize = true;
            this.daneKlientaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.daneKlientaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.daneKlientaLabel.Location = new System.Drawing.Point(22, 61);
            this.daneKlientaLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.daneKlientaLabel.Name = "daneKlientaLabel";
            this.daneKlientaLabel.Size = new System.Drawing.Size(117, 20);
            this.daneKlientaLabel.TabIndex = 5;
            this.daneKlientaLabel.Text = "Dane Klienta:";
            this.daneKlientaLabel.Click += new System.EventHandler(this.dodajKlientaLabel_Click);
            // 
            // daneKlienta1
            // 
            this.daneKlienta1.BackColor = System.Drawing.Color.White;
            this.daneKlienta1.Imie = null;
            this.daneKlienta1.Location = new System.Drawing.Point(29, 126);
            this.daneKlienta1.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.daneKlienta1.Name = "daneKlienta1";
            this.daneKlienta1.Nazwisko = null;
            this.daneKlienta1.Size = new System.Drawing.Size(449, 144);
            this.daneKlienta1.TabIndex = 6;
            // 
            // edytujKlientaButton
            // 
            this.edytujKlientaButton.BackColor = System.Drawing.Color.White;
            this.edytujKlientaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.edytujKlientaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.edytujKlientaButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.edytujKlientaButton.Location = new System.Drawing.Point(29, 367);
            this.edytujKlientaButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.edytujKlientaButton.Name = "edytujKlientaButton";
            this.edytujKlientaButton.Size = new System.Drawing.Size(427, 78);
            this.edytujKlientaButton.TabIndex = 9;
            this.edytujKlientaButton.Text = "Edytuj Klienta";
            this.edytujKlientaButton.UseVisualStyleBackColor = false;
            this.edytujKlientaButton.Click += new System.EventHandler(this.edytujKlientaButton_Click);
            // 
            // usunKlientaButton
            // 
            this.usunKlientaButton.BackColor = System.Drawing.Color.White;
            this.usunKlientaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usunKlientaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.usunKlientaButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usunKlientaButton.Location = new System.Drawing.Point(29, 456);
            this.usunKlientaButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.usunKlientaButton.Name = "usunKlientaButton";
            this.usunKlientaButton.Size = new System.Drawing.Size(427, 78);
            this.usunKlientaButton.TabIndex = 10;
            this.usunKlientaButton.Text = "Usuń Klienta";
            this.usunKlientaButton.UseVisualStyleBackColor = false;
            this.usunKlientaButton.Click += new System.EventHandler(this.usunKlientaButton_ClickAsync);
            // 
            // powrotButton
            // 
            this.powrotButton.BackColor = System.Drawing.Color.White;
            this.powrotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powrotButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powrotButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.powrotButton.Location = new System.Drawing.Point(29, 545);
            this.powrotButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.powrotButton.Name = "powrotButton";
            this.powrotButton.Size = new System.Drawing.Size(427, 78);
            this.powrotButton.TabIndex = 11;
            this.powrotButton.Text = "Powrót";
            this.powrotButton.UseVisualStyleBackColor = false;
            this.powrotButton.Click += new System.EventHandler(this.powrotButton_Click);
            // 
            // DaneKlientaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(501, 641);
            this.Controls.Add(this.powrotButton);
            this.Controls.Add(this.usunKlientaButton);
            this.Controls.Add(this.edytujKlientaButton);
            this.Controls.Add(this.daneKlienta1);
            this.Controls.Add(this.daneKlientaLabel);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "DaneKlientaForm";
            this.Text = "DaneKlientaForm";
            this.Load += new System.EventHandler(this.DaneKlientaForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label daneKlientaLabel;
        private Komponenty.DaneKlienta daneKlienta1;
        private System.Windows.Forms.Button edytujKlientaButton;
        private System.Windows.Forms.Button usunKlientaButton;
        private System.Windows.Forms.Button powrotButton;
    }
}