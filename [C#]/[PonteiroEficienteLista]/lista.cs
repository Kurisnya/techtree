namespace clear
{
    public class lista
    {
        
        elemento primeiro {get;set;}
        elemento ultimo {get;set;}


        //[CONSTRUTOR]
        //ELEMENTO 1(Leia o Readme para entender os elementos)
        //O construtor define que o ''primeiro'' e o ''ultimo''
        //são iguais a um novo elemento nulo;
        public lista()
        {
            primeiro = ultimo = new elemento();
        }


        //[INSERIR FIM]
        //ELEMENTO 2(Leia o Readme para entender os elementos)
        //O elemento escolhido vai para o fim, só isso;
        public void InserirFim(elemento x)
        {
            ultimo.prox = x;
            ultimo = ultimo.prox;
        }

        //[IMPRIMIR] (Para esse modelo de ponteiro, a impressão funciona na seguinte ordem:)
        public void imprimir()
        {
            elemento i= primeiro;
            do
            {
                i= i.prox;
                System.Console.WriteLine(i.valor);
                
            }
            while(i.prox != null);

        }

        //[CRIAR NOVO ELEMENTO]
        public elemento NovoElemento()
        {
            elemento x = new elemento();
            System.Console.WriteLine("Insira o valor desejado:");
            x.valor= int.Parse(Console.ReadLine());
            return x;
        }
    }
}