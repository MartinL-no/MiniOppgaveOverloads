namespace MiniOppgaveOverloads;

class Program
{
    static void Main(string[] args)
    {
        PrintWelcomeMessage();
        PrintWelcomeMessage("Martin");
    }
    static void PrintWelcomeMessage(string name = "Terje")
    {
        Console.WriteLine($"Hei og velkommen {name}");
    }
}

