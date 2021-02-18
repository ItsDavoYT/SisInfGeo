namespace _17cuentabancariav2
{
    public class CuentaBancaria
    {
        protected double saldo; //Permite que las clases que heredan puedan aceder a esta variable

        public CuentaBancaria(double saldo){
            this.saldo = saldo;
        }

        public double Saldo{
            get{return saldo;}
        }

        public void Deposita(double cant){
            saldo += cant;
        }

        public virtual bool Retirar(double cant){ //Este metodo puede ser sobrecargado en las clases que lo heredan
            bool flag = false;
            if(saldo >= cant){
                saldo -= cant;
                flag = true;
            }
            return flag;
        }
        
    }
}