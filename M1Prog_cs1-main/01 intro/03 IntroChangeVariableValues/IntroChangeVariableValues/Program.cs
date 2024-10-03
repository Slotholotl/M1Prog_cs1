
namespace IntroChangeVariableValues
{
    internal class Program
    {
        private string myFavoriteCity;
        private int myFavoriteNumber;
        private bool displayNumber;
        private string characterName;
        private DateTime currentTime;


        static void Main(string[] args)
        {
            Program program = new Program();
            program.Run();
        }

        private void Run()
        {
            string character1 = "mario";
            string character2 = "luigi";
            string city = "Amsterdam";
            int num = 15;

            string city2 = "Zaandam";
            int num2 = 243;
            characterName = character1;
            currentTime= DateTime.Now;
            myFavoriteCity = city; //geef hier myFavoriteCity een waarde 
            myFavoriteNumber = num; //geef hier myFavoriteNumber een waarde 
            displayNumber = true; //zet displayNumber op true
            Display();

            //nu gaan we de waarden instellen voor luigi, gebruik andere waardes

            characterName = character2;
            currentTime = DateTime.Now;//zoek op hoe je de huidige tijd kan krijgen (DateTime.???)
            myFavoriteCity = city2; //geef hier myFavoriteCity een waarde 
            myFavoriteNumber = num2; //geef hier myFavoriteNumber een waarde 
            displayNumber = true; //zet displayNumber op false
            Display();
        }

        private void Display()
        {
            Console.WriteLine("hi i'm "+characterName);
            Console.WriteLine("it is now " + currentTime);

            Console.WriteLine("my favorite city is:");
            Console.WriteLine(myFavoriteCity);
            if (displayNumber)
            {
                Console.WriteLine("my favorite number is:");
                Console.WriteLine(myFavoriteNumber);
            }
        }
    }
}
