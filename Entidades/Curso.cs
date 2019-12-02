using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEAD.Entidades
{
    class Curso
    {
        public int IdCurso { get; set; } // idCurso (Primary key)
        public int IdTipoCurso { get; set; } // idTipoCurso
        public string NomeCurso { get; set; } // NomeCurso (length: 100)
        public System.DateTime DataCriacao { get; set; } // DataCriacao
        public System.DateTime? DataModificacao { get; set; } // DataModificacao
        public bool CursoAtivo { get; set; } // CursoAtivo
        public int CargaHorario { get; set; } // CargaHorario

     
        public virtual System.Collections.Generic.ICollection<Atividade> Atividades { get; set; } 
        public virtual System.Collections.Generic.ICollection<Aula> Aulas { get; set; } 

        public void CadastrarCurso() { }

        public void AlterarCurso() { }
       
        public Curso()
        {
            Atividades = new System.Collections.Generic.List<Atividade>();
            Aulas = new System.Collections.Generic.List<Aula>();
        }
    }
}
