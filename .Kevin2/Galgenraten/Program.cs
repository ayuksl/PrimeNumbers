using Galgenraten;

public class Program
{
    

    public static void Main(string[] args)
    {

        Game game = new Game(@".\wortliste.txt", 10, 0);

        
        game.Run();

        //Menu.RunMenu();

        



        //string answer ;
        //Console.WriteLine("Would you like to make another run?(y/n)");
        //string answer = Console.ReadLine() ?? "";
        //while (answer == "y")
        //{
            //game.Run();
        //}
         
    }


}