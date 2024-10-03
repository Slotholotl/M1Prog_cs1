
namespace IntroProject
{
    internal class Program
    {
        string MydisplayName;
        int myAge;
        static void Main(string[] args)
        {
            Program myProgram= new Program();
            myProgram.Run();
             
        }

        internal Program()
        {
            //ken waardes toe aan de variabelen (assignement (=))
            MydisplayName = "Sloth";
            myAge = 20;//hier stellen we de leeftijd in
        }

        private void Run()
        {
            Console.WriteLine("hello!, let me introduce myself");
            Console.WriteLine("i'm " + MydisplayName);

            //vraag de waarde van myAge waar de vraagtekens staan
            string myAgeSentance = "i'm " + myAge + " years old";
            Console.WriteLine(myAgeSentance);//gebruik hier myAgeSentance 

        }
    }
}
