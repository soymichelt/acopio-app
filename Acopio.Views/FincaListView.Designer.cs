namespace Acopio.Views
{
    partial class FincaListView
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
            this.fincasDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.nRegistrosTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edicionFincaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fincasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // fincasDataGridView
            // 
            this.fincasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fincasDataGridView.Location = new System.Drawing.Point(12, 54);
            this.fincasDataGridView.Name = "fincasDataGridView";
            this.fincasDataGridView.Size = new System.Drawing.Size(776, 384);
            this.fincasDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(605, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar:";
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Location = new System.Drawing.Point(654, 28);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(134, 20);
            this.buscarTextBox.TabIndex = 2;
            // 
            // nRegistrosTextBox
            // 
            this.nRegistrosTextBox.BackColor = System.Drawing.Color.White;
            this.nRegistrosTextBox.Location = new System.Drawing.Point(84, 28);
            this.nRegistrosTextBox.Name = "nRegistrosTextBox";
            this.nRegistrosTextBox.ReadOnly = true;
            this.nRegistrosTextBox.Size = new System.Drawing.Size(108, 20);
            this.nRegistrosTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "N° Registros:";
            // 
            // edicionFincaButton
            // 
            this.edicionFincaButton.Location = new System.Drawing.Point(198, 26);
            this.edicionFincaButton.Name = "edicionFincaButton";
            this.edicionFincaButton.Size = new System.Drawing.Size(126, 23);
            this.edicionFincaButton.TabIndex = 5;
            this.edicionFincaButton.Text = "Edición de Fincas";
            this.edicionFincaButton.UseVisualStyleBackColor = true;
            this.edicionFincaButton.Click += new System.EventHandler(this.edicionFincaButton_Click);
            // 
            // FincaListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.edicionFincaButton);
            this.Controls.Add(this.nRegistrosTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buscarTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fincasDataGridView);
            this.KeyPreview = true;
            this.Name = "FincaListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Fincas";
            this.Load += new System.EventHandler(this.FincaListView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fincasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView fincasDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.TextBox nRegistrosTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button edicionFincaButton;
    }
}