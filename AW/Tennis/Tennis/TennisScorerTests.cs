﻿using NUnit.Framework;

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
		public void Scores_fifteen_love_if_player_A_scores_one_point_and_player_B_scores_none()
		{
			_runningScore = _tennisScorer.RunningScoreFor(1,0);
			Assert.That(_runningScore, Is.EqualTo("Fifteen love"));
		}

		[Test]
		public void Scores_thirty_fifteen_if_player_A_scores_two_points_and_player_B_scores_one()
		{
			_runningScore = _tennisScorer.RunningScoreFor(2, 1);
			Assert.That(_runningScore, Is.EqualTo("Thirty fifteen"));
		}

		[Test]
		public void Scores_forty_thirty_if_player_A_scores_three_points_and_player_B_scores_two()
		{
			_runningScore = _tennisScorer.RunningScoreFor(3, 2);
			Assert.That(_runningScore, Is.EqualTo("Forty thirty"));
		}

		[Test]
		public void Player_A_wins_if_player_A_scores_at_least_four_points_and_player_B_is_two_points_behind()
		{
			_runningScore = _tennisScorer.RunningScoreFor(4, 0);
			Assert.That(_runningScore, Is.EqualTo("Player A wins! :-)"));
		}
	}
}
