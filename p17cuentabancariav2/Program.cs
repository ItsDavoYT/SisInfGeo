using System;

namespace _17cuentabancariav2
{
    class Program
    {
        static void Main(string[] args){
            Banco mibanco = new Banco("Patito SA de CV", "Mc Pato");
            mibanco.agregarCliente(new Cliente("Amalia Garcia"));
            mibanco.agregarCliente(new Cliente("Miguel Alonso"));
            mibanco.agregarCliente(new Cliente("Alejandro Tello"));
            mibanco.agregarCliente(new Cliente("Ricardo Monreal"));

            //CLiente 0 Amalia
            mibanco.Clientes[0].AgregarCuenta(new CuentaAhorro(5000,0.10));
            mibanco.Clientes[0].AgregarCuenta(new CuentaCheques(1000,400));
            mibanco.Clientes[1].AgregarCuenta(new CuentaAhorro(6000,0.50));
            mibanco.Clientes[1].AgregarCuenta(new CuentaCheques(8000,300));
            mibanco.Clientes[2].AgregarCuenta(new CuentaAhorro(118000,0.10));
            mibanco.Clientes[3].AgregarCuenta(new CuentaAhorro(1500,0.4));
            mibanco.Clientes[3].AgregarCuenta(new CuentaAhorro(30000,0.3));
            



            Console.WriteLine("\nReporte Bancario");
            Console.WriteLine("Banco: {0} Propietario {1}", mibanco.Nombre, mibanco.Propietario);

            foreach(Cliente cte in mibanco.Clientes){
                Console.WriteLine($"Nombre: {cte.Nombre}");
                foreach(CuentaBancaria cta in cte.Cuentas()){
                    Console.WriteLine( (cta is CuentaCheques) ? "Cuenta de Cheques" : "Cuenta de ahorro" );
                    Console.WriteLine($"{cta.Saldo  }");
                }
            }
        }
        static void pruebaCuentas()
        {
            //Mi ahorro
            CuentaAhorro miahorro1 = new CuentaAhorro(5500,0.1);
            miahorro1.Deposita(1500);
            miahorro1.Retirar(100);

            Console.WriteLine("Mi ahorro 1 {0}",miahorro1.Saldo);
            miahorro1.calcularInteres();
            Console.WriteLine("Mi ahorro 1 {0}",miahorro1.Saldo);

            //Mi cheque
            CuentaCheques micheque1 = new CuentaCheques(1000, 500);
            Console.WriteLine("Mi cheque 1 saldo: {0}", micheque1.Saldo);

            micheque1.Retirar(1400);
            Console.WriteLine("Mi cheque 1 saldo: {0}", micheque1.Saldo);
        }
    }
}
