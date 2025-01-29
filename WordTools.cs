namespace HangManFun;


    internal class WordTools
    {
        public int WordCounter(string words)
        {
            int wordCount = 0;
            
            // split string into separate words to make it easier to count
            string[] individualWords = words.Split(" ");

            wordCount = individualWords.Length;

            return (wordCount);
        }

        public int CharacterCounter(string words)
        {
            int characterCount = 0;
            
            characterCount = words.Length;
            
            return characterCount;
        }

        public void AlphabetCounter(string words)
        {
            // loop through the entire string
            int[] letters = new int[26]; // for the alphabet, beginning with 'a'and going to 'z'

            for (int i = 0; i < words.Length; i++)
            {
                
                char c = words[i];

                c = char.ToLower(c);
                
                // check to make sure it is a lower case letter 
                if (c >= 97 && c <= 122)
                {
                    letters[(c - 97)]++;
                }
            }

            for (int i = 0; i < letters.Length; i++)
            {
                // have to change both i and 97 to char
                char letter = (char)(i + 97);
                
                Console.WriteLine(letter + ": " + letters[i]);
                
            }
        }
    }
