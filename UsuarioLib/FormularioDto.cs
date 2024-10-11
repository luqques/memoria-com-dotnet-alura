using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsuarioLib
{
    public record FormularioDto
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
    }
}
