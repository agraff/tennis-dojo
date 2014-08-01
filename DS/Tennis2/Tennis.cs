using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis2
{
	public class Tennis
	{
		public Tennis()
		{
			PlayerOne = CreateNewPlayer();
			PlayerTwo = CreateNewPlayer();
		}

		private static Player CreateNewPlayer()
		{
			return new Player { Score = "love" };
		}

		public Player PlayerOne { get; set; }
		public Player PlayerTwo { get; set; }

		public void ScorePoint(int winner)
		{
			if (winner == 1)
			{
				IncreaseScore(PlayerOne);
			}
			else
			{
				IncreaseScore(PlayerTwo);
			}
		}

		public string Score()
		{
			return "deuce";
		}

		private void IncreaseScore(Player player)
		{
			switch (player.Score)
			{
				case "love":
					player.Score = "fifteen";
					break;
				case "fifteen":
					player.Score = "thirty";
					break;
				case "thirty":
					player.Score = "forty";
					break;
			}
		}
	}
}
