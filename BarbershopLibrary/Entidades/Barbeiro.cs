using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLibrary.Entidades
{
    public class Barbeiro
    {
        public int Id { get; set; }

        public int UsuarioId { get; set; } 

        public string Nome { get; set; } = string.Empty;

        public string Telefone { get; set; } = string.Empty;


        //Navegação para o Usuario

        public virtual Usuario? Usuario { get; set; } //coloquei "?" falando que pode ser null so pra não ficar dando aviso


        //Relacionamento com agendamentos

        public virtual List<Agendamento> Agendamentos { get; set; } = new List<Agendamento>();
    }
}
