using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    class Aluno : Usuario
    {
        public int IdAluno{ get; set; }
        public int IdUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IdEndereco { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int IdTipoUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NomeUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime DataCriacaoUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime? DataNascimento { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool? GeneroUsuario { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<Comentario> Comentarios { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public ICollection<Doacao> Doacoes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
