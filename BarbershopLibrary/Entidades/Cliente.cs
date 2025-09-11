using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLibrary.Entidades
{
    public class Cliente
    {
        public int Id {  get; set; }

        public int UsuarioId { get; set; }

        public string Nome { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;


        //Navegação para usuario

        public virtual Usuario? Usuario { get; set; }       //Lembrar de tirar o "?"


        // Relacionamento com Agendamentos
        public virtual List<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }
}
