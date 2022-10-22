using System;
using System.Collections.Generic;
using System.IO;

namespace Jumper 
{
    /// <summary>
    /// Word class handles everything related to the word.
    /// </summary>
    public class Word
    {
        private string _word;
        private string _hint;
        private TerminalService _terminalService = new TerminalService();

        private string _guess;
        /// <summary>
        /// Constructs a new instance of Word.
        /// </summary>
        public Word()
        {
            readFile();
            _hint = makeHint(_word);
            _terminalService.WriteText(_hint);
        }

        /// <summary>
        /// Reads from words.txt and chooses a random word.
        /// </summary>
        public string readFile()
        {
            List<string> words = new List<string>(File.ReadLines(@"game\words.txt"));

            Random random = new Random();
            _word = words[random.Next(words.Count + 1)];
            return _word;
        }
        /// <summary>
        /// Uses the word as a parameter to create the string.
        /// </summary>
        public string makeHint(string word)
        {
            string activeWord = "";
            for (int i = 0; i < word.Length; i++)
            {
                activeWord += "-";
            }
            return activeWord;
        }  

        /// <summary>
        /// Prompts the player to make a guess.
        /// </summary>
        public string getGuess()
        {
            _guess = _terminalService.ReadText("Choose any letter (a-z):");
            return _guess;
        }
        /// <summary>
        /// Tests to see if the guess is found in the word.
        /// </summary>
        public bool testGuess()
        {
            bool result = _word.Contains(_guess);
            return result;
        }
        
        /// <summary>
        /// Updates hint if the player guessed correctly.
        /// </summary>
        public string updateHint()
        {
            int i = 0;
            foreach (char letter in _word)
            {
                if (_guess.ToLower() == letter.ToString())
                {
                    char[] ch = _hint.ToCharArray();
                    ch[i] = letter;
                    _hint = string.Join("", ch);
                }
                i += 1;
            }
            return _hint;
        }
        /// <summary>
        /// Displays the new and updated hints.
        /// </summary>
        public void displayHint()
        {
            _terminalService.WriteText(_hint);
        }
        /// <summary>
        /// Checks to see if the player won.
        /// </summary>
        public bool checkWin()
        {
            return (_hint.Contains("-"));
        }
        /// <summary>
        /// Returns the word to be used in the Director class.
        /// </summary>
        public string getWord()
        {
            return _word;
        }
    }
}