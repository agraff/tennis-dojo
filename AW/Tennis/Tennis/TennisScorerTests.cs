using NUnit.Framework;

namespace Tennis
{
	[TestFixture]
	public class TennisScorerTests
	{
		private string _runningScore;
		private TennisScorer _tennisScorer;

		[SetUp]
		public void SetUp()
		{
			_tennisScorer = new TennisScorer();
		}

		[Test]
		public void Scores_fifteen_love_if_player_one_scores_one_point_and_player_two_scores_none()
		{
			_runningScore = _tennisScorer.RunningScoreFor(1,0);
			Assert.That(_runningScore, Is.EqualTo("Fifteen love"));
		}

		[Test]
		public void Scores_thirty_fifteen_if_player_one_scores_two_points_and_player_two_scores_one()
		{
			_runningScore = _tennisScorer.RunningScoreFor(2, 0);
			Assert.That(_runningScore, Is.EqualTo("Thirty love"));
		}

		[Test]
		public void Scores_forty_thirty_if_player_one_scores_three_points_and_player_two_scores_two()
		{
			_runningScore = _tennisScorer.RunningScoreFor(3, 0);
			Assert.That(_runningScore, Is.EqualTo("Forty love"));
		}
	}
}
