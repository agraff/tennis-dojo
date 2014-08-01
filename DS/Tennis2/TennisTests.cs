using NUnit.Framework;

namespace Tennis2
{
	public class TennisTests
	{
		private Tennis _tennis;

		[SetUp]
		public void SetUp()
		{
			_tennis = new Tennis();
		}

		[Test]
		public void Should_increase_player_one_score_to_fifteen_if_they_win_a_point()
		{
			_tennis.ScorePoint(winner: 1);

			Assert.That(_tennis.PlayerOne.Score, Is.EqualTo("fifteen"));
		}

		[Test]
		public void Should_increase_player_two_score_to_fifteen_if_they_win_a_point()
		{
			_tennis.ScorePoint(winner: 2);

			Assert.That(_tennis.PlayerTwo.Score, Is.EqualTo("fifteen"));
		}

		[Test]
		public void Should_increase_player_one_score_to_thirty_if_they_win_2_points()
		{
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);

			Assert.That(_tennis.PlayerOne.Score, Is.EqualTo("thirty"));
		}

		[Test]
		public void Should_increase_player_two_score_to_thirty_if_they_win_2_points()
		{
			_tennis.ScorePoint(2);
			_tennis.ScorePoint(2);

			Assert.That(_tennis.PlayerTwo.Score, Is.EqualTo("thirty"));
		}

		[Test]
		public void Should_increase_player_one_score_to_forty_if_they_win_2_points()
		{
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);

			Assert.That(_tennis.PlayerOne.Score, Is.EqualTo("forty"));
		}

		[Test]
		public void Should_increase_player_two_score_to_forty_if_they_win_2_points()
		{
			_tennis.ScorePoint(2);
			_tennis.ScorePoint(2);
			_tennis.ScorePoint(2);

			Assert.That(_tennis.PlayerTwo.Score, Is.EqualTo("forty"));
		}
	}
}