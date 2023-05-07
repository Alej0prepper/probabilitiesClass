
namespace Probabilities
{
    class AleatoryDiscreteVariable
    {       

        public static void Main(string[] args)
        {
            
        }
        
        public static int  VASimulation(double[] a){
            
            Random aux = new Random();
            
            double fracc = aux.Next(0,100);

            fracc = fracc/100;

            double[] proba = new double[a.Length];
            double aux2  = 0;
            for (int i = 0; i < proba.Length; i++)
            {
                proba[i] = a[i] + aux2;
                aux2 = a[i];
                
                if(fracc >= proba[i]) return i;
            
            }
            return a.Length;

            // for (int i = 0; i < proba.Length; i++)
            // {
            //     if(fracc > proba[i]) return i;
            // }



        }

        public static double ExpectedValue(double[] a ){

            double aux= 0;
            for (int i = 0; i < a.Length; i++)
            {
                aux += a[i]*i;
            }

            return aux;

            //multiplica cada indice asignado a un evento por su probabilidad
            // los suma y asi se obtiene el valor esperado
        }

    }
/*   numero de caras obtenidas en tres tiros, acotada superiormente por 3 e inferioriormente por 0

    //////////////////////////////// FUNCION DE PORBABILIDAD//////////////////////////////////
    0        /1        /2         /3
    1/8       3/8      3/8        1/8

    
    ///////////////////////////////// FUNCION DE DISTRIBUCION/////////////////////////////////
 
     lo emulado en el codigo descrito arriba

    0        /1        /2         /3
    1/8       4/8      7/8        1
     
    ///////////////////////////////// Valor esperado/////////////////////////////////////////

    3/8 + 6/8 + 3/8 = 3/2

    algoritmo descrito en el metodo expectedValue
*/

 public class ProbabilityDistributions
    {
        public static double Geometric(int k, double p)
        { // gives the probabilities of the succes of the number k experiment
            return p * Math.Pow(1 - p, k - 1);      
            
        }
        public static double Binomial(int n, double p, int k){
            //probability of k succeses in n experiments
            return CombinationsNinK(n,k) * Math.Pow(p,k) * Math.Pow((1-p),n-k);
        }
        public static double NegativeBinomial( int k, double p, int x){
            // probability of k being the succes number x
            return  CombinationsNinK(k-1,x-1) * Math.Pow(p,k) * Math.Pow((1-p),k-x);
        }









        private static long CombinationsNinK(int n, int k)
        {
            return Factorial(n) / (Factorial(n-k) * Factorial(k));

        }
        private static long Factorial(int n)
        {
            if (n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}