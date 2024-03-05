using System;

namespace Classe_Pessoa
{
    //def da classe pessoa
    class cPessoa
    {
        string sNome;
        int iIdade;
        double dVenc;

        //definição de metodos geto
        public string getNome() {return sNome;}
        public int getIdade(){return iIdade;}
        public double getVencimento(){return dVenc;}

        //definiçao de metodos set
        public void setNome(string newNome) {sNome = newNome;}
        public void setIdade(int newIdade) {iIdade = newIdade;}
        public void setVencimento(double newVencimento) {dVenc = newVencimento;}

        // construtor 1
        public cPessoa()
        {
            dVenc = 1000;
        }

        //construtor 2
        public cPessoa(double newVenc)
        {
            dVenc = newVenc;
        }

        // construtor 3
        public cPessoa(string newNome, int newIdade)
        {
            sNome = newNome;
            iIdade = newIdade;
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestão de pessoas");

            //Instanciação da classe cPessoa no objeto obj1
            cPessoa obj1 = new cPessoa();
            cPessoa obj2 = new cPessoa();

            //preencher obj1
            obj1.setNome("Murilo Dias");
            obj1.setIdade(26);
            obj1.setVencimento(1200);

            //preencher obj2
            obj2.setNome("Larissa");
            obj2.setIdade(26);
            obj2.setVencimento(1250);

            //Listar obj1
            Console.WriteLine(obj1.getNome());
            Console.WriteLine(obj1.getIdade());
            Console.WriteLine(obj1.getVencimento());

            //Listar obj2
            Console.WriteLine(obj2.getNome());
            Console.WriteLine(obj2.getIdade());
            Console.WriteLine(obj2.getVencimento());
        }
    }
}