using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    abstract class Usuario
    {
        int IdUsuario { get; set; } // idUsuario (Primary key)
        int IdEndereco { get; set; } // IdEndereco
        int IdTipoUsuario { get; set; } // IdTipoUsuario
        string NomeUsuario { get; set; } // NomeUsuario (length: 100)
        System.DateTime DataCriacaoUsuario { get; set; } // DataCriacaoUsuario
        System.DateTime? DataNascimento { get; set; } // DataNascimento
        bool? GeneroUsuario { get; set; } // GeneroUsuario

        System.Collections.Generic.ICollection<Comentario> Comentarios { get; set; }
        System.Collections.Generic.ICollection<Doacao> Doacoes { get; set; }

        public void CadastraUsuario() { }

        public void AlteraUsuario() { }

        private void RealizarResposta() { }

        private void LogarUsuario() { }

    }

    
}
