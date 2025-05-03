using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{
    public Text scoreText;  // UI Text element to display the score
    private int score = 0;  // Starting score

    // Method to increase the score by a specified amount
    public void IncreaseScore(int amount)
    {
        score += amount;  // Increase the score by the given amount
        scoreText.text = "Score: " + score;  // Update the UI text to display the new score
    }
}

