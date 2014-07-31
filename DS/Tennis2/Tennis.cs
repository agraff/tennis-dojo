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
			PlayerOne = new Player();
			PlayerTwo = new Player();
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

		private void IncreaseScore(Player player)
		{
			switch (player.Score)
			{
				case null:
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
