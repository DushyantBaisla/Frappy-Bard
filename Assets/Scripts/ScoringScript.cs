using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoringScript : MonoBehaviour
{
    private int playerScore = 0;
    public bool isGameOver = false;

    [SerializeField] private TMP_Text scoreBoard;
    [SerializeField] private GameObject gameOverScreen;

    void Start()
    {
        ResetScore();
    }

    public void Restart(){
        gameOverScreen.SetActive(false);
        isGameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        ResetScore();
    }

    public void GameOver(){
        gameOverScreen.SetActive(true);
        isGameOver = true;
    }

    private void UpdateScore(){
        scoreBoard.text = playerScore.ToString();
    }

    public void AddScore(int score){
        playerScore += score;
        UpdateScore();
    }

    public void ResetScore(){
        playerScore = 0;
        UpdateScore();
    }

}
