using ExcelAux.ClassesObjetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAux.Telas.Modificacao
{
    public partial class FrmMaterias : Form
    {
        private Materias materiaAlterar;
        public FrmMaterias()
        {
            InitializeComponent();
        }
        public FrmMaterias(Materias materia)
        {
            InitializeComponent();
            materiaAlterar = materia;
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            PreencherCampos();
        }
        private void PreencherCampos()
        {
            txbId.Text = materiaAlterar.Id;
            txbLocal.Text = materiaAlterar.Local;
            txbMateria.Text = materiaAlterar.Materia;
            txbConteudo.Text = materiaAlterar.Conteudo;
            cbxPrioridade.Text = materiaAlterar.Prioridade;
            txbInicio.Text = materiaAlterar.DataInicio;
            txbTermino.Text = materiaAlterar.DataFim;
            cbxFinalizado.Text = materiaAlterar.Finalizado;
        }

        private void tbnSalvar_Click(object sender, EventArgs e)
        {
            PreencherMateria();
            Manipulador.Manipular.AlterarMateria(materiaAlterar);
            Close();
        }

        private void PreencherMateria()
        {
            materiaAlterar.Id = txbId.Text;
            materiaAlterar.Local = txbLocal.Text;
            materiaAlterar.Materia = txbMateria.Text;
            materiaAlterar.Conteudo = txbConteudo.Text;
            materiaAlterar.Prioridade = cbxPrioridade.Text;
            materiaAlterar.DataInicio = txbInicio.Text;
            materiaAlterar.DataFim = txbTermino.Text;
            materiaAlterar.Finalizado = cbxFinalizado.Text;
        }
    }
}
