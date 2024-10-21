namespace Gestión_Museo
{
    partial class FrmUsuarioFinal
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
            this.grpInformacionPinturas = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.grpInformacionPinturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpInformacionPinturas
            // 
            this.grpInformacionPinturas.Controls.Add(this.treeView1);
            this.grpInformacionPinturas.Controls.Add(this.btnAnterior);
            this.grpInformacionPinturas.Controls.Add(this.btnSiguiente);
            this.grpInformacionPinturas.Controls.Add(this.pictureBox1);
            this.grpInformacionPinturas.Location = new System.Drawing.Point(26, 80);
            this.grpInformacionPinturas.Name = "grpInformacionPinturas";
            this.grpInformacionPinturas.Size = new System.Drawing.Size(676, 402);
            this.grpInformacionPinturas.TabIndex = 0;
            this.grpInformacionPinturas.TabStop = false;
            this.grpInformacionPinturas.Text = "Información Pinturas";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(349, 19);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(302, 328);
            this.treeView1.TabIndex = 4;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(52, 325);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(94, 22);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "Pintura Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(215, 325);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(98, 22);
            this.btnSiguiente.TabIndex = 1;
            this.btnSiguiente.Text = "Siguiente Pintura";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(52, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 290);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(494, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(602, 38);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = "Lupa";
            // 
            // FrmUsuarioFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 494);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grpInformacionPinturas);
            this.Name = "FrmUsuarioFinal";
            this.Text = "Form3";
            this.grpInformacionPinturas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInformacionPinturas;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TreeView treeView1;
    }
}