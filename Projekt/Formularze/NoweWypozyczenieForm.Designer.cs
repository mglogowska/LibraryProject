namespace Projekt.Formularze
{
    partial class NoweWypozyczenieForm
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
            this.ksiazkiListView = new System.Windows.Forms.ListView();
            this.wypozyczButton = new System.Windows.Forms.Button();
            this.wrocButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ksiazkiListView
            // 
            this.ksiazkiListView.BackColor = System.Drawing.Color.White;
            this.ksiazkiListView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ksiazkiListView.HideSelection = false;
            this.ksiazkiListView.Location = new System.Drawing.Point(35, 22);
            this.ksiazkiListView.MultiSelect = false;
            this.ksiazkiListView.Name = "ksiazkiListView";
            this.ksiazkiListView.Size = new System.Drawing.Size(276, 216);
            this.ksiazkiListView.TabIndex = 5;
            this.ksiazkiListView.UseCompatibleStateImageBehavior = false;
            this.ksiazkiListView.View = System.Windows.Forms.View.Details;
            // 
            // wypozyczButton
            // 
            this.wypozyczButton.BackColor = System.Drawing.Color.White;
            this.wypozyczButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wypozyczButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wypozyczButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wypozyczButton.Location = new System.Drawing.Point(35, 266);
            this.wypozyczButton.Name = "wypozyczButton";
            this.wypozyczButton.Size = new System.Drawing.Size(276, 44);
            this.wypozyczButton.TabIndex = 6;
            this.wypozyczButton.Text = "Wypożycz";
            this.wypozyczButton.UseVisualStyleBackColor = false;
            this.wypozyczButton.Click += new System.EventHandler(this.wypozyczButton_ClickAsync);
            // 
            // wrocButton
            // 
            this.wrocButton.BackColor = System.Drawing.Color.White;
            this.wrocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrocButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wrocButton.Location = new System.Drawing.Point(35, 333);
            this.wrocButton.Name = "wrocButton";
            this.wrocButton.Size = new System.Drawing.Size(276, 44);
            this.wrocButton.TabIndex = 7;
            this.wrocButton.Text = "Zamknij";
            this.wrocButton.UseVisualStyleBackColor = false;
            this.wrocButton.Click += new System.EventHandler(this.wrocButton_Click);
            // 
            // NoweWypozyczenieForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 438);
            this.Controls.Add(this.wrocButton);
            this.Controls.Add(this.wypozyczButton);
            this.Controls.Add(this.ksiazkiListView);
            this.Name = "NoweWypozyczenieForm";
            this.Text = "NoweWypozyczenieForm";
            this.Load += new System.EventHandler(this.NoweWypozyczenieForm_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ksiazkiListView;
        private System.Windows.Forms.Button wypozyczButton;
        private System.Windows.Forms.Button wrocButton;
    }
}