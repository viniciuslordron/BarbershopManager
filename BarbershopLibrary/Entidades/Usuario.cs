using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbershopLibrary.Entidades
{
    public class Usuario
    {
        public int Id { get; set; }

        public string NomeLogin { get; set; } = string.Empty;
        
        public string Senha {  get; set; } = string.Empty;

        public string Tipo { get; set; } = string.Empty; 

        public bool Ativo {  get; set; }

        public virtual Cliente? Cliente { get; set; }
        public virtual Barbeiro? Barbeiro { get; set; }


    }
}
