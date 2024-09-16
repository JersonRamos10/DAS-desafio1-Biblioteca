namespace Biblioteca
{
    partial class FormGraficos
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
            panelLibrosMasPrestados = new Panel();
            panelUsuarioMasPrestador = new Panel();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // panelLibrosMasPrestados
            // 
            panelLibrosMasPrestados.Location = new Point(155, 146);
            panelLibrosMasPrestados.Name = "panelLibrosMasPrestados";
            panelLibrosMasPrestados.Size = new Size(349, 262);
            panelLibrosMasPrestados.TabIndex = 0;
            // 
            // panelUsuarioMasPrestador
            // 
            panelUsuarioMasPrestador.Location = new Point(645, 139);
            panelUsuarioMasPrestador.Name = "panelUsuarioMasPrestador";
            panelUsuarioMasPrestador.Size = new Size(284, 280);
            panelUsuarioMasPrestador.TabIndex = 1;
            // 
            // backgroundWorker1
            //  
            // 
            // FormGraficos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 35, 38);
            ClientSize = new Size(1056, 522);
            Controls.Add(panelUsuarioMasPrestador);
            Controls.Add(panelLibrosMasPrestados);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormGraficos";
            Text = "FormGraficos";
            Load += FormGraficos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLibrosMasPrestados;
        private Panel panelUsuarioMasPrestador;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}