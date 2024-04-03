using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBilioteca.Dtos
{
    internal class BibliotecaDto
    {
        long id;
        string nombreBiblioteca = "aaaaa";
        string direccionBiliblioreca = "aaaaa";



        public BibliotecaDto()
        {
        }

        public BibliotecaDto(long id, string nombreBiblioteca, string direccionBiliblioreca)
        {
            this.id = id;
            this.nombreBiblioteca = nombreBiblioteca;
            this.direccionBiliblioreca = direccionBiliblioreca;
        }

        public long Id { get => id; set => id = value; }
        public string NombreBiblioteca { get => nombreBiblioteca; set => nombreBiblioteca = value; }
        public string DireccionBiliblioreca { get => direccionBiliblioreca; set => direccionBiliblioreca = value; }
    }
}
