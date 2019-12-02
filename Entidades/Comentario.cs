using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    class Comentario
    {
        public int IdComentario { get; set; } // idComentario (Primary key)
        public int IdResposta { get; set; } // idResposta
        public int IdUsuario { get; set; } // idUsuario
        public System.DateTime? DataModificacao { get; set; } // DataModificacao
        public System.DateTime DataCriacao { get; set; } // DataCriacao

        public virtual System.Collections.Generic.ICollection<Comentario> Comentarios { get; set; } 

        public virtual Comentario Comentario_IdResposta { get; set; } 

        public string Descricao { get; set; } // TextoComentario        
        public virtual Usuario TbUsuario { get; set; } 

        public void RealizaComentario() { }
        
        public Comentario()
        {
            Comentarios = new System.Collections.Generic.List<Comentario>();
        }
    }
}
