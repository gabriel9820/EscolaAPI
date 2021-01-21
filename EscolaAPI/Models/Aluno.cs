using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaAPI.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Nascimento { get; set; }
        public int ProfessorId { get; set; }
        public Professor Professor { get; set; }
    }
}
