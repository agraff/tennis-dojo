namespace AnyoneForTennis
{
	public class ScoreBoard 
	{
		private readonly int[] _points = new int[2];

		public Player GetWinner()
		{
			if (_points[(int) Player.One] > 0)
			{
				return Player.One;
			}

			return Player.Two;
		}

		public void AddPoint(Player player)
		{
			_points[(int)player] ++;
		}
	}

	public enum Player
    {
        One = 0,
        Two = 1
    }
}