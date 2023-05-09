namespace LogBook.View
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioDeBorodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatótioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioDeBordoPorTurmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diárioDeBordoPorAlunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.diárioDeBorodoToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // diárioDeBorodoToolStripMenuItem
            // 
            this.diárioDeBorodoToolStripMenuItem.Name = "diárioDeBorodoToolStripMenuItem";
            this.diárioDeBorodoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.diárioDeBorodoToolStripMenuItem.Text = "Diário de Borodo";
            this.diárioDeBorodoToolStripMenuItem.Click += new System.EventHandler(this.diárioDeBorodoToolStripMenuItem_Click);
            // 
            // relatótioToolStripMenuItem
            // 
            this.relatótioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diárioDeBordoPorTurmaToolStripMenuItem,
            this.diárioDeBordoPorAlunoToolStripMenuItem});
            this.relatótioToolStripMenuItem.Name = "relatótioToolStripMenuItem";
            this.relatótioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatótioToolStripMenuItem.Text = "Relatótio";
            // 
            // diárioDeBordoPorTurmaToolStripMenuItem
            // 
            this.diárioDeBordoPorTurmaToolStripMenuItem.Name = "diárioDeBordoPorTurmaToolStripMenuItem";
            this.diárioDeBordoPorTurmaToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.diárioDeBordoPorTurmaToolStripMenuItem.Text = "Diário de Bordo por Turma";
            // 
            // diárioDeBordoPorAlunoToolStripMenuItem
            // 
            this.diárioDeBordoPorAlunoToolStripMenuItem.Name = "diárioDeBordoPorAlunoToolStripMenuItem";
            this.diárioDeBordoPorAlunoToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.diárioDeBordoPorAlunoToolStripMenuItem.Text = "Diário de Bordo por Aluno";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.relatótioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Administrador do Sistema";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioDeBorodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatótioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioDeBordoPorTurmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diárioDeBordoPorAlunoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

