using NUnit.Framework;

namespace Tennis
{
	public class TennisTests
	{
		private TennisGame _tennisGame;
		private Player _playerA;
		private Player _playerB;

		[SetUp]
		public void Before_each()
		{
			_playerA = new Player();
			_playerB = new Player();
			_tennisGame = new TennisGame(_playerA, _playerB);
		}

		[TestCase(0, 0, "love-love")]
		[TestCase(1, 0, "fifteen-love")]
		[TestCase(2, 0, "thirty-love")]
		[TestCase(3, 0, "fourty-love")]
		[TestCase(4, 0, "PlayerA Wins")]
		[TestCase(0, 1, "love-fifteen")]
		[TestCase(0, 2, "love-thirty")]
		[TestCase(0, 3, "love-fourty")]
		[TestCase(0, 4, "PlayerB Wins")]
		[TestCase(2, 1, "thirty-fifteen")]
		[TestCase(3, 3, "deuce")]
		[TestCase(4, 3, "advantage PlayerA")]
		[TestCase(3, 4, "advantage PlayerB")]
		public void Score_is_as_expected_when_players_score_n_points(int playerAScore, int playerBScore, string expected)
		{
			PlayerAScoresN(playerAScore);
			PlayerBScoresN(playerBScore);

			Assert.That(_tennisGame.Score(), Is.EqualTo(expected));
		}

		void PlayerAScoresN(int times)
		{
			for (int i = 0; i < times; i++)
			{
				_playerA.ScorePoint();
			}
		}

		void PlayerBScoresN(int times)
		{
			for (int i = 0; i < times; i++)
			{
				_playerB.ScorePoint();
			}
		}
	}
}
