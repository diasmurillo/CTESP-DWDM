using System;

namespace Classe_Pessoa
{
    //def da classe pessoa
    class cPessoa
    {
        string sNome;
        int iIdade;
        double dVenc;

        //definição de metodos get
        public string getNome() {return sNome;}
        public int getIdade(){return iIdade;}
        public double getVencimento(){return dVenc;}

        //definiçao de metodos set
        public void setNome(string newNome) {sNome = newNome;}
        public void setIdade(int newIdade) {iIdade = newIdade;}
        public void setVencimento(double newVencimento) {dVenc = newVencimento;}
    }
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gestão de pessoas");

            //Instanciação da classe cPessoa no objeto obj1
            cPessoa obj1 = new cPessoa();
            //preencher obj1
            obj1.setNome("Murilo Dias");
            obj1.setIdade(26);
            obj1.setVencimento(900);

            //Listar obj1
            Console.WriteLine(obj1.getNome());
            Console.WriteLine(obj1.getIdade());
            Console.WriteLine(obj1.getVencimento());
        }
    }
}