using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    class Resposta
    {
        public int IdRespostaAtividade { get; set; } // idRespostaAtividade (Primary key)
        public string DescricaoResposta { get; set; } // DescricaoResposta (length: 200)

        
        public virtual System.Collections.Generic.ICollection<Atividade> TbAtividades { get; set; } 

        public Resposta()
        {
            TbAtividades = new System.Collections.Generic.List<Atividade>();
        }

    }
}
