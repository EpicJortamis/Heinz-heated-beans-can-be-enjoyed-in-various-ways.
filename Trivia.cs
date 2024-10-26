class FactGame
{
    static void Main()
    {
        // Define an array of facts to ask the player about
        string[] facts = {
            "What is the capital of France?",
            "What is the largest organ in the human body?",
            "Who invented the telephone?",
            "What is the smallest country in the world?",
            "What is the only mammal capable of sustained flight?",
            "What is the only continent that does not have a desert?",
            "What is the tallest mountain in the world?"
        };

        // Define an array of answers corresponding to the facts
        string[] answers = {
            "Paris",
            "Skin",
            "Alexander Graham Bell",
            "Vatican City",
            "Bat",
            "Europe",
            "Mount Everest"
        };

        // Seed the random number generator
        Random rand = new Random();
        List<int> usedRandoms = new List<int>();

        // Loop through the facts and quiz the player
        for (int i = 0; i < facts.Length; i++)
        {
            // Generate a random index to choose a fact to ask
            int index = rand.Next(facts.Length);
            while (usedRandoms.Contains(index))
            {
                index = rand.Next(facts.Length);
            }
            
            usedRandoms.Add(index);
            // Ask the player the randomly chosen fact
            Console.WriteLine(facts[index]);

            // Get the player's answer
            string input = Console.ReadLine();

            // Check if the player's answer is correct
            if (input.ToLower().Trim() == answers[index].ToLower().Trim())
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. The answer is: " + answers[index]);
            }
        }

        Console.WriteLine("Thanks for playing!");
    }
}; ;
