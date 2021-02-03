namespace Projekt.Formularze
{
    partial class WypozyczeniaKlientaForm
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
            this.wypozyczeniaListView = new System.Windows.Forms.ListView();
            this.oddajKsiazkeButton = new System.Windows.Forms.Button();
            this.noweWypozyczenieButton = new System.Windows.Forms.Button();
            this.zamknijButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // wypozyczeniaListView
            // 
            this.wypozyczeniaListView.BackColor = System.Drawing.Color.White;
            this.wypozyczeniaListView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wypozyczeniaListView.HideSelection = false;
            this.wypozyczeniaListView.Location = new System.Drawing.Point(74, 12);
            this.wypozyczeniaListView.MultiSelect = false;
            this.wypozyczeniaListView.Name = "wypozyczeniaListView";
            this.wypozyczeniaListView.Size = new System.Drawing.Size(304, 216);
            this.wypozyczeniaListView.TabIndex = 5;
            this.wypozyczeniaListView.UseCompatibleStateImageBehavior = false;
            this.wypozyczeniaListView.View = System.Windows.Forms.View.Details;
            this.wypozyczeniaListView.SelectedIndexChanged += new System.EventHandler(this.wypozyczeniaListView_SelectedIndexChanged);
            // 
            // oddajKsiazkeButton
            // 
            this.oddajKsiazkeButton.BackColor = System.Drawing.Color.White;
            this.oddajKsiazkeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oddajKsiazkeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oddajKsiazkeButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.oddajKsiazkeButton.Location = new System.Drawing.Point(74, 247);
            this.oddajKsiazkeButton.Name = "oddajKsiazkeButton";
            this.oddajKsiazkeButton.Size = new System.Drawing.Size(304, 44);
            this.oddajKsiazkeButton.TabIndex = 6;
            this.oddajKsiazkeButton.Text = "Zwrot Książki";
            this.oddajKsiazkeButton.UseVisualStyleBackColor = false;
            this.oddajKsiazkeButton.Click += new System.EventHandler(this.oddajKsiazkeButton_Click);
            // 
            // noweWypozyczenieButton
            // 
            this.noweWypozyczenieButton.BackColor = System.Drawing.Color.White;
            this.noweWypozyczenieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.noweWypozyczenieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.noweWypozyczenieButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.noweWypozyczenieButton.Location = new System.Drawing.Point(74, 297);
            this.noweWypozyczenieButton.Name = "noweWypozyczenieButton";
            this.noweWypozyczenieButton.Size = new System.Drawing.Size(304, 44);
            this.noweWypozyczenieButton.TabIndex = 7;
            this.noweWypozyczenieButton.Text = "Nowe Wypożyczenie";
            this.noweWypozyczenieButton.UseVisualStyleBackColor = false;
            this.noweWypozyczenieButton.Click += new System.EventHandler(this.noweWypozyczenieButton_Click);
            // 
            // zamknijButton
            // 
            this.zamknijButton.BackColor = System.Drawing.Color.White;
            this.zamknijButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zamknijButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zamknijButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.zamknijButton.Location = new System.Drawing.Point(74, 347);
            this.zamknijButton.Name = "zamknijButton";
            this.zamknijButton.Size = new System.Drawing.Size(304, 44);
            this.zamknijButton.TabIndex = 8;
            this.zamknijButton.Text = "Zamknij";
            this.zamknijButton.UseVisualStyleBackColor = false;
            this.zamknijButton.Click += new System.EventHandler(this.zamknijButton_Click);
            // 
            // WypozyczeniaKlientaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 424);
            this.Controls.Add(this.zamknijButton);
            this.Controls.Add(this.noweWypozyczenieButton);
            this.Controls.Add(this.oddajKsiazkeButton);
            this.Controls.Add(this.wypozyczeniaListView);
            this.Name = "WypozyczeniaKlientaForm";
            this.Text = "WypozyczeniaKlientaForm";
            this.Load += new System.EventHandler(this.WypozyczeniaKlientaForm_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView wypozyczeniaListView;
        private System.Windows.Forms.Button oddajKsiazkeButton;
        private System.Windows.Forms.Button noweWypozyczenieButton;
        private System.Windows.Forms.Button zamknijButton;
    }
}