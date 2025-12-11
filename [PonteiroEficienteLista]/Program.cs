namespace clear;

class Program
{
    static void Main(string[] args)
    {
            lista minhalista= new lista();

            int controle;
            bool sair= false;

            while(sair==false)
        {
            //TÍTULO: "Menu Super Irado";
            Console.Clear();
            System.Console.WriteLine($"==============================\n====== Menu Super Irado ======\n==============================");
            System.Console.WriteLine("1. Criar Elemento");
            System.Console.WriteLine("2. Imprimir Elementos");
            System.Console.WriteLine("0. Sair");
            
            //SWITCH
            controle= int.Parse(Console.ReadLine());
            switch (controle)
            {
                case 1:
                    {
                        Console.Clear();
                        elemento novoelemento= minhalista.NovoElemento();
                        minhalista.InserirFim(novoelemento);
                    }
                break;
                case 2:
                    {
                        Console.Clear();
                        minhalista.imprimir();
                        Console.ReadKey();
                    }
                break;
            }
        }   

    }   

    


}


