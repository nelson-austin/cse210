using System;
using System.Collections.Generic;

namespace Jumper
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        
        private bool _isPlaying = true;
        private Jumper _jumper = new Jumper();
        private Word _word = new Word();
        private TerminalService _terminalService = new TerminalService();

        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            _terminalService.WriteText($"The word is {_word.getWord()} ** SOLO FOR DEMO **");
            while (_isPlaying)
            {
                GetInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Promps the player to guess a letter.
        /// </summary>
        private void GetInputs()
        {
            _word.getGuess();
        }

        /// <summary>
        /// Checks the players guess and win/loss status.
        /// </summary>
        private void DoUpdates()
        {
            _word.testGuess();
            _word.updateHint();
            if (false == _word.testGuess())
            {
                _jumper.updateJumper();
            }
            bool loss = _jumper.checkLoss();
            bool win = _word.checkWin();
            if (win == false)
            {
                _terminalService.WriteText($"\nThanks for playing! You won!");
                _isPlaying = false;
            }
            if (loss == true)
            {
                _isPlaying = false;
                _terminalService.WriteText($"\nGame over! The word was {_word.getWord()}!");
            }

        }

        /// <summary>
        /// Displays parachute and the hint with any letters that have been guessed.
        /// </summary>
        private void DoOutputs()
        {
            _jumper.displayJumper();
            _word.displayHint();
        }
    }
}