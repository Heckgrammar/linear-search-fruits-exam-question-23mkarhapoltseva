namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
bool found = false;
		string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
		Console.WriteLine("What word would you like to find?");
		string tofind = Console.ReadLine();
		for ( int i = 0; i < fruits.Length; i++)
		{
			if (fruits[i].ToLower () == tofind.ToLower()) 
			{
				found = true; 
				break;
			}
		}
		if (found)  
		{
		Console.WriteLine("True");	
		}
		else 
		{
			Console.WriteLine("False");
		}
		
	}
}
            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
        }
    }
}
