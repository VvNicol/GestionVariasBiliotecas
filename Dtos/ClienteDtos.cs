using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionBilioteca.Dtos
{
    internal class ClienteDtos
    {
        long id;
        string nombreCliente = "aaaaa";
        string apellidosCliente = "aaaaa";
        DateTime fchaNacimientoCliente;
        string dniCliente = "aaaaa";
        string correoCliente = "aaaaa";
        DateTime fchaInicioSuspensión;
        DateTime fechaFinSuspensión;

        public ClienteDtos()
        {
        }

        public ClienteDtos(long id, string nombreCliente, string apellidosCliente, DateTime fchaNacimientoCliente, string dniCliente, string correoCliente)
        {
            this.id = id;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.fchaNacimientoCliente = fchaNacimientoCliente;
            this.dniCliente = dniCliente;
            this.correoCliente = correoCliente;
        }

        public long Id { get => id; set => id = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public DateTime FchaNacimientoCliente { get => fchaNacimientoCliente; set => fchaNacimientoCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string CorreoCliente { get => correoCliente; set => correoCliente = value; }
        public DateTime FchaInicioSuspensión { get => fchaInicioSuspensión; set => fchaInicioSuspensión = value; }
        public DateTime FechaFinSuspensión { get => fechaFinSuspensión; set => fechaFinSuspensión = value; }
    }
}
