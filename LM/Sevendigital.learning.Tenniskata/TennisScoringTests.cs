using NUnit.Framework;

namespace Sevendigital.learning.Tenniskata
{
	[TestFixture]
    public class TennisScoringTests
    {
		[TestCase(0, "love:love")]
		[TestCase(1, "fifteen:love")]
		[TestCase(2, "thirty:love")]
		[TestCase(3, "forty:love")]
		public void calculates_score_for(int playerOnePoints, string expectedResult)
		{
			var scoreBoard = new ScoreBoard();
			for(var i = 0; i < playerOnePoints; i++)
				scoreBoard.PlayerAScores();

			var currentScore = scoreBoard.Display();

			Assert.That(currentScore, Is.EqualTo(expectedResult));
		}
    }
}
