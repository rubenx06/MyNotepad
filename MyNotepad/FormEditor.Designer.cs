namespace MyNotepad
{
    partial class FormEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditor));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.menuFicheiro = new System.Windows.Forms.ToolStripSplitButton();
            this.menuFicheiroNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFicheiroAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFicheiroGuardar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFIcheiroSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditar = new System.Windows.Forms.ToolStripSplitButton();
            this.menuEditarCortar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarSelecionar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditarProcurar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFormatar = new System.Windows.Forms.ToolStripSplitButton();
            this.letraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.letraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fundoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbTexto = new System.Windows.Forms.RichTextBox();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiro,
            this.menuEditar,
            this.menuFormatar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(784, 37);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "ToolStrip";
            // 
            // menuFicheiro
            // 
            this.menuFicheiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFicheiroNovo,
            this.MenuFicheiroAbrir,
            this.MenuFicheiroGuardar,
            this.MenuFIcheiroSair});
            this.menuFicheiro.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiro.Image")));
            this.menuFicheiro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFicheiro.Name = "menuFicheiro";
            this.menuFicheiro.Size = new System.Drawing.Size(95, 34);
            this.menuFicheiro.Text = "Ficheiro";
            // 
            // menuFicheiroNovo
            // 
            this.menuFicheiroNovo.Image = ((System.Drawing.Image)(resources.GetObject("menuFicheiroNovo.Image")));
            this.menuFicheiroNovo.Name = "menuFicheiroNovo";
            this.menuFicheiroNovo.Size = new System.Drawing.Size(194, 36);
            this.menuFicheiroNovo.Text = "Novo";
            this.menuFicheiroNovo.Click += new System.EventHandler(this.menuFicheiroNovo_Click);
            // 
            // MenuFicheiroAbrir
            // 
            this.MenuFicheiroAbrir.Image = ((System.Drawing.Image)(resources.GetObject("MenuFicheiroAbrir.Image")));
            this.MenuFicheiroAbrir.Name = "MenuFicheiroAbrir";
            this.MenuFicheiroAbrir.Size = new System.Drawing.Size(194, 36);
            this.MenuFicheiroAbrir.Text = "Abrir";
            this.MenuFicheiroAbrir.Click += new System.EventHandler(this.MenuFicheiroAbrir_Click);
            // 
            // MenuFicheiroGuardar
            // 
            this.MenuFicheiroGuardar.Image = ((System.Drawing.Image)(resources.GetObject("MenuFicheiroGuardar.Image")));
            this.MenuFicheiroGuardar.Name = "MenuFicheiroGuardar";
            this.MenuFicheiroGuardar.Size = new System.Drawing.Size(194, 36);
            this.MenuFicheiroGuardar.Text = "Guardar";
            this.MenuFicheiroGuardar.Click += new System.EventHandler(this.MenuFicheiroGuardar_Click);
            // 
            // MenuFIcheiroSair
            // 
            this.MenuFIcheiroSair.Image = ((System.Drawing.Image)(resources.GetObject("MenuFIcheiroSair.Image")));
            this.MenuFIcheiroSair.Name = "MenuFIcheiroSair";
            this.MenuFIcheiroSair.Size = new System.Drawing.Size(194, 36);
            this.MenuFIcheiroSair.Text = "Sair";
            // 
            // menuEditar
            // 
            this.menuEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuEditarCortar,
            this.menuEditarCopiar,
            this.menuEditarColar,
            this.menuEditarSelecionar,
            this.menuEditarProcurar});
            this.menuEditar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditar.Image")));
            this.menuEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuEditar.Name = "menuEditar";
            this.menuEditar.Size = new System.Drawing.Size(83, 34);
            this.menuEditar.Text = "Editar";
            // 
            // menuEditarCortar
            // 
            this.menuEditarCortar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarCortar.Image")));
            this.menuEditarCortar.Name = "menuEditarCortar";
            this.menuEditarCortar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarCortar.Text = "Cortar";
            this.menuEditarCortar.Click += new System.EventHandler(this.menuEditarCortar_Click);
            // 
            // menuEditarCopiar
            // 
            this.menuEditarCopiar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarCopiar.Image")));
            this.menuEditarCopiar.Name = "menuEditarCopiar";
            this.menuEditarCopiar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarCopiar.Text = "Copiar";
            this.menuEditarCopiar.Click += new System.EventHandler(this.menuEditarCopiar_Click);
            // 
            // menuEditarColar
            // 
            this.menuEditarColar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarColar.Image")));
            this.menuEditarColar.Name = "menuEditarColar";
            this.menuEditarColar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarColar.Text = "Colar";
            this.menuEditarColar.Click += new System.EventHandler(this.menuEditarColar_Click);
            // 
            // menuEditarSelecionar
            // 
            this.menuEditarSelecionar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarSelecionar.Image")));
            this.menuEditarSelecionar.Name = "menuEditarSelecionar";
            this.menuEditarSelecionar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarSelecionar.Text = "Selecionar tudo";
            this.menuEditarSelecionar.Click += new System.EventHandler(this.menuEditarSelecionar_Click);
            // 
            // menuEditarProcurar
            // 
            this.menuEditarProcurar.Image = ((System.Drawing.Image)(resources.GetObject("menuEditarProcurar.Image")));
            this.menuEditarProcurar.Name = "menuEditarProcurar";
            this.menuEditarProcurar.Size = new System.Drawing.Size(194, 36);
            this.menuEditarProcurar.Text = "Procurar";
            this.menuEditarProcurar.Click += new System.EventHandler(this.menuEditarProcurar_Click);
            // 
            // menuFormatar
            // 
            this.menuFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letraToolStripMenuItem,
            this.coresToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.menuFormatar.Image = ((System.Drawing.Image)(resources.GetObject("menuFormatar.Image")));
            this.menuFormatar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuFormatar.Name = "menuFormatar";
            this.menuFormatar.Size = new System.Drawing.Size(101, 34);
            this.menuFormatar.Text = "Formatar";
            // 
            // letraToolStripMenuItem
            // 
            this.letraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("letraToolStripMenuItem.Image")));
            this.letraToolStripMenuItem.Name = "letraToolStripMenuItem";
            this.letraToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.letraToolStripMenuItem.Text = "Letra";
            this.letraToolStripMenuItem.Click += new System.EventHandler(this.letraToolStripMenuItem_Click);
            // 
            // coresToolStripMenuItem
            // 
            this.coresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.letraToolStripMenuItem1,
            this.fundoToolStripMenuItem});
            this.coresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("coresToolStripMenuItem.Image")));
            this.coresToolStripMenuItem.Name = "coresToolStripMenuItem";
            this.coresToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.coresToolStripMenuItem.Text = "Cores";
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esquerdaToolStripMenuItem,
            this.centroToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alinhamentoToolStripMenuItem.Image")));
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // letraToolStripMenuItem1
            // 
            this.letraToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("letraToolStripMenuItem1.Image")));
            this.letraToolStripMenuItem1.Name = "letraToolStripMenuItem1";
            this.letraToolStripMenuItem1.Size = new System.Drawing.Size(194, 36);
            this.letraToolStripMenuItem1.Text = "Letra";
            this.letraToolStripMenuItem1.Click += new System.EventHandler(this.letraToolStripMenuItem1_Click);
            // 
            // fundoToolStripMenuItem
            // 
            this.fundoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fundoToolStripMenuItem.Image")));
            this.fundoToolStripMenuItem.Name = "fundoToolStripMenuItem";
            this.fundoToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.fundoToolStripMenuItem.Text = "Fundo";
            this.fundoToolStripMenuItem.Click += new System.EventHandler(this.fundoToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("esquerdaToolStripMenuItem.Image")));
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("centroToolStripMenuItem.Image")));
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.centroToolStripMenuItem.Text = "centro ";
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("direitaToolStripMenuItem.Image")));
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(194, 36);
            this.direitaToolStripMenuItem.Text = "Direita";
            // 
            // rbTexto
            // 
            this.rbTexto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rbTexto.Location = new System.Drawing.Point(0, 37);
            this.rbTexto.Name = "rbTexto";
            this.rbTexto.Size = new System.Drawing.Size(784, 682);
            this.rbTexto.TabIndex = 1;
            this.rbTexto.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 719);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FormEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 741);
            this.Controls.Add(this.rbTexto);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormEditor";
            this.Text = "MyNotepad";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton menuFicheiro;
        private System.Windows.Forms.ToolStripMenuItem menuFicheiroNovo;
        private System.Windows.Forms.ToolStripMenuItem MenuFicheiroAbrir;
        private System.Windows.Forms.ToolStripMenuItem MenuFicheiroGuardar;
        private System.Windows.Forms.ToolStripMenuItem MenuFIcheiroSair;
        private System.Windows.Forms.ToolStripSplitButton menuEditar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCortar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarColar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarSelecionar;
        private System.Windows.Forms.ToolStripMenuItem menuEditarProcurar;
        private System.Windows.Forms.ToolStripSplitButton menuFormatar;
        private System.Windows.Forms.ToolStripMenuItem letraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem letraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fundoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rbTexto;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}