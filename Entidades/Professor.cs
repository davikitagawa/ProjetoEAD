using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    class Professor : Usuario
    {
        public int IdProfessor { get; set; }
        public String Cpf { get; set; }
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
