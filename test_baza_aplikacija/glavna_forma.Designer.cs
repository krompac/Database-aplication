using System.Windows.Forms;

namespace test_baza_aplikacija
{
    partial class glavna_forma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(glavna_forma));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.natrag = new System.Windows.Forms.Button();
            this.starceki_gumb = new System.Windows.Forms.Button();
            this.sobe_gumb = new System.Windows.Forms.Button();
            this.djelatnici_gumb = new System.Windows.Forms.Button();
            this.sobe_uc1 = new test_baza_aplikacija.Sobe();
            this.starceki1 = new test_baza_aplikacija.starceki();
            this.djelatnik1 = new test_baza_aplikacija.djelatnik();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanel1.Controls.Add(this.natrag);
            this.flowLayoutPanel1.Controls.Add(this.starceki_gumb);
            this.flowLayoutPanel1.Controls.Add(this.sobe_gumb);
            this.flowLayoutPanel1.Controls.Add(this.djelatnici_gumb);
            resources.ApplyResources(this.flowLayoutPanel1, "flowLayoutPanel1");
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // natrag
            // 
            resources.ApplyResources(this.natrag, "natrag");
            this.natrag.Name = "natrag";
            this.natrag.UseVisualStyleBackColor = true;
            this.natrag.Click += new System.EventHandler(this.natrag_Click);
            // 
            // starceki_gumb
            // 
            resources.ApplyResources(this.starceki_gumb, "starceki_gumb");
            this.starceki_gumb.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.starceki_gumb.Name = "starceki_gumb";
            this.starceki_gumb.UseVisualStyleBackColor = true;
            this.starceki_gumb.Click += new System.EventHandler(this.button1_Click);
            // 
            // sobe_gumb
            // 
            resources.ApplyResources(this.sobe_gumb, "sobe_gumb");
            this.sobe_gumb.Name = "sobe_gumb";
            this.sobe_gumb.UseVisualStyleBackColor = true;
            this.sobe_gumb.Click += new System.EventHandler(this.sobe_Click);
            // 
            // djelatnici_gumb
            // 
            resources.ApplyResources(this.djelatnici_gumb, "djelatnici_gumb");
            this.djelatnici_gumb.Name = "djelatnici_gumb";
            this.djelatnici_gumb.UseVisualStyleBackColor = true;
            this.djelatnici_gumb.Click += new System.EventHandler(this.djelatnici_Click);
            // 
            // sobe_uc1
            // 
            resources.ApplyResources(this.sobe_uc1, "sobe_uc1");
            this.sobe_uc1.Name = "sobe_uc1";
            // 
            // starceki1
            // 
            resources.ApplyResources(this.starceki1, "starceki1");
            this.starceki1.Name = "starceki1";
            // 
            // djelatnik1
            // 
            resources.ApplyResources(this.djelatnik1, "djelatnik1");
            this.djelatnik1.Name = "djelatnik1";
            // 
            // glavna_forma
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.djelatnik1);
            this.Controls.Add(this.sobe_uc1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.starceki1);
            this.Name = "glavna_forma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_FormClosing);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private Button starceki_gumb;
        private Button djelatnici_gumb;
        private Button sobe_gumb;
        private Button natrag;
        private starceki starceki1;
        private Sobe sobe_uc1;
        private djelatnik djelatnik1;
    }
}