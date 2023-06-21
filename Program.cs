using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_08
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Váriaveis

            int pontos = 0;
            
            Console.WriteLine( " -- Bem-Vindo ao jogo do 21 --" );

            Console.Write("\n");

            Console.WriteLine( " Seu objeitvo é chegar próximo de 21 pontos, aperte qualquer tecla para continuar!" );

            Console.ReadKey();
            
            Console.Clear();

            while (true)
            {

                Console.WriteLine( $" -- Você tem { pontos } pontos --" );

                Console.Write( " \n" );
                
                Console.Write( " Deseja continuar ? 1 para sim e 2 para não: " );
                string opcao = Console.ReadLine();
                
                Console.Clear();

                if( opcao == "2" )
                {

                    Console.Write( " \n\n" );
                    
                    Console.WriteLine( " -- FIM DE JOGO --" );

                    Console.Write( " \n" );

                    Console.WriteLine($" -- Sua pontuação final foi de {pontos} pontos --");

                    Console.ReadKey();
                    
                    break;

                }
                
                Random sorteador = new Random();
                int numero = sorteador.Next( 1, 11 );
                
                Console.WriteLine( $" -- Voce tirou o número { numero } --" );

                Console.Write( " \n" );

                pontos += numero;

                if ( pontos > 21 )
                {

                    Console.WriteLine( " VOCÊ PERDEU !! utrapassou o limite de pontos " );

                    Console.ReadKey();
                    
                    break;

                }

            }

            Console.WriteLine( $" -- Sua pontuação final foi de {pontos} pontos --" );

            Console.Write( " \n" );
            
            Console.WriteLine( " Fim do jogo!" );

        }
    }
}
