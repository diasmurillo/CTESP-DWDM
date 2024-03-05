using Classe_Pessoa;
using System;

namespace Classe_Pessoa
{
    // def da classe pessoa
    class cPessoa
    {
        // definição de atributos
        string sNome;
        int iIdade;
        double dVenc;

        // definição de métodos get
        public string getNome() { return sNome; }
        public int getIdade() { return iIdade; }
        public double getVencimento() { return dVenc; }

        // definição de métodos set
        public void setNome(string newNome) { sNome = newNome; }
        public void setIdade(int newIdade) { iIdade = newIdade; }
        public void setVencimento(double newVencimento) { dVenc = newVencimento; }

        //contrutor default
        public cPessoa(){ }

        //Construtor 1
        /*
        public cPessoa()
        {
            dVenc = 1000;
        }*/
        //construtor 2
        public cPessoa(double newVenc)
        {
            dVenc = newVenc;
        }
        //construtor 3
        public cPessoa(string newNome, int newIdade)
        {
            sNome = newNome;
            iIdade = newIdade;
        }

    }
}
class Program
{
    // menu de opções
    public static int fMenu()
    {
        Console.WriteLine("Gestão de pessoas");
        Console.WriteLine("1 Inserir pessoa");
        Console.WriteLine("2 Listar pessoas");
        Console.WriteLine("3 Consultar pessoas");
        Console.WriteLine("0 Sair do programa");
        Console.Write("Opção: ");

        return Convert.ToInt32(Console.ReadLine());
    }
    static void Main(string[] args)
    {
        //def de variaveis 
        cPessoa[] obj = new cPessoa[0];// obj é um array de objetos de cPessoa
        int opcao = 0;   // var para receber escolha do utilizador

        //ciclo para repetir as opções
        do
        {
            opcao = fMenu();
            switch(opcao)
            {
                case 1: //criar novo objeto de cPessoa
                    Array.Resize(ref obj, obj.Length + 1); //redimensiona o array para +1 posição
                    obj[obj.Length - 1] = new cPessoa(); // indice do array

                    Console.WriteLine("\nRegisto de nova Pessoa");

                    Console.Write("\nInsere o nome: ");
                    obj[obj.Length - 1].setNome(Console.ReadLine());
                    Console.Write("Insere a idade: ");
                    obj[obj.Length - 1].setIdade(Convert.ToInt32(Console.ReadLine()));
                    Console.Write("Insere o vencimento: ");
                    obj[obj.Length - 1].setVencimento(Convert.ToDouble(Console.ReadLine()));
                    
                    break;

                case 2: // Listar os objetos do array
                    Console.WriteLine("\nListar objetos do array");

                    for(int i = 0; i < obj.Length; i++)
                    {
                        /*
                        Console.WriteLine("Nome: {0}" +
                          " Idade: {1}" +
                          " Vencimento: {2}",
                          obj[i].getNome(),
                          obj[i].getIdade(),
                          obj[i].getVencimento());
                        */

                        Console.WriteLine($"Nome: {obj[i].getNome()}" +
                            $" Idade: {obj[i].getIdade()}" +
                            $" Vencimento: {obj[i].getVencimento()}");
                    }
                    break;

                case 3: // consultar pessoa pelo nome
                    Console.WriteLine("\nConsultar pessoa pelo nome");
                    Console.Write("Qual o nome da pessoa a cosnultar: ");
                    string nome = Console.ReadLine();

                    int indice = 0; // índice para

                    // ciclo para pesquisa de nome no array de objetos
                    do
                    {
                        if(nome == obj[indice].getNome())
                        {
                            Console.WriteLine($"Nome: {obj[indice].getNome()}" +
                            $" Idade: {obj[indice].getIdade()}" +
                            $" Vencimento: {obj[indice].getVencimento()}");
                        }
                        indice++;
                    } while (indice < obj.Length);

                    break;

            }

        } while (opcao != 0);
    }
}