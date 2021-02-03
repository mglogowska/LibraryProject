namespace Projekt.Formularze
{
    partial class WypozyczeniaForm
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
            this.klienciwypozListView = new System.Windows.Forms.ListView();
            this.zobaczWypozyczeniaButton = new System.Windows.Forms.Button();
            this.wrocButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // klienciwypozListView
            // 
            this.klienciwypozListView.BackColor = System.Drawing.Color.White;
            this.klienciwypozListView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.klienciwypozListView.HideSelection = false;
            this.klienciwypozListView.Location = new System.Drawing.Point(70, 8);
            this.klienciwypozListView.MultiSelect = false;
            this.klienciwypozListView.Name = "klienciwypozListView";
            this.klienciwypozListView.Size = new System.Drawing.Size(276, 216);
            this.klienciwypozListView.TabIndex = 4;
            this.klienciwypozListView.UseCompatibleStateImageBehavior = false;
            this.klienciwypozListView.View = System.Windows.Forms.View.Details;
            this.klienciwypozListView.SelectedIndexChanged += new System.EventHandler(this.klienciwypozListView_SelectedIndexChanged);
            // 
            // zobaczWypozyczeniaButton
            // 
            this.zobaczWypozyczeniaButton.BackColor = System.Drawing.Color.White;
            this.zobaczWypozyczeniaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zobaczWypozyczeniaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zobaczWypozyczeniaButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.zobaczWypozyczeniaButton.Location = new System.Drawing.Point(70, 242);
            this.zobaczWypozyczeniaButton.Name = "zobaczWypozyczeniaButton";
            this.zobaczWypozyczeniaButton.Size = new System.Drawing.Size(276, 44);
            this.zobaczWypozyczeniaButton.TabIndex = 5;
            this.zobaczWypozyczeniaButton.Text = "Zobacz Wypożyczenia";
            this.zobaczWypozyczeniaButton.UseVisualStyleBackColor = false;
            this.zobaczWypozyczeniaButton.Click += new System.EventHandler(this.zobaczWypozyczeniaButton_Click);
            // 
            // wrocButton
            // 
            this.wrocButton.BackColor = System.Drawing.Color.White;
            this.wrocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrocButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wrocButton.Location = new System.Drawing.Point(70, 301);
            this.wrocButton.Name = "wrocButton";
            this.wrocButton.Size = new System.Drawing.Size(276, 44);
            this.wrocButton.TabIndex = 6;
            this.wrocButton.Text = "Powrót";
            this.wrocButton.UseVisualStyleBackColor = false;
            this.wrocButton.Click += new System.EventHandler(this.wrocButton_Click);
            // 
            // WypozyczeniaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 401);
            this.Controls.Add(this.wrocButton);
            this.Controls.Add(this.zobaczWypozyczeniaButton);
            this.Controls.Add(this.klienciwypozListView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "WypozyczeniaForm";
            this.Text = "WypozyczeniaForm";
            this.Load += new System.EventHandler(this.WypozyczeniaForm_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView klienciwypozListView;
        private System.Windows.Forms.Button zobaczWypozyczeniaButton;
        private System.Windows.Forms.Button wrocButton;
    }
}