namespace revisoes_1
{
    class Program
    {
        // Programa para gestao de estrutura de colaboradores 


        // definiçoes da estrutura de colaboradores // classe - metodos e comprotamento 
        public struct sColaboradores
        {
            // criaçao de atributos
            public int cCodigo;
            public string cNome;
            public int cIdade;
            public double cVencimento;
        }

        // funçao que apresenta um conjunto de opecoes e retorna ao prog principal a opecao escolhida
        public static int menu()
        {
            int opcao = 0;
            Console.WriteLine("Menu de opcoes:");
            Console.WriteLine("1 Preencher colaboradores");
            Console.WriteLine("2 Listar colaboradores");
            Console.WriteLine("0 Sair do programa");
            Console.Write("Escolha uma opcao:");
            opcao = Convert.ToInt32(Console.ReadLine());

            return opcao;
        }

        static void Main(string[] args)
        {
            // escreve e muda de linha "Console.WriteLine"
            Console.WriteLine("-----------------Gestao de colaboradores-----------------");
            Console.WriteLine();


            // preencher e ler a estrutura
            // variavel - criar uma variavel para manipular a estrutura "st"
            // sColaboradores st = new sColaboradores();
            //sColaboradores st1 = new sColaboradores();


            // variavel usada no segundo exercicio
            int numColab = 0;
            // defenicao de var para opcao da escolha do utiçlizador
            int op = 0;


            /*
            // ST - preechimento da estrutura 
            st.cCodigo = 100;
            st.cNome = "Firmino Silva";
            st.cIdade = 40;
            st.cVencimento = 1000;

            // apresentaçao dados da estrutura,  $ - instruir, procurar e mostrar o valor da variavel "cCodigo" na estrutura
            Console.WriteLine($"codigo do colaborador: {st.cCodigo}");
            Console.WriteLine($"Nome do colaborador: {st.cNome}");
            Console.WriteLine($"Idade do colaborador: {st.cIdade}");
            Console.WriteLine($"Vencimento do colaborador: {st.cVencimento}");
            
            // o 0 vai ser substituido pelo primeiro valor que aparecer:
            Console.WriteLine("Idade: {0} e o vencimento é: {1}", st.cIdade, st.cVencimento);
            */
            // ST1 - preechimento da estrutura 

            /*
            st1.cCodigo = 101;
            st1.cNome = "Ana Sousa";
            st1.cIdade = 20;
            st1.cVencimento = 2000;

            Console.WriteLine();
            Console.WriteLine($"codigo do colaborador: {st1.cCodigo}");
            Console.WriteLine($"Nome do colaborador: {st1.cNome}");
            Console.WriteLine($"Idade do colaborador: {st1.cIdade}");
            Console.WriteLine($"Vencimento do colaborador: {st1.cVencimento}");
            */



            // definiçao de um array de n posisoes de estruturas de colaboradores
            // insere o numero de colaboradores que queremos inserir 
            Console.WriteLine("Inserir um numero de colaboradores");

            //  Console.ReadLine = le o que diz no teclado,  Convert.ToInt32 = converte a string para tipo inteiro
            numColab = Convert.ToInt32(Console.ReadLine());

            // defeniçao do arry de numero de colaborador posiçao em memoria 
            // aColab = a de arry colab de colaborador
            sColaboradores[] aColab = new sColaboradores[numColab];



            // ------------------------------------------------------------------------------------------------------------//
            /*
            // ciclo para preenchimento de estrutura de colaboradores 
            // a informaçao inserida na estrutura fica guardado na variavel "numColab"

            // for (inicio; condicao de fim; incremento)
            for (int i = 0; i < numColab; i++)
            {
                // {i+1} = quando mostrar no console nao aparece "0 colaborador, 1 colaborador, etc" mas sim comeca logo no 1 colaborador
                Console.WriteLine($"Preencher o {i + 1}º colaborador");

                //  Console.Write = write só serve para escrever 
                Console.Write("Insere o código: ");
                aColab[i].cCodigo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Insira o Nome: ");
                aColab[i].cNome = Console.ReadLine();

                Console.Write("Insere a idade: ");
                aColab[i].cIdade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Insere o Vencimento: ");
                aColab[i].cVencimento = Convert.ToInt32(Console.ReadLine()); 
            }


            // apresenta a informacao que esta na variavel aColab atravez de um ciclo
            for (int i = 0; i < numColab; i++)
            {
                Console.WriteLine($"Codigo do colaborador: {aColab[i].cCodigo}");
                Console.WriteLine($"Nome do colaborador: {aColab[i].cNome}");
                Console.WriteLine($"Idade do colaborador: {aColab[i].cIdade}");
                Console.WriteLine($"Vencimento do colaborador: {aColab[i].cVencimento}");
            }*/

            // ------------------------------------------------------------------------------------------------------------//


            
            do{


                op = menu(); // a opcao que escolher e do menu

                switch (op)
                {
                    case 1:
                        // ciclo para preencher - estruturas de colaboradores
                        for (int i = 0; i < numColab; i++)
                        {
                            // {i+1} = quando mostrar no console nao aparece "0 colaborador, 1 colaborador, etc" mas sim comeca logo no 1 colaborador
                            Console.WriteLine($"Preencher o {i + 1}º colaborador");

                            //  Console.Write = write só serve para escrever 
                            Console.Write("Insere o código: ");
                            aColab[i].cCodigo = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Insira o Nome: ");
                            aColab[i].cNome = Console.ReadLine();

                            Console.Write("Insere a idade: ");
                            aColab[i].cIdade = Convert.ToInt32(Console.ReadLine());

                            Console.Write("Insere o Vencimento: ");
                            aColab[i].cVencimento = Convert.ToDouble(Console.ReadLine());
                        }
                        break;
                    case 2:

                        for (int i = 0; i < numColab; i++)
                        {
                            Console.WriteLine($"Codigo do colaborador: {aColab[i].cCodigo}");
                            Console.WriteLine($"Nome do colaborador: {aColab[i].cNome}");
                            Console.WriteLine($"Idade do colaborador: {aColab[i].cIdade}");
                            Console.WriteLine($"Vencimento do colaborador: {aColab[i].cVencimento}");
                        }
                        break;
                    case 0:
                        Console.WriteLine("Saida do programa");
                        break;
                }

            } while (op != 0); // diferente de 0
        }
    }
}