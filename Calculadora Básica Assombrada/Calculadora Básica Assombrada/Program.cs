namespace Calculadora_Básica_Assombrada;
class Program
{
    internal class program
    {

        static void Main(string[] args)
        {  // ABRINDO ESCOPO PARA FUNCAO MAIN

            do
            {   //ESCOPO 01 ABERTO AQUI
                Console.Clear();

                Console.WriteLine("Calculadora dona Mariana");
                // vai escrever na tela, mas sempre tem que estar dentro de ""
                Console.WriteLine("Digite 1 para adicionar:");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S" || operacao == "s")

                    break;


                if (operacao != "1" && operacao != "2" && operacao != "3" && operacao != "4" && operacao != "S" && operacao != "s")
                {
                    Console.WriteLine("operacao inválida, tente novamente...");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine();

                Console.WriteLine("Insira o primeiro número: ");

                decimal primeiroNumero = Convert.ToDecimal(Console.ReadLine());

                // O  = vai atribuir um comando

                //Convert = posso usar para converter texto em número

                Console.Write("Insira o segundo número: ");

                decimal segundoNumero = Convert.ToDecimal(Console.ReadLine());

                decimal resultado = 0;

                bool ehAdicao = operacao == "1";
                bool ehsubtracao = operacao == "2";
                bool ehmultiplicacao = operacao == "3";
                bool ehdivisao = operacao == "4";

                if (ehAdicao)
                {
                                       

                    resultado = primeiroNumero + segundoNumero;
                }
                else if (ehsubtracao)

                {
                    resultado = primeiroNumero - segundoNumero;
                }
                else if (ehmultiplicacao)
                {
                    resultado = primeiroNumero * segundoNumero;
                }
                else if (ehdivisao)
                {

                    while (segundoNumero == 0)
                    {
                        Console.WriteLine("Segundo número nao pode ser ZERO, tente novamente");

                        Console.ReadLine();

                        Console.Write("Digite o segundo número");

                        segundoNumero = Convert.ToInt32(Console.ReadLine());

                    }

                    resultado = primeiroNumero / segundoNumero;
                }

                decimal resultadoFormatado = Math.Round(resultado, 2);

                Console.WriteLine(" O resultado da operacao é:" + resultadoFormatado);

                Console.ReadLine();

            } while (true);   
        }
    }
}