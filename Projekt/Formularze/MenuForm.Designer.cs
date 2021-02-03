namespace Projekt
{
    partial class MenuForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.wypozyczeniaButton = new System.Windows.Forms.Button();
            this.klienciButton = new System.Windows.Forms.Button();
            this.wyjdzButton = new System.Windows.Forms.Button();
            this.clockPictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.clockPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // wypozyczeniaButton
            // 
            this.wypozyczeniaButton.BackColor = System.Drawing.Color.White;
            this.wypozyczeniaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wypozyczeniaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wypozyczeniaButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wypozyczeniaButton.Location = new System.Drawing.Point(66, 67);
            this.wypozyczeniaButton.Name = "wypozyczeniaButton";
            this.wypozyczeniaButton.Size = new System.Drawing.Size(201, 57);
            this.wypozyczeniaButton.TabIndex = 0;
            this.wypozyczeniaButton.Text = "Wypożyczenia";
            this.wypozyczeniaButton.UseVisualStyleBackColor = false;
            this.wypozyczeniaButton.Click += new System.EventHandler(this.wypozyczeniaButton_Click);
            // 
            // klienciButton
            // 
            this.klienciButton.BackColor = System.Drawing.Color.White;
            this.klienciButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klienciButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.klienciButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.klienciButton.Location = new System.Drawing.Point(66, 183);
            this.klienciButton.Name = "klienciButton";
            this.klienciButton.Size = new System.Drawing.Size(201, 57);
            this.klienciButton.TabIndex = 1;
            this.klienciButton.Text = "Klienci";
            this.klienciButton.UseVisualStyleBackColor = false;
            this.klienciButton.Click += new System.EventHandler(this.klienciButton_Click);
            // 
            // wyjdzButton
            // 
            this.wyjdzButton.BackColor = System.Drawing.Color.White;
            this.wyjdzButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wyjdzButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wyjdzButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wyjdzButton.Location = new System.Drawing.Point(66, 309);
            this.wyjdzButton.Name = "wyjdzButton";
            this.wyjdzButton.Size = new System.Drawing.Size(201, 57);
            this.wyjdzButton.TabIndex = 3;
            this.wyjdzButton.Text = "Wyjdź";
            this.wyjdzButton.UseVisualStyleBackColor = false;
            this.wyjdzButton.Click += new System.EventHandler(this.wyjdzButton_Click);
            // 
            // clockPictureBox
            // 
            this.clockPictureBox.Location = new System.Drawing.Point(377, 116);
            this.clockPictureBox.Name = "clockPictureBox";
            this.clockPictureBox.Size = new System.Drawing.Size(198, 182);
            this.clockPictureBox.TabIndex = 4;
            this.clockPictureBox.TabStop = false;
            this.clockPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.clockPictureBox_Paint);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 437);
            this.Controls.Add(this.clockPictureBox);
            this.Controls.Add(this.wyjdzButton);
            this.Controls.Add(this.klienciButton);
            this.Controls.Add(this.wypozyczeniaButton);
            this.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clockPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button wypozyczeniaButton;
        private System.Windows.Forms.Button klienciButton;
        private System.Windows.Forms.Button wyjdzButton;
        private System.Windows.Forms.PictureBox clockPictureBox;
        private System.Windows.Forms.Timer timer;
    }
}

