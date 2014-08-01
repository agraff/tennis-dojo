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

			if (_playerA.Score >= 4)
			{
				if (PlayerIsTwoPointsClear(_playerA, _playerB))
				{
					return "PlayerA Wins";
				}
				else if (PlayerIsOnePointClear(_playerA, _playerB))
				{
					return "advantage PlayerA";
				}
				else
				{
					return "deuce";
				}
			}
			if (_playerB.Score >= 4)
			{
				if (PlayerIsTwoPointsClear(_playerB, _playerA))
				{
					return "PlayerB Wins";
				}
				else if (PlayerIsOnePointClear(_playerB, _playerA))
				{
					return "advantage PlayerB";
				}
				else
				{
					return "deuce";
				}
			}

			return string.Format("{0}-{1}", _scores[_playerA.Score], _scores[_playerB.Score]);
		}

		private bool PlayerIsOnePointClear(Player firstPlayer, Player secondPlayer)
		{
			return firstPlayer.Score - secondPlayer.Score == 1;
		}

		private bool PlayerIsTwoPointsClear(Player firstPlayer, Player secondPlayer)
		{
			return firstPlayer.Score - secondPlayer.Score > 1;
		}
	}
}