using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperacion.Clases
{
    public class Deposito : Movimientosbancarios
    {
        public Deposito(Cuenta cuenta, int monto) :base(cuenta, monto)
            {            
            }



        public override int ActualizarSaldo()
        {
            this.Cuenta.Saldo = this.Cuenta.Saldo + this.Monto;
            return this.Cuenta.Saldo;
        }

    }
}
