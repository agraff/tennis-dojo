using NUnit.Framework;

namespace Sevendigital.learning.Tenniskata
{
	[TestFixture]
    public class TennisScoringTests
    {
		[TestCase(0, 0, "love:love")]
		[TestCase(1, 0, "fifteen:love")]
		[TestCase(1, 1, "fifteen:fifteen")]
		[TestCase(2, 0, "thirty:love")]
		[TestCase(3, 0, "forty:love")]
		public void calculates_score_for(int playerOnePoints, int playerTwoPoints, string expectedResult)
		{
			var scoreBoard = new ScoreBoard();
			for(var i = 0; i < playerOnePoints; i++)
				scoreBoard.PlayerOneScores();
			
			for(var i = 0; i < playerTwoPoints; i++)
				scoreBoard.PlayerTwoScores();

			var currentScore = scoreBoard.Display();

			Assert.That(currentScore, Is.EqualTo(expectedResult));
		}
    }
}
