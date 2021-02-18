using System;

namespace _16cuentabancariav1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Control bancario");
            bool retiro;
            Banco miBanco = new Banco("El confianzudo", "Javier Luna");
            CuentaBancaria micuenta1 = new CuentaBancaria(100);
            CuentaBancaria micuenta2 = new CuentaBancaria(1000);

            Cliente miCliente1 = new Cliente("Juan Perez");
            Cliente miCliente2 = new Cliente("Maria Ruiz");
            Cliente miCliente3 = new Cliente();

            miCliente3.Nombre="Miguel Mendoza";

            miCliente1.Cuenta = micuenta1;
            miCliente2.Cuenta = micuenta2;
            miCliente3.Cuenta = new CuentaBancaria(300);

            micuenta1.Deposita(300);
            retiro = micuenta2.Retirar(200);

            miBanco.agregarCliente(miCliente1);
            miBanco.agregarCliente(miCliente2);
            miBanco.agregarCliente(miCliente3);
            miBanco.agregarCliente(new Cliente("Ruben Ibarra")); //Crear y agregar un nuevo cliente
            miBanco.Clientes[3].Cuenta = new CuentaBancaria(50000); //Crear y agreagar una nueva cuenta al cliente

            if(retiro){
                Console.WriteLine("Retiro exitoso");    
            }else{
                Console.WriteLine("No se puede retirar la cantidad solicitada");
            }

            miCliente3.Cuenta.Deposita(1000);
            miCliente2.Cuenta.Retirar(100);

            Console.WriteLine("Saldo cuenta 1 : {0}", micuenta1.Saldo);
            Console.WriteLine("Saldo cuenta 2 : {0}", micuenta2.Saldo);

            

            Console.WriteLine("Cliente 1: Nombre {0}, Saldo {1}", miCliente1.Cuenta.Saldo, miCliente1.Nombre);
            Console.WriteLine("Cliente 1: Nombre {0}, Saldo {1}", miCliente2.Cuenta.Saldo, miCliente2.Nombre);
            Console.WriteLine("Cliente 1: Nombre {0}, Saldo {1}", miCliente3.Cuenta.Saldo, miCliente3.Nombre);

            //imprimir reporte Bancario
            Console.WriteLine("\nReporte Bancario");
            Console.WriteLine($"Banco {miBanco.Nombre}, propietario {miBanco.Propietario}");
            foreach(Cliente cte in miBanco.Clientes){
                Console.WriteLine($"Nombre: {cte.Nombre}, Saldo: {cte.Cuenta.Saldo}");
            }
            Console.WriteLine("\nTotal de clientes {0}", miBanco.Clientes.Count);
        }
    }
}
