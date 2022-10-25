using System;

namespace Hilo
{
    public class Card
    {
        private int _points = 300;
        private string _guess;
        private bool _isPlaying = true;
        private bool _gameOver = false;
        Random rnd = new Random();
        private int _firstCard;
        private int _secondCard;
        private TerminalService _terminalServices = new TerminalService();
        public Card()
        {
            _firstCard = rnd.Next(1, 13);

        }
        public int displayFirstCard()
        {
            return _firstCard;
        }
        public int generateCard()
        {
            _secondCard = rnd.Next(1, 13);
            while (_firstCard == _secondCard)
            {
                _secondCard = rnd.Next(1, 13);
            }
            return _secondCard;
        }
        public string getGuess()
        {
            _guess = _terminalServices.ReadText("Higher or lower? [h/l] ");
            return _guess;
        }
        public int updatePoints()
        {
            if (_firstCard > _secondCard)
            {
                if (_guess.ToLower() == "l")
                {
                _points += 50;
                } else
                {
                    _points -= 100;
                }
            } else 
            {
                if (_guess.ToLower() == "h")
                {
                    _points += 50;
                } else
                {
                    _points -= 100;
                }
            }
            return _points;
        }
        public int displayPoints()
        {
            return _points;
        }
        public bool continueGame()
        {
            _firstCard = _secondCard;

            if (_terminalServices.ReadText("Play again? [y/n] ").ToLower() == "n")
            {
                _isPlaying = false;
            }
            return _isPlaying;

        }
        public bool gameOver()
        {
            if (_points <= 0)
            {
                _gameOver = true;
            }
            return _gameOver;
        }
    }
}