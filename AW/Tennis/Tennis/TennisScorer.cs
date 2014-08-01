using System.Collections.Generic;

namespace Tennis
{
	public class TennisScorer
	{
		public string RunningScoreFor(int playerOneScore, int playerTwoScore)
		{
			var scoreNames = new Dictionary<int, string>
				                 {
					                 { 0, "Love" },
					                 { 1, "Fifteen" },
					                 { 2, "Thirty" },
					                 { 3, "Forty" },
				                 };

			return scoreNames[playerOneScore] + " " + scoreNames[playerTwoScore].ToLower();
		}
	}
}