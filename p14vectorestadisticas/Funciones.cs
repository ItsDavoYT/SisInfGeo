using System;

namespace _14vectorestadisticas
{
    public static class Funciones{
        public static double Mayor(double[] v){
            double m = v[0];
            for(int i=0;i<v.Length;i++){
                if(v[i]>m) m=v[i];
            }
            return m;
        }

        public static double Menor(double[] v){
            double m = v[0];
            for(int i=0;i<v.Length;i++){
                if(v[i]<m) m=v[i];
            }
            return m;
        }
        public static double Promedio(double[] v){
            double m = 0;
            for(int i=0;i<v.Length;i++){
                m+= v[i];
            }
            return m/v.Length;
        }

        public static double Varianza(double[] v, double p){
            double m = 0;
            for(int i=0; i<v.Length;i++){
                m+= Math.Pow(v[i]-p,2);
            }
            return m;
        }
    }
}