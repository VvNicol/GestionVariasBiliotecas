using GestionBilioteca.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBilioteca.Utilidades
{
    internal class Utils
    {
        public static long calcularId(List<BibliotecaDto> listaB)
        {
            long idCalcular;
            int tamanioLista = listaB.Count;

            if (tamanioLista > 0)
            {
                idCalcular = listaB.Count() + 1;
            }else
            {
                idCalcular = 1;
            }
            return idCalcular;
        }

        public static long calcularIdCliente(List<ClienteDtos> listaC)
        {
            long idCalcular;
            int tamanioLista = listaC.Count;

            if (tamanioLista > 0)
            {
                idCalcular = listaC.Count() + 1;
            }
            else
            {
                idCalcular = 1;
            }
            return idCalcular;
        }

        public static void mostrarBibliotecas(List<BibliotecaDto> listaC)
        {            
            Console.WriteLine("Bibliotecas");

            foreach (BibliotecaDto bibli in listaC)
            {
                Console.WriteLine(bibli.ToString());
            }
        }
    }
}
