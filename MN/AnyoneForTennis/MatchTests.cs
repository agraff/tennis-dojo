using FluentAssertions;
using NUnit.Framework;

namespace AnyoneForTennis
{
	[TestFixture]
	public class MatchTests
	{
		[Test]
		public void PlayerOneWins()
		{
			var scoreBoard = new ScoreBoard();
			WinMatch(scoreBoard, Player.One);
			scoreBoard.GetWinner().Should().Be(Player.One);
		}

		[Test]
		public void PlayerTwoWins()
		{
			var scoreBoard = new ScoreBoard();
			WinMatch(scoreBoard, Player.Two);
			scoreBoard.GetWinner().Should().Be(Player.Two);
		}

		private static void WinMatch(ScoreBoard scoreBoard, Player player)
		{
			WinSet(scoreBoard, player);
			WinSet(scoreBoard, player);
		}

		private static void WinSet(ScoreBoard scoreBoard, Player player)
		{
			for (var i = 0; i < 6; i++)
			{
				WinGame(scoreBoard, player);
			}
		}

		private static void WinGame(ScoreBoard scoreBoard, Player player)
		{
			for (var i = 0; i < 4; i++)
				scoreBoard.AddPoint(player);
		}
	}
}


