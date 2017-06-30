using ClosedXML.Excel;
using ExcelAux.ClassesObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ExcelAux.Manipulador
{
    public class Manipular
    {
        public static List<string> GetNomePlanilhas(string caminhoExcel)
        {
            try
            {
                ClosedXML.Excel.XLWorkbook excel = new XLWorkbook(caminhoExcel); // Abrir Excel
                List<string> nomePlanilhas = new List<string>();
                int qtdPlanilhas = excel.Worksheets.Count; // Obter a quantidade de Planilhas
                for (int i = 1; i <= qtdPlanilhas; i++)
                {
                    nomePlanilhas.Add(excel.Worksheet(i).Name); // Obter nomes das planilhas existentes
                }
                return nomePlanilhas;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tipo de Erro: " + ex.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            return null;
        }


        public static List<Materias> GetPlanilhaMaterias(string caminhoExcel, string nomePlanilha)
        {
            try
            {
                ClosedXML.Excel.XLWorkbook excel = new XLWorkbook(caminhoExcel); // Abrir Excel
                var planilha = excel.Worksheet(nomePlanilha); // Possivel Selected no ComboBox
                List<Materias> listaMateria = new List<Materias>();

                int linha = 2;//Começa a leitura pela linha 2 para ignorar cabeçalho
                while (true)
                {
                    Materias materia = new Materias()
                    {
                        Id = planilha.Cell("A" + linha.ToString()).Value.ToString(),
                        Local = planilha.Cell("B" + linha.ToString()).Value.ToString(),
                        Materia = planilha.Cell("C" + linha.ToString()).Value.ToString(),
                        Conteudo = planilha.Cell("D" + linha.ToString()).Value.ToString(),
                        Prioridade = planilha.Cell("E" + linha.ToString()).Value.ToString(),
                        DataInicio = planilha.Cell("F" + linha.ToString()).Value.ToString(),
                        DataFim = planilha.Cell("G" + linha.ToString()).Value.ToString(),
                        Finalizado = planilha.Cell("H" + linha.ToString()).Value.ToString()
                    };

                    if (string.IsNullOrEmpty(materia.Id)) { break; }
                    else { listaMateria.Add(materia); }

                    linha++;
                }
                planilha.Dispose();
                excel.Dispose();
                return listaMateria;
            }
            catch (Exception ex)

            {
                MessageBox.Show("Tipo de Erro: " + ex.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            return null;
        }

        public static List<Tarefas> GetPlanilhaTarefas(string caminhoExcel, string nomePlanilha)
        {
            try
            {
                XLWorkbook excel = new XLWorkbook(caminhoExcel); // Abrir Excel
                var planilha = excel.Worksheet(nomePlanilha); // Possivel Selected no ComboBox
                List<Tarefas> listaTarefa = new List<Tarefas>();

                int linha = 2;//Começa a leitura pela linha 2 para ignorar cabeçalho
                while (true)
                {
                    ClassesObjetos.Tarefas tarefa = new ClassesObjetos.Tarefas()
                    {
                        Id = planilha.Cell("A" + linha.ToString()).Value.ToString(),
                        Nome = planilha.Cell("B" + linha.ToString()).Value.ToString(),
                        Descricao = planilha.Cell("C" + linha.ToString()).Value.ToString(),
                        Prioridade = planilha.Cell("D" + linha.ToString()).Value.ToString(),
                        DataInicio = planilha.Cell("E" + linha.ToString()).Value.ToString(),
                        DataFim = planilha.Cell("F" + linha.ToString()).Value.ToString(),
                        Finalizado = planilha.Cell("G" + linha.ToString()).Value.ToString()
                    };

                    if (string.IsNullOrEmpty(tarefa.Id)) { break; }
                    else { listaTarefa.Add(tarefa); }

                    linha++;
                }
                planilha.Dispose();
                excel.Dispose();
                return listaTarefa;
            }
            catch (Exception ex)

            {
                MessageBox.Show("Tipo de Erro: " + ex.Message, "Erro", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
            return null;
        }
    }
}
