using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLibrary.Entidades
{
    public class AgendamentoDeServico
    {

        public int Id { get; set; }

        public int AgendamentoId { get; set; }

        public int ServicoId { get; set; }

        //navegação para Agendamento e serviço
        public virtual Agendamento? Agendamento {  get; set; }
        public virtual Servico? Servico { get; set; }
    }
}
