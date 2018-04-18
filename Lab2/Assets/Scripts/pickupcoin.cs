using UnityEngine;
using UnityEngine.UI;

public class pickupcoin : MonoBehaviour
{
    public Text scoreText;

    private int score;

    // Use this for initialization
    void Start()
    {
        RefreshCountText();
    }

    // For now just destroy the coin if the player runs into
    // it. Could play a sound, add to a score or more here later!
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin Type 1"))
        {
            HandleObjectCollision(other.gameObject, 1);
        }
        else if (other.gameObject.CompareTag("Coin Type 2"))
        {
            HandleObjectCollision(other.gameObject, 3);
        }
    }
    
    private void HandleObjectCollision(GameObject currentGameObject, short scoreToAdd)
    {
        Destroy(currentGameObject);
        //Debug.Log("Coin was picked up");
        score += scoreToAdd;
        RefreshCountText();
        if (score >= 20) // 20 punków = win
        {
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    // Reproduce the score text.
    private void RefreshCountText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}