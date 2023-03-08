namespace exercicio;
class exemplo
{
    //ATRIBUTOS
    public string nome="";
    public int idade=0;
    public bool vacinado=false;

    //MÉTODOS
    public void mostramsg(){
        Console.WriteLine("Opaa gente linda");
    }

    public void pegaNome(string texto){
        Console.WriteLine("pessoas: "+ texto);
    }

    public string mensagem(){
        return "Devolvendo um texto";
    }

    public int somar(int a, int b){
        return a+b;
    }
}
