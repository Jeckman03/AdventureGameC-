using System;

namespace Adventure
{

	class MainClass {
  public static void Main (string[] args) {

		GameTitle();

		string characterName = NameCharacter();


    Console.ReadLine();
  }



	private static void GameTitle() 
	{
		Console.WriteLine("-------------------------");
		Console.WriteLine("\tAdventure Game!");
		Console.WriteLine("-------------------------");
		Console.WriteLine();
		Console.WriteLine("Shall we go on an adventure!");
		Console.WriteLine();
	}

	private static string NameCharacter()
	{
		string output;
		Console.Write("What is your name aventure: ");
		output = Console.ReadLine();
		Console.WriteLine();
		Console.WriteLine($"I wish you the best of luck during your journey { output }");
		return output;
	}
}
}

