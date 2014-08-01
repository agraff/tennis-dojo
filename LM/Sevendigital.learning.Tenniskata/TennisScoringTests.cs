using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			string currentScore = scoreBoard.Display();
			//Then			
			Assert.That(currentScore,Is.EqualTo("love:love"));
		}
    }
}
