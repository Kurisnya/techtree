namespace _2;


class Menu()
{
    
    public Carro Inicio= new Carro();
    public Carro Novo= new Carro();

    public Carro final= new Carro();
    public int controle;
    public string nomedocarro;
    public void start()
    {
        do
        {
            Console.Clear();
            System.Console.WriteLine("1. Inserir carro;");
            System.Console.WriteLine("2. Mostrar fila;");
            System.Console.WriteLine("3. Saída de carro;");
            controle= int.Parse(Console.ReadLine());
            switch (controle)
            {
                case 1:
                    if(contar()>=9)
                    {
                        System.Console.WriteLine("Fila cheia! Sem espaço para mais carros. Pressione ENTER para continuar;");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        novo(new Carro());
                        System.Console.WriteLine("ENTER - Novo carro // ESC - Sair");
                    }
                break;

                case 2:
                    Console.Clear();
                    Fila();
                    System.Console.WriteLine("Aperte ENTER para continuar;");
                    Console.ReadKey();
                break;

                case 3:
                    Console.Clear();
                    System.Console.WriteLine("Insira o nome do carro que irá sair...;");
                    nomedocarro= Console.ReadLine();
                    Saida(nomedocarro);
                    Console.ReadKey();

                break;
            }
            


        }while(controle!=0);
    }

    public void novo(Carro MeuCarro)
    {
        MeuCarro.Preencher();

        if (Inicio.proximo == null)
        {
            MeuCarro.fim=MeuCarro;
            MeuCarro.proximo=final;

            Inicio=MeuCarro;
            Novo=MeuCarro;
        }
        else
        {
            Novo.proximo=MeuCarro;

            Novo=MeuCarro;
            Inicio.fim=Novo;
            Novo.proximo=final;
        }
        


    }

    public void Saida(string meunome)
    {
        while (Inicio.nome != meunome)
        {
            FinalDaFila();
        }

        Excluir();
        System.Console.WriteLine("Saída de carro feita com êxito, aperte ENTER para continuar;");

    }
    public void Excluir()
    {
        Inicio=Inicio.proximo;
    }

    public void FinalDaFila()
    {
        Carro aux= new Carro();

        Novo.proximo=Inicio;
        aux.proximo=Inicio.proximo;

        Inicio.proximo=final;
        Novo=Inicio;
        Inicio= aux.proximo;
    }

    public int contar()
    {
        int contador=1;
        Carro aux= new Carro();
        aux= Inicio;

        while(aux.proximo!=null)
        {
            contador++;
            aux=aux.proximo;
        }
        return contador;
    }

    public int Fila()
    {
        int contador=1;
        Carro aux= new Carro();
        aux= Inicio;

        while(aux.proximo!=null)
        {
            if(contador<9 && aux!=final)
            System.Console.WriteLine($"{contador}. {aux.nome}");
            contador++;
            aux=aux.proximo;
        }
        if (aux.proximo == null)
        {
            System.Console.WriteLine($"{contador}. {aux.nome}");
        }
        return contador;
    }
}