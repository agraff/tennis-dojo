using FluentAssertions;
using NUnit.Framework;

namespace AnyoneForTennis
{
	[TestFixture]
	public class MatchTests
	{
		private Player _player1;
		private Player _player2;
		private ScoreBoard _scoreBoard;

		[SetUp]
		public void Setup()
		{
			_player1 = new Player();
			_player2 = new Player();
			_scoreBoard = new ScoreBoard(_player1, _player2);
		}

		[Test]
		public void Player_1_should_win_if_she_wins_2_sets_6_love()
		{
			WinMatch(_scoreBoard, _player1);
			_scoreBoard.GetWinner().Should().Be(_player1);
		}

		[Test]
		public void Player_2_should_win_if_she_wins_2_sets_6_love()
		{
			WinMatch(_scoreBoard, _player2);
			_scoreBoard.GetWinner().Should().Be(_player2);
		}

		[Test]
		public void There_should_be_no_winner_after_one_point()
		{
			_scoreBoard.AddPoint(_player1);

			_scoreBoard.GetWinner().Should().BeOfType<NoPlayer>();
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
			{
				scoreBoard.AddPoint(player);
			}
		}
	}
}


