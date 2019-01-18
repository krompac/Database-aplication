namespace test_baza_aplikacija
{
    partial class StarcekAU
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
            this.slika = new System.Windows.Forms.PictureBox();
            this.unos_ime = new System.Windows.Forms.Label();
            this.unos_prezime = new System.Windows.Forms.Label();
            this.textIme = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.unos_god_rodjenja = new System.Windows.Forms.Label();
            this.textGodRodjenja = new System.Windows.Forms.TextBox();
            this.unos_datum_useljenja = new System.Windows.Forms.Label();
            this.dat_useljenja = new System.Windows.Forms.DateTimePicker();
            this.unos_spol = new System.Windows.Forms.Label();
            this.textSpol = new System.Windows.Forms.TextBox();
            this.checkDijabeticar = new System.Windows.Forms.CheckBox();
            this.unos_dijabeticar = new System.Windows.Forms.Label();
            this.unos_broj_sobe = new System.Windows.Forms.Label();
            this.comboSoba = new System.Windows.Forms.ComboBox();
            this.gumb_dodaj = new System.Windows.Forms.Button();
            this.gumb_odbaci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // slika
            // 
            this.slika.AccessibleName = "";
            this.slika.Location = new System.Drawing.Point(27, 27);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(166, 138);
            this.slika.TabIndex = 0;
            this.slika.TabStop = false;
            // 
            // unos_ime
            // 
            this.unos_ime.AccessibleName = "";
            this.unos_ime.AutoSize = true;
            this.unos_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unos_ime.Location = new System.Drawing.Point(234, 45);
            this.unos_ime.Name = "unos_ime";
            this.unos_ime.Size = new System.Drawing.Size(36, 20);
            this.unos_ime.TabIndex = 1;
            this.unos_ime.Text = "Ime";
            // 
            // unos_prezime
            // 
            this.unos_prezime.AccessibleName = "";
            this.unos_prezime.AutoSize = true;
            this.unos_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unos_prezime.Location = new System.Drawing.Point(234, 108);
            this.unos_prezime.Name = "unos_prezime";
            this.unos_prezime.Size = new System.Drawing.Size(66, 20);
            this.unos_prezime.TabIndex = 2;
            this.unos_prezime.Text = "Prezime";
            // 
            // textIme
            // 
            this.textIme.AccessibleName = "unos_ime";
            this.textIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textIme.Location = new System.Drawing.Point(327, 42);
            this.textIme.Name = "textIme";
            this.textIme.Size = new System.Drawing.Size(129, 26);
            this.textIme.TabIndex = 3;
            // 
            // textPrezime
            // 
            this.textPrezime.AccessibleName = "unos_prezime";
            this.textPrezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPrezime.Location = new System.Drawing.Point(327, 105);
            this.textPrezime.Name = "textPrezime";
            this.textPrezime.Size = new System.Drawing.Size(129, 26);
            this.textPrezime.TabIndex = 4;
            // 
            // unos_god_rodjenja
            // 
            this.unos_god_rodjenja.AccessibleName = "";
            this.unos_god_rodjenja.AutoSize = true;
            this.unos_god_rodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unos_god_rodjenja.Location = new System.Drawing.Point(42, 214);
            this.unos_god_rodjenja.Name = "unos_god_rodjenja";
            this.unos_god_rodjenja.Size = new System.Drawing.Size(118, 20);
            this.unos_god_rodjenja.TabIndex = 5;
            this.unos_god_rodjenja.Text = "Godina rođenja";
            // 
            // textGodRodjenja
            // 
            this.textGodRodjenja.AccessibleName = "unos_god_rodjenja";
            this.textGodRodjenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textGodRodjenja.Location = new System.Drawing.Point(190, 216);
            this.textGodRodjenja.Name = "textGodRodjenja";
            this.textGodRodjenja.Size = new System.Drawing.Size(129, 26);
            this.textGodRodjenja.TabIndex = 6;
            this.textGodRodjenja.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textSpol.TextChanged += new System.EventHandler(this.textBox3_SpolChanged);
            // 
            // unos_datum_useljenja
            // 
            this.unos_datum_useljenja.AccessibleName = "";
            this.unos_datum_useljenja.AutoSize = true;
            this.unos_datum_useljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unos_datum_useljenja.Location = new System.Drawing.Point(42, 265);
            this.unos_datum_useljenja.Name = "unos_datum_useljenja";
            this.unos_datum_useljenja.Size = new System.Drawing.Size(123, 20);
            this.unos_datum_useljenja.TabIndex = 7;
            this.unos_datum_useljenja.Text = "Datum useljenja";
            // 
            // dat_useljenja
            // 
            this.dat_useljenja.AccessibleName = "unos_dat_useljenja";
            this.dat_useljenja.CustomFormat = "dd-MM-yyy";
            this.dat_useljenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dat_useljenja.Location = new System.Drawing.Point(190, 265);
            this.dat_useljenja.Name = "dat_useljenja";
            this.dat_useljenja.Size = new System.Drawing.Size(294, 26);
            this.dat_useljenja.TabIndex = 0;
            // 
            // unos_spol
            // 
            this.unos_spol.AccessibleName = "unos_spol";
            this.unos_spol.AutoSize = true;
            this.unos_spol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unos_spol.Location = new System.Drawing.Point(42, 311);
            this.unos_spol.Name = "unos_spol";
            this.unos_spol.Size = new System.Drawing.Size(41, 20);
            this.unos_spol.TabIndex = 8;
            this.unos_spol.Text = "Spol";
            // 
            // textSpol
            // 
            this.textSpol.AccessibleName = "unos_spol";
            this.textSpol.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSpol.Location = new System.Drawing.Point(190, 311);
            this.textSpol.MaxLength = 1;
            this.textSpol.Name = "textSpol";
            this.textSpol.Size = new System.Drawing.Size(73, 26);
            this.textSpol.TabIndex = 9;
            // 
            // checkDijabeticar
            // 
            this.checkDijabeticar.AccessibleName = "unos_diabeticar";
            this.checkDijabeticar.AutoSize = true;
            this.checkDijabeticar.Location = new System.Drawing.Point(190, 359);
            this.checkDijabeticar.Name = "checkDijabeticar";
            this.checkDijabeticar.Size = new System.Drawing.Size(15, 14);
            this.checkDijabeticar.TabIndex = 10;
            this.checkDijabeticar.UseVisualStyleBackColor = true;
            // 
            // unos_dijabeticar
            // 
            this.unos_dijabeticar.AccessibleName = "unos_dijabeticar";
            this.unos_dijabeticar.AutoSize = true;
            this.unos_dijabeticar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unos_dijabeticar.Location = new System.Drawing.Point(42, 354);
            this.unos_dijabeticar.Name = "unos_dijabeticar";
            this.unos_dijabeticar.Size = new System.Drawing.Size(84, 20);
            this.unos_dijabeticar.TabIndex = 11;
            this.unos_dijabeticar.Text = "Dijabetičar";
            // 
            // unos_broj_sobe
            // 
            this.unos_broj_sobe.AccessibleName = "unos_broj_sobe";
            this.unos_broj_sobe.AutoSize = true;
            this.unos_broj_sobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unos_broj_sobe.Location = new System.Drawing.Point(42, 403);
            this.unos_broj_sobe.Name = "unos_broj_sobe";
            this.unos_broj_sobe.Size = new System.Drawing.Size(76, 20);
            this.unos_broj_sobe.TabIndex = 12;
            this.unos_broj_sobe.Text = "Broj sobe";
            // 
            // comboSoba
            // 
            this.comboSoba.AccessibleName = "unos_broj_sobe";
            this.comboSoba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSoba.FormattingEnabled = true;
            this.comboSoba.Location = new System.Drawing.Point(190, 395);
            this.comboSoba.Name = "comboSoba";
            this.comboSoba.Size = new System.Drawing.Size(266, 28);
            this.comboSoba.TabIndex = 13;
            this.comboSoba.Text = "c";
            // 
            // gumb_dodaj
            // 
            this.gumb_dodaj.AccessibleName = "";
            this.gumb_dodaj.Location = new System.Drawing.Point(35, 469);
            this.gumb_dodaj.Name = "gumb_dodaj";
            this.gumb_dodaj.Size = new System.Drawing.Size(138, 36);
            this.gumb_dodaj.TabIndex = 14;
            this.gumb_dodaj.Text = "Dodaj";
            this.gumb_dodaj.UseVisualStyleBackColor = true;
            this.gumb_dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // gumb_odbaci
            // 
            this.gumb_odbaci.AccessibleName = "";
            this.gumb_odbaci.Cursor = System.Windows.Forms.Cursors.Default;
            this.gumb_odbaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gumb_odbaci.Location = new System.Drawing.Point(212, 474);
            this.gumb_odbaci.Margin = new System.Windows.Forms.Padding(0);
            this.gumb_odbaci.Name = "gumb_odbaci";
            this.gumb_odbaci.Size = new System.Drawing.Size(58, 27);
            this.gumb_odbaci.TabIndex = 15;
            this.gumb_odbaci.Text = "Odbaci";
            this.gumb_odbaci.UseVisualStyleBackColor = true;
            this.gumb_odbaci.Click += new System.EventHandler(this.gumb_odbaci_Click);
            // 
            // StarcekAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 518);
            this.Controls.Add(this.gumb_odbaci);
            this.Controls.Add(this.gumb_dodaj);
            this.Controls.Add(this.comboSoba);
            this.Controls.Add(this.unos_broj_sobe);
            this.Controls.Add(this.unos_dijabeticar);
            this.Controls.Add(this.checkDijabeticar);
            this.Controls.Add(this.textSpol);
            this.Controls.Add(this.unos_spol);
            this.Controls.Add(this.dat_useljenja);
            this.Controls.Add(this.unos_datum_useljenja);
            this.Controls.Add(this.textGodRodjenja);
            this.Controls.Add(this.unos_god_rodjenja);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.unos_prezime);
            this.Controls.Add(this.unos_ime);
            this.Controls.Add(this.slika);
            this.Name = "StarcekAU";
            this.Text = "StarcekAU";
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox slika;
        private System.Windows.Forms.Label unos_ime;
        private System.Windows.Forms.Label unos_prezime;
        private System.Windows.Forms.TextBox textIme;
        private System.Windows.Forms.TextBox textPrezime;
        private System.Windows.Forms.Label unos_god_rodjenja;
        private System.Windows.Forms.TextBox textGodRodjenja;
        private System.Windows.Forms.Label unos_datum_useljenja;
        private System.Windows.Forms.DateTimePicker dat_useljenja;
        private System.Windows.Forms.Label unos_spol;
        private System.Windows.Forms.TextBox textSpol;
        private System.Windows.Forms.CheckBox checkDijabeticar;
        private System.Windows.Forms.Label unos_dijabeticar;
        private System.Windows.Forms.Label unos_broj_sobe;
        private System.Windows.Forms.ComboBox comboSoba;
        private System.Windows.Forms.Button gumb_dodaj;
        private System.Windows.Forms.Button gumb_odbaci;
    }
}