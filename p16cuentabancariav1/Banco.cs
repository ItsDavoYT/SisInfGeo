using System.Collections.Generic;
namespace _16cuentabancariav1
{
    public class Banco
    {
        private string nombre;
        private string propietario;
        private List<Cliente> clientes;
        
        public Banco(string nombre, string propietario){
            this.nombre = nombre;
            this.propietario = propietario;
            clientes = new List<Cliente>();
        }

        public string Propietario
        {
            get { return propietario; }
            set { propietario = value; }
        }
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public List<Cliente> Clientes{//Regresa la lista de clientes
            get {return clientes;}

        }

        public void agregarCliente(Cliente cliente){
            clientes.Add(cliente);
        }
        
    }
}