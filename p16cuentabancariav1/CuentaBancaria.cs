namespace _16cuentabancariav1
{
    public class CuentaBancaria
    {
        private double saldo;

        public CuentaBancaria(double saldo){
            this.saldo = saldo;
        }

        public double Saldo{
            get{return saldo;}
        }

        public void Deposita(double cant){
            saldo += cant;
        }

        public bool Retirar(double cant){
            bool flag = false;
            if(saldo >= cant){
                saldo -= cant;
                flag = true;
            }
            return flag;
        }
        
    }
}