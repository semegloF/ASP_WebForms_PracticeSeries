
namespace prjWinCsAdoReview
{
    partial class frmRecherche
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
            this.gridResultat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkCours = new System.Windows.Forms.CheckBox();
            this.chkMoyenne = new System.Windows.Forms.CheckBox();
            this.cboCours = new System.Windows.Forms.ComboBox();
            this.cboMoyennes = new System.Windows.Forms.ComboBox();
            this.btnTrouver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridResultat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridResultat
            // 
            this.gridResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultat.Location = new System.Drawing.Point(53, 245);
            this.gridResultat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridResultat.Name = "gridResultat";
            this.gridResultat.RowHeadersWidth = 51;
            this.gridResultat.RowTemplate.Height = 24;
            this.gridResultat.Size = new System.Drawing.Size(700, 150);
            this.gridResultat.TabIndex = 0;
            this.gridResultat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultat_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "RECHERCHE-ETUDIANTS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTrouver);
            this.groupBox1.Controls.Add(this.cboMoyennes);
            this.groupBox1.Controls.Add(this.cboCours);
            this.groupBox1.Controls.Add(this.chkMoyenne);
            this.groupBox1.Controls.Add(this.chkCours);
            this.groupBox1.Location = new System.Drawing.Point(53, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 134);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Critères de Recherche";
            // 
            // chkCours
            // 
            this.chkCours.AutoSize = true;
            this.chkCours.Location = new System.Drawing.Point(83, 22);
            this.chkCours.Name = "chkCours";
            this.chkCours.Size = new System.Drawing.Size(93, 21);
            this.chkCours.TabIndex = 0;
            this.chkCours.Text = "Par Cours";
            this.chkCours.UseVisualStyleBackColor = true;
            // 
            // chkMoyenne
            // 
            this.chkMoyenne.AutoSize = true;
            this.chkMoyenne.Location = new System.Drawing.Point(83, 68);
            this.chkMoyenne.Name = "chkMoyenne";
            this.chkMoyenne.Size = new System.Drawing.Size(186, 21);
            this.chkMoyenne.TabIndex = 1;
            this.chkMoyenne.Text = "Moyenne Supperieure à ";
            this.chkMoyenne.UseVisualStyleBackColor = true;
            // 
            // cboCours
            // 
            this.cboCours.FormattingEnabled = true;
            this.cboCours.Location = new System.Drawing.Point(331, 22);
            this.cboCours.Name = "cboCours";
            this.cboCours.Size = new System.Drawing.Size(121, 24);
            this.cboCours.TabIndex = 2;
            // 
            // cboMoyennes
            // 
            this.cboMoyennes.FormattingEnabled = true;
            this.cboMoyennes.Location = new System.Drawing.Point(331, 68);
            this.cboMoyennes.Name = "cboMoyennes";
            this.cboMoyennes.Size = new System.Drawing.Size(121, 24);
            this.cboMoyennes.TabIndex = 3;
            // 
            // btnTrouver
            // 
            this.btnTrouver.Location = new System.Drawing.Point(529, 22);
            this.btnTrouver.Name = "btnTrouver";
            this.btnTrouver.Size = new System.Drawing.Size(94, 70);
            this.btnTrouver.TabIndex = 4;
            this.btnTrouver.Text = "Trouver";
            this.btnTrouver.UseVisualStyleBackColor = true;
            this.btnTrouver.Click += new System.EventHandler(this.btnTrouver_Click);
            // 
            // frmRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridResultat);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmRecherche";
            this.Text = "frmRecherche";
            ((System.ComponentModel.ISupportInitialize)(this.gridResultat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResultat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMoyennes;
        private System.Windows.Forms.ComboBox cboCours;
        private System.Windows.Forms.CheckBox chkMoyenne;
        private System.Windows.Forms.CheckBox chkCours;
        private System.Windows.Forms.Button btnTrouver;
    }
}