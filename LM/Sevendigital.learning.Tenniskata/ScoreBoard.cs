using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sevendigital.learning.Tenniskata
{
	class ScoreBoard
	{
		private string _currentScore = "love:love";

		public string Display()
		{
			return _currentScore;
		}

		public void PlayerAScores()
		{
			if (_currentScore.Equals("fifteen:love"))
			{
				_currentScore = "thirty:love";
				return;
			}

			_currentScore = "fifteen:love";
		}
	}
}
