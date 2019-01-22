namespace test_baza_aplikacija
{
    partial class djelatnici
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
            this.dodaj = new System.Windows.Forms.Button();
            this.smjene = new System.Windows.Forms.Button();
            this.pregled_poslova = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridDjelatnici = new System.Windows.Forms.DataGridView();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radna_jedinica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mob_broj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dat_zaposljenja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smjena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mjesto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.izbrisi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.place = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDjelatnici)).BeginInit();
            this.SuspendLayout();
            // 
            // dodaj
            // 
            this.dodaj.Location = new System.Drawing.Point(12, 52);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(82, 35);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "Dodaj";
            this.dodaj.UseVisualStyleBackColor = true;
            // 
            // smjene
            // 
            this.smjene.Location = new System.Drawing.Point(439, 2);
            this.smjene.Name = "smjene";
            this.smjene.Size = new System.Drawing.Size(114, 38);
            this.smjene.TabIndex = 1;
            this.smjene.Text = "Pregledaj smjene";
            this.smjene.UseVisualStyleBackColor = true;
            // 
            // pregled_poslova
            // 
            this.pregled_poslova.Location = new System.Drawing.Point(734, 2);
            this.pregled_poslova.Name = "pregled_poslova";
            this.pregled_poslova.Size = new System.Drawing.Size(114, 38);
            this.pregled_poslova.TabIndex = 2;
            this.pregled_poslova.Text = "Pregled poslova";
            this.pregled_poslova.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(734, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(117, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // dataGridDjelatnici
            // 
            this.dataGridDjelatnici.AllowUserToAddRows = false;
            this.dataGridDjelatnici.AllowUserToDeleteRows = false;
            this.dataGridDjelatnici.AllowUserToResizeColumns = false;
            this.dataGridDjelatnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDjelatnici.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ime,
            this.prezime,
            this.radna_jedinica,
            this.mob_broj,
            this.mail,
            this.dat_zaposljenja,
            this.smjena,
            this.mjesto});
            this.dataGridDjelatnici.Location = new System.Drawing.Point(12, 96);
            this.dataGridDjelatnici.Name = "dataGridDjelatnici";
            this.dataGridDjelatnici.ReadOnly = true;
            this.dataGridDjelatnici.RowHeadersWidth = 37;
            this.dataGridDjelatnici.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDjelatnici.Size = new System.Drawing.Size(839, 342);
            this.dataGridDjelatnici.TabIndex = 4;
            // 
            // ime
            // 
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            // 
            // prezime
            // 
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            // 
            // radna_jedinica
            // 
            this.radna_jedinica.HeaderText = "Radna jedinica";
            this.radna_jedinica.Name = "radna_jedinica";
            this.radna_jedinica.ReadOnly = true;
            // 
            // mob_broj
            // 
            this.mob_broj.HeaderText = "Broj mobitela";
            this.mob_broj.Name = "mob_broj";
            this.mob_broj.ReadOnly = true;
            // 
            // mail
            // 
            this.mail.HeaderText = "E-mail";
            this.mail.Name = "mail";
            this.mail.ReadOnly = true;
            // 
            // dat_zaposljenja
            // 
            this.dat_zaposljenja.HeaderText = "Datum zaposlenja";
            this.dat_zaposljenja.Name = "dat_zaposljenja";
            this.dat_zaposljenja.ReadOnly = true;
            // 
            // smjena
            // 
            this.smjena.HeaderText = "Trenutna smjena";
            this.smjena.Name = "smjena";
            this.smjena.ReadOnly = true;
            // 
            // mjesto
            // 
            this.mjesto.HeaderText = "Mjesto stanovanja";
            this.mjesto.Name = "mjesto";
            this.mjesto.ReadOnly = true;
            // 
            // izbrisi
            // 
            this.izbrisi.Location = new System.Drawing.Point(118, 62);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(52, 23);
            this.izbrisi.TabIndex = 5;
            this.izbrisi.Text = "Izbriši";
            this.izbrisi.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(562, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.text_changed);
            // 
            // place
            // 
            this.place.Location = new System.Drawing.Point(588, 2);
            this.place.Name = "place";
            this.place.Size = new System.Drawing.Size(114, 38);
            this.place.TabIndex = 7;
            this.place.Text = "Pregled place";
            this.place.UseVisualStyleBackColor = true;
            // 
            // djelatnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 450);
            this.Controls.Add(this.place);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.dataGridDjelatnici);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pregled_poslova);
            this.Controls.Add(this.smjene);
            this.Controls.Add(this.dodaj);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "djelatnici";
            this.Text = "djelatnici";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDjelatnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.Button smjene;
        private System.Windows.Forms.Button pregled_poslova;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridDjelatnici;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn radna_jedinica;
        private System.Windows.Forms.DataGridViewTextBoxColumn mob_broj;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dat_zaposljenja;
        private System.Windows.Forms.DataGridViewTextBoxColumn smjena;
        private System.Windows.Forms.DataGridViewTextBoxColumn mjesto;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button place;
    }
}