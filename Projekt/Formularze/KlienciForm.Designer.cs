namespace Projekt.Formularze
{
    partial class KlienciForm
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
            this.nowyKlientButton = new System.Windows.Forms.Button();
            this.klienciListView = new System.Windows.Forms.ListView();
            this.zobaczKlientaButton = new System.Windows.Forms.Button();
            this.wrocButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nowyKlientButton
            // 
            this.nowyKlientButton.BackColor = System.Drawing.Color.White;
            this.nowyKlientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowyKlientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nowyKlientButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.nowyKlientButton.Location = new System.Drawing.Point(67, 328);
            this.nowyKlientButton.Name = "nowyKlientButton";
            this.nowyKlientButton.Size = new System.Drawing.Size(276, 44);
            this.nowyKlientButton.TabIndex = 2;
            this.nowyKlientButton.Text = "Nowy Klient";
            this.nowyKlientButton.UseVisualStyleBackColor = false;
            this.nowyKlientButton.Click += new System.EventHandler(this.nowyKlientButton_Click);
            // 
            // klienciListView
            // 
            this.klienciListView.BackColor = System.Drawing.Color.White;
            this.klienciListView.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.klienciListView.HideSelection = false;
            this.klienciListView.Location = new System.Drawing.Point(67, 39);
            this.klienciListView.MultiSelect = false;
            this.klienciListView.Name = "klienciListView";
            this.klienciListView.Size = new System.Drawing.Size(276, 216);
            this.klienciListView.TabIndex = 3;
            this.klienciListView.UseCompatibleStateImageBehavior = false;
            this.klienciListView.View = System.Windows.Forms.View.Details;
            // 
            // zobaczKlientaButton
            // 
            this.zobaczKlientaButton.BackColor = System.Drawing.Color.White;
            this.zobaczKlientaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zobaczKlientaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zobaczKlientaButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.zobaczKlientaButton.Location = new System.Drawing.Point(67, 278);
            this.zobaczKlientaButton.Name = "zobaczKlientaButton";
            this.zobaczKlientaButton.Size = new System.Drawing.Size(276, 44);
            this.zobaczKlientaButton.TabIndex = 4;
            this.zobaczKlientaButton.Text = "Zobacz Klienta";
            this.zobaczKlientaButton.UseVisualStyleBackColor = false;
            this.zobaczKlientaButton.Click += new System.EventHandler(this.zobaczKlientaButton_Click);
            // 
            // wrocButton
            // 
            this.wrocButton.BackColor = System.Drawing.Color.White;
            this.wrocButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wrocButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wrocButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.wrocButton.Location = new System.Drawing.Point(67, 378);
            this.wrocButton.Name = "wrocButton";
            this.wrocButton.Size = new System.Drawing.Size(276, 44);
            this.wrocButton.TabIndex = 5;
            this.wrocButton.Text = "Powrót";
            this.wrocButton.UseVisualStyleBackColor = false;
            this.wrocButton.Click += new System.EventHandler(this.wrocButton_Click);
            // 
            // KlienciForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.wrocButton);
            this.Controls.Add(this.zobaczKlientaButton);
            this.Controls.Add(this.klienciListView);
            this.Controls.Add(this.nowyKlientButton);
            this.Name = "KlienciForm";
            this.Text = "KlienciForm";
            this.Load += new System.EventHandler(this.KlienciForm_LoadAsync);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nowyKlientButton;
        private System.Windows.Forms.ListView klienciListView;
        private System.Windows.Forms.Button zobaczKlientaButton;
        private System.Windows.Forms.Button wrocButton;
    }
}