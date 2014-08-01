namespace Sevendigital.learning.Tenniskata
{
	class ScoreBoard
	{
		private string _currentScore = "love:love";

		public string Display()
		{
			return _currentScore;
		}

		public void PlayerOneScores()
		{
			if (_currentScore.Equals("fifteen:love"))
			{
				_currentScore = "thirty:love";
				return;
			}
	
			if (_currentScore.Equals("thirty:love"))
			{
				_currentScore = "forty:love";
				return;
			}

			_currentScore = "fifteen:love";
		}

		public void PlayerTwoScores()
		{
			
		}
	}
}
