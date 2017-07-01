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
        private Materias materia;
        bool isEdicao;

        public FrmMaterias(string id, bool isEdicao = false)
        {
            InitializeComponent();
            this.isEdicao = isEdicao;
            this.materia = new Materias();
            txbId.Text = id;
        }
        public FrmMaterias(Materias materia, bool isEdicao = true)
        {
            InitializeComponent();
            this.materia = materia;
            this.isEdicao = isEdicao;
        }

        private void FrmMaterias_Load(object sender, EventArgs e)
        {
            if (isEdicao)
                PreencherCampos();
        }
        private void PreencherCampos()
        {
            txbId.Text = materia.Id;
            txbLocal.Text = materia.Local;
            txbMateria.Text = materia.Materia;
            txbConteudo.Text = materia.Conteudo;
            cbxPrioridade.Text = materia.Prioridade;
            txbInicio.Text = materia.DataInicio;
            txbTermino.Text = materia.DataFim;
            cbxFinalizado.Text = materia.Finalizado;
        }

        private void tbnSalvar_Click(object sender, EventArgs e)
        {
            PreencherMateria();
            if (isEdicao)
                Manipulador.Manipular.AlterarMateria(materia);
            else
                Manipulador.Manipular.IncluirMateria(materia);
            Close();
        }

        private void PreencherMateria()
        {
            materia.Id = txbId.Text;
            materia.Local = txbLocal.Text;
            materia.Materia = txbMateria.Text;
            materia.Conteudo = txbConteudo.Text;
            materia.Prioridade = cbxPrioridade.Text;
            materia.DataInicio = txbInicio.Text;
            materia.DataFim = txbTermino.Text;
            materia.Finalizado = cbxFinalizado.Text;
        }
    }
}
