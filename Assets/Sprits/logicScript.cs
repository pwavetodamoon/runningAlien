using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logicScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text pointText;
    public Text bestScoreText;
    public GameObject GameOverScene;
    public int PlayerScore;

    int highscore;
    public void AddScore()
    {
        PlayerScore += 1;
        pointText.text = PlayerScore.ToString();
    }

    public void restartGame()
    {
        SceneManager.LoadScene("MenuGame");
         Time.timeScale = 1;
    }
    public void GameOver()
    {
        GameOverScene.SetActive(true);
        SetPoint();
        Time.timeScale = 0;

    }    
    void SetPoint()
    {
        highscore = PlayerPrefs.GetInt("HighScore", 0); // Gắn điểm vào Highscore với giá trị mặc định là 0
        if(highscore < PlayerScore) // Nếu bé hơn PlayerScore thì:
        {
            highscore = PlayerScore;
            PlayerPrefs.SetInt("HighScore", highscore); //  Và Set HighScore là highscore(điểm cao nhất)
        }
        bestScoreText.text = "BEST SCORE : " + highscore.ToString(); // Thay đổi text thành điểm cao nhất
    }
  
}
