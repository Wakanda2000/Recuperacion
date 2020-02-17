using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using recuperacion.Clases;

namespace recuperacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new Cuenta("", "", 0, new List<Movimientosbancarios>());
            cuenta.Numero = "234567";
            cuenta.Propietario = "Marcelo";
            cuenta.Saldo = 3000;


            Deposito movimientosbancariosd = new Deposito(cuenta, 0);
            movimientosbancariosd.Cuenta = cuenta;
            movimientosbancariosd.Monto = 3050;

            Retiro movimientosbancariosr = new Retiro(cuenta, 0);
            movimientosbancariosr.Cuenta = cuenta;
            movimientosbancariosr.Monto = 2000;

            cuenta.Movimientosbancarios.Add(movimientosbancariosd);
            cuenta.Movimientosbancarios.Add(movimientosbancariosr);

            Console.WriteLine("BIENVENIDO A SU CUENTA BANCARIA");
            foreach (Movimientosbancarios item in cuenta.Movimientosbancarios)
                Console.WriteLine("Su saldo actual Señor: " + item.Cuenta.Propietario + " es: " + item.ActualizarSaldo());
            //Console.WriteLine(item.ActualizarSaldo());
            Console.ReadKey();
        }
    }
}
