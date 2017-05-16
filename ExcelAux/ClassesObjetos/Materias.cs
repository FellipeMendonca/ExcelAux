using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAux.ClassesObjetos
{
    public class Materias
    {
        public string Id { get; set; }
        public string Local { get; set; }
        public string Materia { get; set; }
        public string Conteudo { get; set; }
        public string Prioridade { get; set; }

        private string dataInicio;
        public string DataInicio
        {
            get => dataInicio;
            set => dataInicio = SetData(value);
        }

        private string dataFim;
        public string DataFim
        {
            get => dataFim;
            set => dataFim = SetData(value);
        }
        public string Finalizado { get; set; }


        private string SetData(string value)
        {
            if (value != "Null" && !string.IsNullOrEmpty(value))
            {
                DateTime dataHora = Convert.ToDateTime(value);
                return dataHora.ToShortDateString();
            }
            else
            {
                return value;
            }
        }
    }
}

