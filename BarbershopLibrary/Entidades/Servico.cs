using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLibrary.Entidades
{
    public class Servico
    {
        public int Id { get; set; }

        public string Nome { get; set; } = string.Empty;    

        public decimal Preco { get; set; }

        public TimeSpan Duracao { get; set; }  //duração do serviço

        //Relacionamento com AgendamentoServico
        public virtual List<AgendamentoDeServico>? AgendamentosDeServico { get; set; } = new List<AgendamentoDeServico>();
    }
}
