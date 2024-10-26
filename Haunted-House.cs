using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("This is a game made by, EPICMORTAMIS");
        Console.WriteLine("Welcome to the Haunted House Adventure!");
        Console.WriteLine("You find yourself in front of a spooky, old house.");
        Console.WriteLine("Do you want to enter? (yes/no)");

        string choice = Console.ReadLine().ToLower();

        if (choice == "yes")
        {
            Console.WriteLine("You cautiously enter the house.");
            ExploreHouse();
        }
        else
        {
            Console.WriteLine("You decide not to enter and leave the area.");
            Console.WriteLine("GAME OVER...");
        }
    }

    static void ExploreHouse()
    {
        Console.WriteLine("You are inside the dark and eerie house.");
        Console.WriteLine("You see two doors in front of you, one on the left and one on the right.");
        Console.WriteLine("Which door do you want to go through? (left/right)");

        string choice = Console.ReadLine().ToLower();

        if (choice == "left")
        {
            Console.WriteLine("You enter the left room and find a treasure chest!");
            Console.WriteLine("It opens and a ghost decides to come out and kill you!");
            Console.WriteLine("GAME OVER...");
        }
        else if (choice == "right")
        {
            Console.WriteLine("You enter the right room and encounter a ghost!");
            Console.WriteLine(" ");
            Console.WriteLine("The ghost scares you away.");
            Console.WriteLine(" ");
            Console.WriteLine("As you are running, a rock gets thrown from beside and trips you over.");
            Console.WriteLine(" ");
            Console.WriteLine("The ghost sudently comes jumping at you!");
            Console.WriteLine(" ");
            Console.WriteLine("FWOOSH!!!!");
            Console.WriteLine(" ");
            Console.WriteLine("You feel an arm tight grabing on to you.");
            Console.WriteLine(" ");
            Console.WriteLine("It pulls you into the other room.");
            Console.WriteLine(" ");






        }
        else
        {
            Console.WriteLine("Invalid choice. Please enter 'left' or 'right'.");
            ExploreHouse();
        }
    }
}

