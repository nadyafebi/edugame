using UnityEngine;
using System.Collections;

public class dreamloLeaderBoard : MonoBehaviour {
	
	string dreamloWebserviceURL = "http://dreamlo.com/lb/";
	
	public string privateCode = "";
	public string publicCode = "";
	
	////////////////////////////////////////////////////////////////////////////////////////////////
	
	// A player named Carmine got a score of 100. If the same name is added twice, we use the higher score.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/100

	// A player named Carmine got a score of 1000 in 90 seconds.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/1000/90
	
	// A player named Carmine got a score of 1000 in 90 seconds and is Awesome.
 	// http://dreamlo.com/lb/(your super secret very long code)/add/Carmine/1000/90/Awesome
	
	////////////////////////////////////////////////////////////////////////////////////////////////
	
	
	public struct Score {
		public string playerName;
		public int score;
		public int seconds;
		public string shortText;
	}
	
	public static dreamloLeaderBoard GetSceneDreamloLeaderboard()
	{
		GameObject go = GameObject.Find("dreamloLeaderboard");
		
		if (go == null) return null;
		
		return go.GetComponent<dreamloLeaderBoard>();
	}
	
	public void AddScore(string playerName, int totalScore)
	{
		StartCoroutine(AddScoreWithPipe(playerName, totalScore));
	}
	
	public void AddScore(string playerName, int totalScore, int totalSeconds)
	{
		StartCoroutine(AddScoreWithPipe(playerName, totalScore, totalSeconds));
	}
	
	public void AddScore(string playerName, int totalScore, int totalSeconds, string shortText)
	{
		StartCoroutine(AddScoreWithPipe(playerName, totalScore, totalSeconds, shortText));
	}
	
	// This function saves a trip to the server. Adds the score and retrieves results in one trip.
	IEnumerator AddScoreWithPipe(string playerName, int totalScore)
	{
		playerName = Clean(playerName);
		
		WWW www = new WWW(dreamloWebserviceURL + privateCode + "/add-pipe/" + WWW.EscapeURL(playerName) + "/" + totalScore.ToString());
		yield return www;
	}
	
	IEnumerator AddScoreWithPipe(string playerName, int totalScore, int totalSeconds)
	{
		playerName = Clean(playerName);
		
		WWW www = new WWW(dreamloWebserviceURL + privateCode + "/add-pipe/" + WWW.EscapeURL(playerName) + "/" + totalScore.ToString()+ "/" + totalSeconds.ToString());
		yield return www;
	}
	
	IEnumerator AddScoreWithPipe(string playerName, int totalScore, int totalSeconds, string shortText)
	{
		playerName = Clean(playerName);
		shortText = Clean(shortText);
		
		WWW www = new WWW(dreamloWebserviceURL + privateCode + "/add-pipe/" + WWW.EscapeURL(playerName) + "/" + totalScore.ToString() + "/" + totalSeconds.ToString()+ "/" + shortText);
		yield return www;
	}
	
	
	
	// Keep pipe and slash out of names
	
	string Clean(string s)
	{
		s = s.Replace("/", "");
		s = s.Replace("|", "");
		return s;
		
	}
	
	int CheckInt(string s)
	{
		int x = 0;
		
		int.TryParse(s, out x);
		
		return x;
	}
	
}
