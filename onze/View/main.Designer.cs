
namespace onze.View
{
    partial class main
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ltbLeitor = new System.Windows.Forms.ListBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(54, 60);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(245, 15);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Leitor de Texto com Informações Delimitadas";
            // 
            // ltbLeitor
            // 
            this.ltbLeitor.FormattingEnabled = true;
            this.ltbLeitor.ItemHeight = 15;
            this.ltbLeitor.Location = new System.Drawing.Point(54, 125);
            this.ltbLeitor.Name = "ltbLeitor";
            this.ltbLeitor.Size = new System.Drawing.Size(245, 169);
            this.ltbLeitor.TabIndex = 1;
            // 
            // btnLer
            // 
            this.btnLer.Location = new System.Drawing.Point(224, 94);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(75, 23);
            this.btnLer.TabIndex = 2;
            this.btnLer.Text = "Ler";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.ltbLeitor);
            this.Controls.Add(this.lblTitulo);
            this.Name = "main";
            this.Text = "main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox ltbLeitor;
        private System.Windows.Forms.Button btnLer;
    }
}