namespace AnyoneForTennis
{
	public class ScoreBoard
	{
		private readonly Player _player1;
		private readonly Player _player2;

		public ScoreBoard(Player player1, Player player2)
		{
			_player1 = player1;
			_player2 = player2;
		}

		public Player GetWinner()
		{
			if (_player1.Points > 1)
			{
				return _player1;
			}

			if (_player2.Points > 1)
			{
				return _player2;
			}

			return new NoPlayer();
		}

		public void AddPoint(Player player)
		{
			player.AddPoint();
		}
	}

	public class Player
	{
		public int Points { get; private set; }
		public void AddPoint()
		{
			Points++;
		}
	}

	public class NoPlayer : Player
	{
	}
}