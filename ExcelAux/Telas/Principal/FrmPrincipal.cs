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

namespace ExcelAux.Telas
{
    public partial class FrmPrincipal : Form
    {
        private string caminhoExcel = @"C:\Users\Fellipe Mendonça\OneDrive\Documentos\Estudos OC\Guia de Estudos.xlsx";
        public FrmPrincipal()
        {
            InitializeComponent();
            cbxPlanilhas.DataSource = Manipulador.Manipular.GetNomePlanilhas(caminhoExcel);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            PreencherDGV(cbxPlanilhas.Text);
        }

        private void PreencherDGV(string planilha)
        {
            if (planilha.Equals("Tarefas"))
                dgvExcel.DataSource = Manipulador.Manipular.GetPlanilhaTarefas(caminhoExcel, planilha);
            else
                dgvExcel.DataSource = Manipulador.Manipular.GetPlanilhaMaterias(caminhoExcel, planilha);
            dgvExcel.Update();
            dgvExcel.Refresh(); dgvExcel.Refresh();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (cbxPlanilhas.Text.Equals("Materias de Estudos"))
            {
                Modificacao.FrmMaterias frmMaterias = new Modificacao.FrmMaterias();
                frmMaterias.ShowDialog();
            }
            else
            {
                Modificacao.FrmTarefas frmTarefas = new Modificacao.FrmTarefas();
                frmTarefas.ShowDialog();
            }

        }
    }
}
