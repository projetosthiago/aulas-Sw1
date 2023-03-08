namespace exercicio;
class Program
{
    static void Main(string[] args)
    {
        //Console.Writeline("Hello, World!);
        //Console.ReadKey();

        //Criar uma instância (objeto) a partir de uma classe
        exemplo exe01 = new exemplo();

        exe01.mostramsg();

        exe01.pegaNome("Olá Thiago");

        Console.WriteLine(exe01.mensagem());

        Console.WriteLine("O resultado da soma é " + exe01.somar(10,20));
    

    }
}
