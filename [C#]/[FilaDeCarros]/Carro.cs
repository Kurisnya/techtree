namespace _2;


class Carro()
{
   public string nome;

   public Carro proximo;

   public Carro fim;


    public void Preencher()
    {
        System.Console.WriteLine("Insira o nome do Carro...");
        nome=Console.ReadLine();
    }
}