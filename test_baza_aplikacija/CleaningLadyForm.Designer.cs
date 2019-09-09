namespace NursingHomeApplication
{
    partial class Cistacica
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
            this.text_ime_prezime = new System.Windows.Forms.TextBox();
            this.smjena_label = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.broj_sobe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Krevetnost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odjel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cistacica_dodaj = new System.Windows.Forms.Button();
            this.cistacica_odbaci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // text_ime_prezime
            // 
            this.text_ime_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.text_ime_prezime.Location = new System.Drawing.Point(70, 25);
            this.text_ime_prezime.Name = "text_ime_prezime";
            this.text_ime_prezime.Size = new System.Drawing.Size(245, 29);
            this.text_ime_prezime.TabIndex = 2;
            this.text_ime_prezime.Text = "Ime i prezime";
            this.text_ime_prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // smjena_label
            // 
            this.smjena_label.AutoSize = true;
            this.smjena_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.smjena_label.Location = new System.Drawing.Point(185, 90);
            this.smjena_label.Name = "smjena_label";
            this.smjena_label.Size = new System.Drawing.Size(79, 24);
            this.smjena_label.TabIndex = 3;
            this.smjena_label.Text = "Smjena:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 93);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(85, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.broj_sobe,
            this.Krevetnost,
            this.Odjel});
            this.dataGridView1.Location = new System.Drawing.Point(32, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.Size = new System.Drawing.Size(323, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // broj_sobe
            // 
            this.broj_sobe.HeaderText = "Broj sobe";
            this.broj_sobe.Name = "broj_sobe";
            this.broj_sobe.ReadOnly = true;
            this.broj_sobe.Width = 80;
            // 
            // Krevetnost
            // 
            this.Krevetnost.HeaderText = "Vrsta sobe";
            this.Krevetnost.Name = "Krevetnost";
            this.Krevetnost.ReadOnly = true;
            // 
            // Odjel
            // 
            this.Odjel.HeaderText = "Odjel";
            this.Odjel.Name = "Odjel";
            this.Odjel.ReadOnly = true;
            // 
            // cistacica_dodaj
            // 
            this.cistacica_dodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.cistacica_dodaj.Location = new System.Drawing.Point(38, 331);
            this.cistacica_dodaj.Name = "cistacica_dodaj";
            this.cistacica_dodaj.Size = new System.Drawing.Size(107, 28);
            this.cistacica_dodaj.TabIndex = 6;
            this.cistacica_dodaj.Text = "Dodaj";
            this.cistacica_dodaj.UseVisualStyleBackColor = true;
            // 
            // cistacica_odbaci
            // 
            this.cistacica_odbaci.BackColor = System.Drawing.SystemColors.Control;
            this.cistacica_odbaci.Cursor = System.Windows.Forms.Cursors.Default;
            this.cistacica_odbaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cistacica_odbaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cistacica_odbaci.Location = new System.Drawing.Point(168, 335);
            this.cistacica_odbaci.Name = "cistacica_odbaci";
            this.cistacica_odbaci.Size = new System.Drawing.Size(59, 22);
            this.cistacica_odbaci.TabIndex = 7;
            this.cistacica_odbaci.Text = "Odbaci";
            this.cistacica_odbaci.UseVisualStyleBackColor = false;
            // 
            // Cistacica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 369);
            this.Controls.Add(this.cistacica_odbaci);
            this.Controls.Add(this.cistacica_dodaj);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.smjena_label);
            this.Controls.Add(this.text_ime_prezime);
            this.Name = "Cistacica";
            this.Text = "Cistacica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_ime_prezime;
        private System.Windows.Forms.Label smjena_label;
        protected internal System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn broj_sobe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Krevetnost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odjel;
        private System.Windows.Forms.Button cistacica_dodaj;
        private System.Windows.Forms.Button cistacica_odbaci;
    }
}