using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLibrary.Entidades
{
    public class Agendamento
    {
        public int Id { get; set; } 

        public int ClienteId { get; set; } 

        public int BarbeiroId { get; set; }

        public DateTime DataHora { get; set; }

        public string Observacao  { get; set; } = string.Empty;


        //Navegação para cliente e barbeiro
        public virtual Cliente? Cliente { get; set; }  //lembrar de tirar o "?"
        
        public virtual Barbeiro? Barbeiro { get; set; } //lembrar de tirar o "?"

        //Relacionamento com os serviços do agendamento
        public virtual List<AgendamentoDeServico>? AgendamentoDeServicos { get; set; } = new List<AgendamentoDeServico>();
    }
}
