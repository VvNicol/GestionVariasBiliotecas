﻿using GestionBilioteca.Dtos;

namespace GestionBilioteca.Servicios
{
    internal interface OperativaInterface
    {
        void AltaBiblioteca(List<BibliotecaDto> listaBibliotecas);
    }
}