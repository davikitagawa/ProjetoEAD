using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    class Atividade
    {
        public int IdAtividade { get; set; } // IdAtividade (Primary key)
        public int IdCurso { get; set; } // IdCurso
        public string NomeAtividade { get; set; } // NomeAtividade (length: 100)
        public System.DateTime? PrazoAtividade { get; set; } // PrazoAtividade
        public int? NotaAtividade { get; set; } // NotaAtividade
        public System.DateTime? DataModificacaoAtividade { get; set; } // DataModificacaoAtividade
        public System.DateTime DataCriacaoAtividade { get; set; } // DataCriacaoAtividade
        public int IdRespostaAtividade { get; set; } // idRespostaAtividade

        public void AlterarResposta() { }
    }
}
