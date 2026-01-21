namespace clear
{
   public class elemento
{
    public int valor {get;set;}

    public elemento prox {get;set;}    

    public elemento(int x= 0)
    {
        valor= x;
        prox=null;
    }

    public void ToString()
    {System.Console.WriteLine($"Valor: {valor}\n--------------");
        
    }



} 


}
