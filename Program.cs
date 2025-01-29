using HangManFun;

HangManTools ht = new HangManTools();

string solution = "";
string guess = "";
string lettersGuessed = "";
int incorrectGuesses = 0;

bool gameOver = false; 

// welcome the user
Console.WriteLine("Welcome to hangggmensch");

// Get a random word for the user to guess

Console.WriteLine("Generating a random word");
Thread.Sleep(200);

solution = ht.GetRandomWord();
Console.WriteLine();


do
{
//Get user's guess
    Console.WriteLine("Please enter a letter");

    do
    {
        guess = Console.ReadLine();

    } while (ht.ValidGuess(guess, lettersGuessed));
    lettersGuessed += guess;

// check to see if the letter is in the word 
    if (solution.Contains(guess))
    {
        Console.WriteLine("Yes the letter " + guess + " is in the word!");
        if (ht.UpdateWord(lettersGuessed, solution) == solution)
        {
            Console.WriteLine("You won");
            gameOver = true;
            
        }
    }
    else // guess was incorrect 
    {
        Console.WriteLine($"Sorry, the word does not have the letter {guess}");
        incorrectGuesses++;

        if (incorrectGuesses < 6)
        {
            Console.WriteLine($"You have {6 - incorrectGuesses} guesses left");

        }
        if (incorrectGuesses >= 6)
        {
            Console.WriteLine($"Sorry you lost://");
            gameOver = true;
        }
    }
    
    Console.WriteLine("Word: " + ht.UpdateWord(lettersGuessed, solution));
    
} while (gameOver == false);

Console.WriteLine("Thanks for playing!:()");



Console.WriteLine("Press any key to exit Reiner...");



