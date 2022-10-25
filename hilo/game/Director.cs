using System;

namespace Hilo 
{

    public class Director
    {
        private bool _isPlaying = true;
        
        private Card _card = new Card();
        private TerminalService _terminalServices = new TerminalService();
        public Director()
        {

        }
        public void startGame()
        {
            while (_isPlaying)
            {
                getInputs();
                doUpdates();
                doOutputs();
            }
        }
        private void getInputs()
        {
            _terminalServices.WriteText($"\nThe card is: {_card.displayFirstCard()}");
            _card.getGuess();
            int newCard = _card.generateCard();
            _terminalServices.WriteText($"Next card was: {newCard}");
        }
        private void doUpdates()
        {
            _card.updatePoints();
        }
        private void doOutputs()
        {
            if (_card.gameOver())
            {
                _isPlaying = false;
                _terminalServices.WriteText($"Game over.. you have {_card.displayPoints()} points left");
            }
            _terminalServices.WriteText($"Your score is {_card.displayPoints()}");

            bool answer = _card.continueGame();
            if (answer == false)
            {
                _isPlaying = false;
            }
        }
    }
}