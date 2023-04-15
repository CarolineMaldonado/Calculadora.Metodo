using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.metodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Qual operação deseja fazer: ");
             Console.WriteLine("1 - Adição");
             Console.WriteLine("2 - Subtração");
             Console.WriteLine("3 - Multiplicação");
             Console.WriteLine("4 - Divisão\n");



             int operacao = int.Parse(Console.ReadLine()); // LENDO A VARIAVEL NÚMERO QUE ENTRA COMO STRING E CONVERTE ELA PARA INTEIRO 

               Console.WriteLine("Entre com o primeiro número do cálculo: ");
               int n1 = int.Parse(Console.ReadLine());

               Console.WriteLine("Entre com o segundo número do cálculo: ");
               int n2 = int.Parse(Console.ReadLine());

               int result = 0;



               switch (operacao)  // Estamos pegando a variavel "operação" que de acordo com o que o usuário informar, será feita a comparação com cada caso abaixo:
               {
                    case 1:   // caso 1, quando o usuário entrar com a opção "1"
                        {
                            result = Adicao(n1, n2);    // chamando o método Adição que realiza o cálculo em um método independente
                            break;
                        }
                    case 2:     // caso 2, quando o usuário entrar com a opção "2"
                        {
                            result = Subt(n1, n2);  // chamando o método Subt que realiza o cálculo em um método criado independente
                            break;
                        }
                    case 3:        // caso 3, quando o usuário entrar com a opção "3"
                        {
                            result = Multi(n1, n2);     // chamando o método Multi que realiza o cálculo em um método criado independente
                            break;
                        }
                    case 4:         // caso 4, quando o usuário entrar com a opção "4"
                        {
                            result = Divi(n1, n2);   // chamando o método Divi que realiza o cálculo em um método criado independente
                            break;
                        }
                    default:
                        Console.WriteLine("Número invalido, digite alguma das opções mostradas.");
                        break;
               }
                Console.WriteLine(" O resulado do cálculo com os números {0} e {1} é: {2}", n1, n2, result);
                Console.ReadLine();
           

                           
        }

            public static int Adicao(int n1, int n2) // método da adicao, é usado outro nome p subrtração pq são metodos "independentes"
            {
                int resultado = n1 + n2;            // As variaveis n1 e n2, utilizadas aqui são independetes das usadas lá em cima(podendo ser utilizado qualquer outro nome) pois aqui foi criado outro método
                return resultado;                      // retornando o resultado para quando esse método for chamado lá em cima
            }
            public static int Subt(int n1, int n2) // metodo da subtração, é usado outro nome p subrtração pq são metodos "independentes"
            {
                int resultado = n1 - n2;           // As variaveis n1 e n2, utilizadas aqui são independetes das usadas lá em cima(podendo ser utilizado qualquer outro nome) pois aqui foi criado outro método
                return (int)resultado;             // retornando o resultado para quando esse método for chamado lá em cima
            }

            public static int Multi(int n1, int n2)  // método para a multiplicação, é usado outro nome p subrtração pq são metodos "independentes" 
            {
                int resultado = n1 * n2;           // As variaveis n1 e n2, utilizadas aqui são independetes das usadas lá em cima(podendo ser utilizado qualquer outro nome) pois aqui foi criado outro método
                return (int)resultado;         //retornando o resultado para quando esse método for chamado lá em cima
            }
            public static int Divi(int n1, int n2)   // Método para realizar a divisão, é usado outro nome p subrtração pq são metodos "independentes"
            {
                int resultado = n1 / n2;                  // As variaveis n1 e n2, utilizadas aqui são independetes das usadas lá em cima(podendo ser utilizado qualquer outro nome) pois aqui foi criado outro método
                return resultado;                           //retornando o resultado para quando esse método for chamado lá em cima
            }
    }
}
