namespace Komponenty
{
    partial class DaneKlienta
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.imieLabel = new System.Windows.Forms.Label();
            this.nazwiskoLabel = new System.Windows.Forms.Label();
            this.imieTextBox = new System.Windows.Forms.TextBox();
            this.nazwiskoTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // imieLabel
            // 
            this.imieLabel.AutoSize = true;
            this.imieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.imieLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.imieLabel.Location = new System.Drawing.Point(54, 10);
            this.imieLabel.Name = "imieLabel";
            this.imieLabel.Size = new System.Drawing.Size(48, 20);
            this.imieLabel.TabIndex = 2;
            this.imieLabel.Text = "Imie:";
            // 
            // nazwiskoLabel
            // 
            this.nazwiskoLabel.AutoSize = true;
            this.nazwiskoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nazwiskoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nazwiskoLabel.Location = new System.Drawing.Point(13, 46);
            this.nazwiskoLabel.Name = "nazwiskoLabel";
            this.nazwiskoLabel.Size = new System.Drawing.Size(89, 20);
            this.nazwiskoLabel.TabIndex = 3;
            this.nazwiskoLabel.Text = "Nazwisko:";
            // 
            // imieTextBox
            // 
            this.imieTextBox.Location = new System.Drawing.Point(111, 10);
            this.imieTextBox.Name = "imieTextBox";
            this.imieTextBox.Size = new System.Drawing.Size(122, 20);
            this.imieTextBox.TabIndex = 4;
            this.imieTextBox.TextChanged += new System.EventHandler(this.imieTextBox_TextChanged);
            // 
            // nazwiskoTextBox
            // 
            this.nazwiskoTextBox.Location = new System.Drawing.Point(111, 46);
            this.nazwiskoTextBox.Name = "nazwiskoTextBox";
            this.nazwiskoTextBox.Size = new System.Drawing.Size(122, 20);
            this.nazwiskoTextBox.TabIndex = 5;
            this.nazwiskoTextBox.TextChanged += new System.EventHandler(this.nazwiskoTextBox_TextChanged);
            // 
            // DaneKlienta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nazwiskoTextBox);
            this.Controls.Add(this.imieTextBox);
            this.Controls.Add(this.nazwiskoLabel);
            this.Controls.Add(this.imieLabel);
            this.Name = "DaneKlienta";
            this.Size = new System.Drawing.Size(245, 78);
            this.Load += new System.EventHandler(this.DaneKlienta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label imieLabel;
        private System.Windows.Forms.Label nazwiskoLabel;
        private System.Windows.Forms.TextBox imieTextBox;
        private System.Windows.Forms.TextBox nazwiskoTextBox;
    }
}
