namespace Tennis
{
	public class TennisGame
	{
		private readonly string[] _scores = new []{"love", "fifteen", "thirty", "fourty"};
		private int _playerAScore;
		private int _playerBScore;
		private string _winner;

		public string Score()
		{
			if (_playerAScore == 3 && _playerBScore == 3)
			{
				return "deuce";
			}

			if (!string.IsNullOrEmpty(_winner))
			{
				return _winner;
			}

			return string.Format("{0}-{1}", _scores[_playerAScore], _scores[_playerBScore]);
		}

		public void PlayerAPoint()
		{
			if (_playerAScore == 3)
			{
				_winner = "PlayerA Wins";
				return;
			}

			_playerAScore++;
		}

		public void PlayerBPoint()
		{
			if (_playerBScore == 3)
			{
				_winner = "PlayerB Wins";
				return;
			}

			_playerBScore++;
		}
	}
}