namespace _17cuentabancariav2
{
    public class CuentaAhorro : CuentaBancaria
    {
        private double tasadeinteres;

        public CuentaAhorro(double saldo, double tasadeinteres):base(saldo){
            this.tasadeinteres = tasadeinteres;

        }

        public void calcularInteres(){
            
        }
    }
}