using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso.api.Bussines.Entidades
{
    public class Curso
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int CodigoUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
