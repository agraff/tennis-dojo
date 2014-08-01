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
		public void Player_one_should_start_with_score_love()
		{
			Assert.That(_tennis.PlayerTwo.Score, Is.EqualTo("love"));
		}

		[Test]
		public void Player_two_should_start_with_score_love()
		{
			Assert.That(_tennis.PlayerTwo.Score, Is.EqualTo("love"));
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
		public void Should_increase_player_one_score_to_forty_if_they_win_3_points()
		{
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);

			Assert.That(_tennis.PlayerOne.Score, Is.EqualTo("forty"));
		}

		[Test]
		public void Should_increase_player_two_score_to_forty_if_they_win_3_points()
		{
			_tennis.ScorePoint(2);
			_tennis.ScorePoint(2);
			_tennis.ScorePoint(2);

			Assert.That(_tennis.PlayerTwo.Score, Is.EqualTo("forty"));
		}

		[Test]
		public void Should_set_both_players_scores_to_deuce_if_both_players_reach_3_points()
		{
			_tennis.ScorePoint(2);
			_tennis.ScorePoint(2);
			_tennis.ScorePoint(2);

			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);
;
			Assert.That(_tennis.Score(), Is.EqualTo("deuce"));
		}

		[Test]
		public void Should_set_score_to_fifteen_fifteen_if_each_player_scores_one_point()
		{
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(2);

			Assert.That(_tennis.Score(), Is.EqualTo("fifteen fifteen"));
		}

		[Test]
		public void Should_set_score_to_thirty_fifteen_if_player_one_scores_two_points_and_player_two_scores_one_point()
		{
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(2);

			Assert.That(_tennis.Score(), Is.EqualTo("thirty fifteen"));
		}

		[Test]
		public void Score_is_game_if_player_one_scores_four_and_player_two_scores_at_least_two_points_less()
		{
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);

			Assert.That(_tennis.Score(), Is.EqualTo("game"));
		}

		[Test, Ignore("Work in progress.")]
		public void Score_is_forty_thirty_if_player_one_scores_four_and_player_two_scores_three()
		{
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);
			_tennis.ScorePoint(1);

			_tennis.ScorePoint(2);
			_tennis.ScorePoint(2);

			Assert.That(_tennis.Score(), Is.EqualTo("forty thirty"));
		}
	}
}