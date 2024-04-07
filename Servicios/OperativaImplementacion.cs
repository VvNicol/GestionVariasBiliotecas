using GestionBilioteca.Dtos;
using GestionBilioteca.Servicios;

namespace GestionBilioteca.Controlador
{
    internal class OperativaImplementacion : OperativaInterface
    {
        public void AltaBiblioteca(List<BibliotecaDto> listaBibliotecas)
        {
            long idBiblioteca = Utilidades.Utils.calcularId(listaBibliotecas);
            Console.WriteLine("Ingrese el nombre de la biblioteca");
            string nombreBiblioteca = Console.ReadLine();
            Console.WriteLine("Ingrese direccion");
            string direccionBiblioteca = Console.ReadLine();

            BibliotecaDto biblioteca = new BibliotecaDto(idBiblioteca, nombreBiblioteca, direccionBiblioteca);
            listaBibliotecas.Add(biblioteca);
        }

        public void AltaCliente(List<ClienteDtos> listaClientes)
        {
            List<BibliotecaDto> listaBibliotecas = new List<BibliotecaDto>(); 
            Utilidades.Utils.mostrarBibliotecas(listaBibliotecas);
        }
    }
}