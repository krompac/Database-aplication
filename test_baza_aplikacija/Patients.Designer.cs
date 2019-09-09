namespace NursingHomeApplication
{
    partial class Patients
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.filter = new System.Windows.Forms.TextBox();
            this.izbrisi = new System.Windows.Forms.Button();
            this.dodaj_starca = new System.Windows.Forms.Button();
            this.pokretni = new System.Windows.Forms.CheckBox();
            this.nepokretni = new System.Windows.Forms.CheckBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filter
            // 
            this.filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.filter.Location = new System.Drawing.Point(540, 47);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(156, 31);
            this.filter.TabIndex = 20;
            this.filter.TextChanged += new System.EventHandler(this.DataFilter);
            // 
            // izbrisi
            // 
            this.izbrisi.AccessibleName = "Dodaj";
            this.izbrisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.izbrisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.izbrisi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.izbrisi.Location = new System.Drawing.Point(234, 51);
            this.izbrisi.Name = "izbrisi";
            this.izbrisi.Size = new System.Drawing.Size(50, 29);
            this.izbrisi.TabIndex = 19;
            this.izbrisi.Text = "Izbriši";
            this.izbrisi.UseVisualStyleBackColor = true;
            this.izbrisi.Click += new System.EventHandler(this.DeleteClick);
            // 
            // dodaj_starca
            // 
            this.dodaj_starca.AccessibleName = "Dodaj";
            this.dodaj_starca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dodaj_starca.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dodaj_starca.Location = new System.Drawing.Point(32, 47);
            this.dodaj_starca.Name = "dodaj_starca";
            this.dodaj_starca.Size = new System.Drawing.Size(159, 33);
            this.dodaj_starca.TabIndex = 18;
            this.dodaj_starca.Text = "Dodaj";
            this.dodaj_starca.UseVisualStyleBackColor = true;
            this.dodaj_starca.Click += new System.EventHandler(this.button5_Click);
            // 
            // pokretni
            // 
            this.pokretni.AccessibleName = "Pokretni";
            this.pokretni.AutoSize = true;
            this.pokretni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pokretni.Location = new System.Drawing.Point(739, 21);
            this.pokretni.Name = "pokretni";
            this.pokretni.Size = new System.Drawing.Size(65, 17);
            this.pokretni.TabIndex = 17;
            this.pokretni.Text = "Pokretni";
            this.pokretni.UseVisualStyleBackColor = true;
            this.pokretni.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // nepokretni
            // 
            this.nepokretni.AccessibleName = "Polupokretni";
            this.nepokretni.AutoSize = true;
            this.nepokretni.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nepokretni.Location = new System.Drawing.Point(739, 51);
            this.nepokretni.Name = "nepokretni";
            this.nepokretni.Size = new System.Drawing.Size(103, 17);
            this.nepokretni.TabIndex = 16;
            this.nepokretni.Text = "Polu(ne)pokretni";
            this.nepokretni.UseVisualStyleBackColor = true;
            this.nepokretni.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.ID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(13, 89);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 42;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.Size = new System.Drawing.Size(850, 341);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellClick);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_DoubleCellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ime";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 190;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prezime";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 195;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Datum rođenja";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 105;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Datum useljenja";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 110;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Broj sobe";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 71;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Odjel";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column7.Width = 135;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // starceki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.filter);
            this.Controls.Add(this.izbrisi);
            this.Controls.Add(this.dodaj_starca);
            this.Controls.Add(this.pokretni);
            this.Controls.Add(this.nepokretni);
            this.Controls.Add(this.dataGridView);
            this.Name = "starceki";
            this.Size = new System.Drawing.Size(877, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox filter;
        private System.Windows.Forms.Button izbrisi;
        private System.Windows.Forms.Button dodaj_starca;
        private System.Windows.Forms.CheckBox pokretni;
        private System.Windows.Forms.CheckBox nepokretni;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}
