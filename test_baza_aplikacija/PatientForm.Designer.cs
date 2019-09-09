namespace NursingHomeApplication
{
    partial class PatientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientForm));
            this.slika = new System.Windows.Forms.PictureBox();
            this.unos_ime = new System.Windows.Forms.Label();
            this.unos_prezime = new System.Windows.Forms.Label();
            this.textIme = new System.Windows.Forms.TextBox();
            this.textPrezime = new System.Windows.Forms.TextBox();
            this.unos_god_rodjenja = new System.Windows.Forms.Label();
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
            this.kontakt_tel = new System.Windows.Forms.TextBox();
            this.kontak_osoba = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dat_rodjenja = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slika
            // 
            resources.ApplyResources(this.slika, "slika");
            this.slika.Name = "slika";
            this.slika.TabStop = false;
            // 
            // unos_ime
            // 
            resources.ApplyResources(this.unos_ime, "unos_ime");
            this.unos_ime.Name = "unos_ime";
            // 
            // unos_prezime
            // 
            resources.ApplyResources(this.unos_prezime, "unos_prezime");
            this.unos_prezime.Name = "unos_prezime";
            // 
            // textIme
            // 
            resources.ApplyResources(this.textIme, "textIme");
            this.textIme.Name = "textIme";
            // 
            // textPrezime
            // 
            resources.ApplyResources(this.textPrezime, "textPrezime");
            this.textPrezime.Name = "textPrezime";
            // 
            // unos_god_rodjenja
            // 
            resources.ApplyResources(this.unos_god_rodjenja, "unos_god_rodjenja");
            this.unos_god_rodjenja.Name = "unos_god_rodjenja";
            // 
            // unos_datum_useljenja
            // 
            resources.ApplyResources(this.unos_datum_useljenja, "unos_datum_useljenja");
            this.unos_datum_useljenja.Name = "unos_datum_useljenja";
            // 
            // dat_useljenja
            // 
            resources.ApplyResources(this.dat_useljenja, "dat_useljenja");
            this.dat_useljenja.Name = "dat_useljenja";
            // 
            // unos_spol
            // 
            resources.ApplyResources(this.unos_spol, "unos_spol");
            this.unos_spol.Name = "unos_spol";
            // 
            // textSpol
            // 
            resources.ApplyResources(this.textSpol, "textSpol");
            this.textSpol.Name = "textSpol";
            this.textSpol.TextChanged += new System.EventHandler(this.textBox3_SpolChanged);
            // 
            // checkDijabeticar
            // 
            resources.ApplyResources(this.checkDijabeticar, "checkDijabeticar");
            this.checkDijabeticar.Name = "checkDijabeticar";
            this.checkDijabeticar.UseVisualStyleBackColor = true;
            // 
            // unos_dijabeticar
            // 
            resources.ApplyResources(this.unos_dijabeticar, "unos_dijabeticar");
            this.unos_dijabeticar.Name = "unos_dijabeticar";
            // 
            // unos_broj_sobe
            // 
            resources.ApplyResources(this.unos_broj_sobe, "unos_broj_sobe");
            this.unos_broj_sobe.Name = "unos_broj_sobe";
            // 
            // comboSoba
            // 
            resources.ApplyResources(this.comboSoba, "comboSoba");
            this.comboSoba.FormattingEnabled = true;
            this.comboSoba.Name = "comboSoba";
            // 
            // gumb_dodaj
            // 
            resources.ApplyResources(this.gumb_dodaj, "gumb_dodaj");
            this.gumb_dodaj.Name = "gumb_dodaj";
            this.gumb_dodaj.UseVisualStyleBackColor = true;
            this.gumb_dodaj.Click += new System.EventHandler(this.button1_Click);
            // 
            // gumb_odbaci
            // 
            resources.ApplyResources(this.gumb_odbaci, "gumb_odbaci");
            this.gumb_odbaci.Cursor = System.Windows.Forms.Cursors.Default;
            this.gumb_odbaci.Name = "gumb_odbaci";
            this.gumb_odbaci.UseVisualStyleBackColor = true;
            this.gumb_odbaci.Click += new System.EventHandler(this.gumb_odbaci_Click);
            // 
            // kontakt_tel
            // 
            resources.ApplyResources(this.kontakt_tel, "kontakt_tel");
            this.kontakt_tel.Name = "kontakt_tel";
            // 
            // kontak_osoba
            // 
            resources.ApplyResources(this.kontak_osoba, "kontak_osoba");
            this.kontak_osoba.Name = "kontak_osoba";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.kontakt_tel);
            this.groupBox1.Controls.Add(this.kontak_osoba);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // dat_rodjenja
            // 
            resources.ApplyResources(this.dat_rodjenja, "dat_rodjenja");
            this.dat_rodjenja.Name = "dat_rodjenja";
            // 
            // PatientForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dat_rodjenja);
            this.Controls.Add(this.groupBox1);
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
            this.Controls.Add(this.unos_god_rodjenja);
            this.Controls.Add(this.textPrezime);
            this.Controls.Add(this.textIme);
            this.Controls.Add(this.unos_prezime);
            this.Controls.Add(this.unos_ime);
            this.Controls.Add(this.slika);
            this.Name = "PatientForm";
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox kontakt_tel;
        private System.Windows.Forms.TextBox kontak_osoba;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dat_rodjenja;
    }
}