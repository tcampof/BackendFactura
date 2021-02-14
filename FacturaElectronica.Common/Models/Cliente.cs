using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacturaElectronica.Common.Models
{
    public class Cliente
    {
        public int CliId { get; set; }
        public string CliNombre { get; set; }
        public string CliIdent { get; set; }
        public string CliTelefono { get; set; }

        public Cliente()
        {

        }
        public Cliente(int id)
        {
            CliId = id;
        }
        public Cliente(int id, string nombre, string identif, string telefono)
        {
            CliId = id;
            CliNombre = nombre;
            CliIdent = identif;
            CliTelefono = telefono;
        }
    }
}
