using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreText;
	int count = 0;
    int score;

    // Use this for initialisation
    void Start()
    {
        Refresh();
    }

    // Update the score.
    public void Points(short points)
    {
        score += points;
		count++;
        Refresh();
    }

    // Reproduce the score text.
    void Refresh()
    {
        scoreText.text = "Points: " + score.ToString();
		if (count == 10) {
		
			scoreText.text = "You Win :) !!!";
			Time.timeScale = 0;
		
		}
    }
}
