<<<<<<< HEAD
﻿using GestionBilioteca.Dtos;

namespace GestionBilioteca.Servicios
{
    internal interface OperativaInterface
    {
        void AltaBiblioteca(List<BibliotecaDto> listaBibliotecas);
        void AltaCliente(List<ClienteDtos> listaClientes, List<BibliotecaDto> listaBibliotecas);
        void AltaLibro(List<LibroDtos> listaLibro, List<BibliotecaDto> listaBibliotecas, List<ClienteDtos> listaClientes);
    }
=======
﻿using GestionBilioteca.Dtos;

namespace GestionBilioteca.Servicios
{
    internal interface OperativaInterface
    {
        void AltaBiblioteca(List<BibliotecaDto> listaBibliotecas);
        void AltaCliente(List<ClienteDtos> listaClientes, List<BibliotecaDto> listaBibliotecas);
    }
>>>>>>> Terminando alta cliente, falta verificar
}