using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    class Aula
    {
        public int IdAula { get; set; } // idAula (Primary key)
        public int IdCurso { get; set; } // idCurso
        public string NomeAula { get; set; } // NomeAula (length: 200)
        public System.DateTime DataCriacaoAula { get; set; } // DataCriacaoAula

        public void CadastrarAula() { }
        public void AlterarAula() { }
    }
}
