using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperacion.Clases
{
    public class Cuenta
    {
        public Cuenta(string numero, string propietario, int saldo, List<Movimientosbancarios> movimientosbancarios)
        {
            Numero = numero;
            Propietario = propietario;
            Saldo = saldo;
            Movimientosbancarios = movimientosbancarios;
        }

        private string numero;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string propietario;

        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }

        private int saldo;

        public int Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        private List<Movimientosbancarios> movimientosbancarios;

        

        public List<Movimientosbancarios> Movimientosbancarios
        {
            get { return movimientosbancarios; }
            set { movimientosbancarios = value; }
        }




    }
}
