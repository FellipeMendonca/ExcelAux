using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelAux.ClassesObjetos;

namespace ExcelAux.Telas.Modificacao
{
    public partial class FrmTarefas : Form
    {
        private Tarefas tarefaAlterar;
        bool isEdicao;

        public FrmTarefas(string id, bool isEdicao = false)
        {
            InitializeComponent();
            this.isEdicao = isEdicao;
            this.tarefaAlterar = new Tarefas();
            txbId.Text = id;
        }

        public FrmTarefas(Tarefas tarefa, bool isEdicao = true)
        {
            InitializeComponent();
            this.tarefaAlterar = tarefa;
            this.isEdicao = isEdicao;
        }

        private void PreencherCampos()
        {
            txbId.Text = tarefaAlterar.Id;
            txbNome.Text = tarefaAlterar.Nome;
            txbDescricao.Text = tarefaAlterar.Descricao;
            cbxPrioridade.Text = tarefaAlterar.Prioridade;
            txbInicio.Text = tarefaAlterar.DataInicio;
            txbTermino.Text = tarefaAlterar.DataFim;
            cbxFinalizado.Text = tarefaAlterar.Finalizado;
        }


        private void PreencherTarefa()
        {
            tarefaAlterar.Id = txbId.Text;
            tarefaAlterar.Nome = txbNome.Text;
            tarefaAlterar.Descricao = txbDescricao.Text;
            tarefaAlterar.Prioridade = cbxPrioridade.Text;
            tarefaAlterar.DataInicio = txbInicio.Text;
            tarefaAlterar.DataFim = txbTermino.Text;
            tarefaAlterar.Finalizado = cbxFinalizado.Text;
        }

        private void tbnSalvar_Click(object sender, EventArgs e)
        {
            PreencherTarefa();
            if (isEdicao)
                Manipulador.Manipular.AlterarTarefas(tarefaAlterar);
            else
                Manipulador.Manipular.IncluirTarefas(tarefaAlterar);
            Close();
        }

        private void FrmTarefas_Load(object sender, EventArgs e)
        {
            if (isEdicao)
                PreencherCampos();
        }
    }
}
