
namespace prjWinCsAdoReview
{
    partial class frmDatasetStatic
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
            ((System.ComponentModel.ISupportInitialize)(this.gridResultat)).BeginInit();
            this.SuspendLayout();
            // 
            // gridResultat
            // 
            this.gridResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridResultat.Location = new System.Drawing.Point(195, 79);
            this.gridResultat.Name = "gridResultat";
            this.gridResultat.RowHeadersWidth = 51;
            this.gridResultat.RowTemplate.Height = 24;
            this.gridResultat.Size = new System.Drawing.Size(566, 252);
            this.gridResultat.TabIndex = 0;
            this.gridResultat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridResultat_CellContentClick);
            // 
            // frmDatasetStatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridResultat);
            this.Name = "frmDatasetStatic";
            this.Text = "frmDatasetStatic";
            this.Load += new System.EventHandler(this.frmDatasetStatic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridResultat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridResultat;
    }
}