using NUnit.Framework;

namespace Sevendigital.learning.Tenniskata
{
	[TestFixture]
    public class TennisScoringTests
    {
		[Test]
		public void first_score_love_all()
		{
			//Given
			var scoreBoard = new ScoreBoard();
			//When
			var currentScore = scoreBoard.Display();
			//Then			
			Assert.That(currentScore,Is.EqualTo("love:love"));
		}

		[Test]
		public void when_player_a_wins_a_point_score_fifteen_love()
		{			
			var scoreBoard = new ScoreBoard();
			scoreBoard.PlayerAScores();
			var currentScore = scoreBoard.Display();
			Assert.That(currentScore,Is.EqualTo("fifteen:love"));
		}
		
		[Test]
		public void when_player_a_wins_two_points_score_thirty_love()
		{			
			var scoreBoard = new ScoreBoard();
			scoreBoard.PlayerAScores();
			scoreBoard.PlayerAScores();
			var currentScore = scoreBoard.Display();
			Assert.That(currentScore,Is.EqualTo("thirty:love"));
		}
    }
}
