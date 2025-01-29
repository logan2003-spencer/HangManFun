namespace HangManFun;

internal class HangManTools
{
    public string GetRandomWord()
    {

        Random r = new Random();

        string word = "";
        // dynamic array, type string that is called words and 
        // then initialize it as an object, that's why you need () in case
        // there is a constructor
        List<string> words = new List<string>()
        {
            "maid",
            "stranger",
            "Erwin",
            "tough",
            "toenails"
        };
        
        // get a random word 
        word = words[r.Next(words.Count)];

        return word;
    }

    public bool ValidGuess(string guess, string lettersGuessed)
    {
        bool result = true; // default to a valid guiess 

        if (guess.Length != 1) // check for only one character 
        {
            Console.WriteLine("Sorry, the guess can only be one letter");
            result = false;
        }
        
        // go into the guess string and go to the first character in the string.
        
        else if (!Char.IsLetter(guess[0])) // check to make sure it is a letter 
        {
            Console.WriteLine("Sorry the guess needs to be betterrrrr");
            result = false;
        }
        else if (lettersGuessed.Contains(guess))// check if letter has already been guessed
        {
            Console.WriteLine("Sorry, you already guessed that letter");
        }
        return result;
    }

    public string UpdateWord(string lg, string solution)
    {
        string result = "";
        for (int i = 0; i < solution.Length; i++)
        {
            if (lg.Contains(solution[i])) // Is the letter in the list 
            {
                result += solution[i];
            }
            else
            {
                result = result + "_";
            }
        }
        
        return result;
    }
}