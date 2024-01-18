// See https://aka.ms/new-console-template for more information


// collecting user input as arguments

class HelloW
{
   public static void  Main (string[] args)
    {
        if (args.Length <= 0)
        {
            // displaying Hello World
            Console.WriteLine("Hello World");
        }
        else
        {
            Console.Write("Hello Stranger");
        }
    }
}

//Preventing the console to auto close when running .exe
//Console.ReadKey();
