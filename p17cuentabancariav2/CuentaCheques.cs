namespace _17cuentabancariav2
{
    public class CuentaCheques : CuentaBancaria
    {
        private double proteccionSobregiro;
        public CuentaCheques(double saldo, double proteccionSobregiro)
        :base(saldo){
            this.proteccionSobregiro = proteccionSobregiro;
        }

        public override bool Retirar(double cant)
        {
            bool flag = true;
            double proteccionRequeria = cant-saldo;
            if(proteccionSobregiro<proteccionRequeria){
                flag = false;
            }else{
                saldo = 0.0;
                proteccionSobregiro -= proteccionRequeria;
            }
            return flag;
        }
    }
}