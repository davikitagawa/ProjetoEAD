using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    class Doacao
    {
        public int IdDoacao { get; set; } // idDoacao (Primary key)
        public int IdUsuario { get; set; } // IdUsuario
        public int IdTipoDoacao { get; set; } // IdTipoDoacao
        public decimal ValorDoacao { get; set; } // ValorDoacao
        public System.DateTime DataDoacao { get; set; } // DataDoacao        
        public virtual Usuario Usuario { get; set; } 
        public virtual Professor Professor { get; set; } 

        public void RealizarDoacao() { }
        public Doacao RetornarDoacao() 
        {
            return new Doacao();
        }
    }
}
