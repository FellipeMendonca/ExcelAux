using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ExcelAux.Telas.Modificacao;
using ExcelAux.ClassesObjetos;

namespace ExcelAux.Telas
{
    public partial class FrmPrincipal : Form
    {
        
        public FrmPrincipal()
        {
            InitializeComponent();
            cbxPlanilhas.DataSource = Manipulador.Manipular.GetNomePlanilhas();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDGV(cbxPlanilhas.Text);
        }

        private void PreencherDGV(string planilha)
        {
            if (planilha.Equals("Tarefas"))
                dgvExcel.DataSource = Manipulador.Manipular.GetPlanilhaTarefas();
            else
                dgvExcel.DataSource = Manipulador.Manipular.GetPlanilhaMaterias();
            dgvExcel.Update();
            dgvExcel.Refresh(); dgvExcel.Refresh();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cbxPlanilhas.Text.Equals("Materias de Estudos"))
            {
                Materias materia = new Materias();
                materia.Id = dgvExcel.CurrentRow.Cells["Id"].Value.ToString();
                materia.Local = dgvExcel.CurrentRow.Cells["Local"].Value.ToString();
                materia.Materia = dgvExcel.CurrentRow.Cells["Materia"].Value.ToString();
                materia.Conteudo = dgvExcel.CurrentRow.Cells["Conteudo"].Value.ToString();
                materia.Prioridade = dgvExcel.CurrentRow.Cells["Prioridade"].Value.ToString();
                materia.DataInicio = dgvExcel.CurrentRow.Cells["DataInicio"].Value.ToString();
                materia.DataFim = dgvExcel.CurrentRow.Cells["DataFim"].Value.ToString();
                materia.Finalizado = dgvExcel.CurrentRow.Cells["Finalizado"].Value.ToString();
                Modificacao.FrmMaterias frmMaterias = new Modificacao.FrmMaterias(materia);
                frmMaterias.ShowDialog();
            }
            else
            {
                Modificacao.FrmTarefas frmTarefas = new Modificacao.FrmTarefas();
                frmTarefas.ShowDialog();
            }
            PreencherDGV(cbxPlanilhas.Text);
        }
    }
}
