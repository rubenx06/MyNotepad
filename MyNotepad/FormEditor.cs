using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNotepad
{

    public partial class FormEditor : Form
    {

        private string ficheiro = "";
        public FormEditor()
        {
            InitializeComponent();
        }

        private void MenuFicheiroAbrir_Click(object sender, EventArgs e)
        {
            VerificarAlteracoes();

            openFileDialog1.Filter = "Ficheiro RTF| *.rtf || Ficheiros. TXT| *.txt | Todos | *.*";
            openFileDialog1.FileName = "";
            
            if (openFileDialog1.ShowDialog  () == DialogResult.OK){

                ficheiro= openFileDialog1.FileName;
                rbTexto.LoadFile(ficheiro);
                rbTexto.Modified = false;
            }
            

        } 

        private void menuFicheiroNovo_Click(object sender, EventArgs e)
        {
            VerificarAlteracoes();

            rbTexto.ResetText();
            rbTexto.Modified = false;
            ficheiro = null; 
        }

        private void MenuFicheiroGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show("Deseja sair da aplicação?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (resposta == DialogResult.Yes)
            {
                VerificarAlteracoes();
            }
           
           
        }
        private void VerificarAlteracoes()
        {
            DialogResult resposta = MessageBox.Show("Deseja guardar o texto atual?", "Atenção",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (ficheiro != "")
            {
                rbTexto.SaveFile(ficheiro);
                rbTexto.Modified = false;

            } else
            {
                GuardarFicheiro();
            }
        }

        private void menuEditarCortar_Click(object sender, EventArgs e)
        {
            rbTexto.Cut();
        }
        private void GuardarFicheiro()
        {
            saveFileDialog1.Filter = "fICHEIRO RTF | *.rtf | Ficheiros TXT | *.txt";

            saveFileDialog1.FileName = "";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ficheiro = saveFileDialog1.FileName;
                rbTexto.SaveFile(ficheiro);
                rbTexto.Modified = false;
            }
        }


        private void menuEditarCopiar_Click(object sender, EventArgs e)
        {
            rbTexto.Copy();
        }

        private void menuEditarColar_Click(object sender, EventArgs e)
        {
            rbTexto.Paste();
        }

        private void menuEditarSelecionar_Click(object sender, EventArgs e)
        {
            rbTexto.SelectAll();    
        }

        private void menuEditarProcurar_Click(object sender, EventArgs e)
        {
            string txtProcurar = Interaction.InputBox(" Digite o que procura:",
                "Procurar", "", 150, 200);
            
            int resultado =rbTexto.Find(txtProcurar);
            if (resultado == -1)
            {
                MessageBox.Show("Aviso", "Não foi encontrada a sua procura.", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void letraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (rbTexto.SelectionFont != null)
            {
                fontDialog1.Font = rbTexto.SelectionFont;  

            }
            else
            {
                fontDialog1.ShowDialog();
                rbTexto.SelectionFont = fontDialog1.Font;
            }
        }

        private void letraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rbTexto.SelectionColor= colorDialog1.Color
        }

        private void fundoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            rbTexto.SelectionBackColor = ColorDialog.Color;
        }
    }
}
