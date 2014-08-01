using System.Collections.Generic;

namespace Tennis
{
	public class TennisScorer
	{
		public string RunningScoreFor(int playerAScore, int playerBScore)
		{			
			var scoreNames = new Dictionary<int, string>
				                 {
					                 { 0, "Love" },
					                 { 1, "Fifteen" },
					                 { 2, "Thirty" },
					                 { 3, "Forty" },
				                 };

			if ((playerAScore >= 4) && (playerAScore - playerBScore >= 2))
			{
				return "Player A wins! :-)";
			}
			return scoreNames[playerAScore] + " " + scoreNames[playerBScore].ToLower();
		}
	}

	//if_player_A_scores_at_least_four_points_and_player_B_is_two_points_behind
}