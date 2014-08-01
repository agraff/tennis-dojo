namespace Tennis
{
	public class Player
	{
		public int Score { get; private set; }

		public void ScorePoint()
		{
			Score++;
		}
	}

	public class TennisGame
	{
		private readonly string[] _scores = new[] { "love", "fifteen", "thirty", "fourty" };
		private readonly Player _playerA;
		private readonly Player _playerB;

		public TennisGame(Player playerA, Player playerB)
		{
			_playerA = playerA;
			_playerB = playerB;
		}

		public string Score()
		{
			if (_playerA.Score == 3 && _playerB.Score == 3)
			{
				return "deuce";
			}

			if (_playerA.Score == 4)
			{
				return "PlayerA Wins";
			}
			if (_playerB.Score == 4)
			{
				return "PlayerB Wins";
			}

			return string.Format("{0}-{1}", _scores[_playerA.Score], _scores[_playerB.Score]);
		}
	}
}