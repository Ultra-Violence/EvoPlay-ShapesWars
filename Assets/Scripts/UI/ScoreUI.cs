using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    [SerializeField] private PlayerScore playerScore;
    
    [SerializeField] private Text scoreUI;
    [SerializeField] private Text maxScoreUI;
    [SerializeField] private Text xScoreUI;

    private int score;
    private int maxScore;
    private int xScore;
    
    private void Update() {
        score = playerScore.score;
        maxScore = playerScore.maxScore;
        xScore = playerScore.xScore;

        scoreUI.text = "Score: " + score.ToString();
        maxScoreUI.text = "MaxScore: " + maxScore.ToString();
        xScoreUI.text = "X" + xScore.ToString();

        if(xScore > 1){
            xScoreUI.color = Color.red;
        }
        else {
            xScoreUI.color = Color.white;
        }
    }
}
