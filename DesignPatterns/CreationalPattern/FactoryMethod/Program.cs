namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod factoryMethod = new FactoryMethod();

            Console.WriteLine("Liu Kang | SubZero | Scorpion");
            Console.WriteLine();
            
            Console.WriteLine("Escolha seu personagem: ");

            string choose = Console.ReadLine();

            ICharacter character = factoryMethod.ChooseCharacter(choose);

            Console.WriteLine();
            Console.WriteLine("Você vai jogar com ");

            character.Choosed();

            Console.ReadKey();
        }
    }
}
