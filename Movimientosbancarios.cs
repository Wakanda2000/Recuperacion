using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recuperacion.Clases
{
    public abstract class Movimientosbancarios
    {
        public Movimientosbancarios(Cuenta cuenta, int monto)
        {
            Cuenta = cuenta;
            Monto = monto;
        }

        private Cuenta cuenta;

        public Cuenta Cuenta
        {
            get { return cuenta; }
            set { cuenta = value; }
        }

        private int monto;

        public int Monto
        {
            get { return monto; }
            set { monto = value; }
        }

        private string tipo;

        



        public virtual int ActualizarSaldo()
        {
            return this.Monto;
        }



    }
}
