using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{
   public int playerScore;
   public Text scoreText;
   public GameObject gameOverScreen;

   public bool isGameOver = false;
   public AudioSource bonusSFX;
   public Text highScoreText;

     void Start()
    {
        LoadHighScore();
    }
 
  


   [ContextMenu("Increase Score")]

   public void addScore(int scoreToAdd){
    if(!isGameOver){
        playerScore += scoreToAdd;
        scoreText.text = "Score: " + playerScore.ToString();
        bonusSFX.Play();
       
    }
   }

   public void restartGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

   public void gameOver(){
        isGameOver = true;
        gameOverScreen.SetActive(true);

         
        SaveHighScore();

      
        
   }

     private void SaveHighScore()
    {
      
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        
        if (playerScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", playerScore);
            PlayerPrefs.Save(); 
        }

       
        LoadHighScore();
    }

    private void LoadHighScore()
    {
        
        int highScore = PlayerPrefs.GetInt("HighScore", 0);

        
        if (highScoreText != null)
        {
            highScoreText.text = "High Score: " + highScore.ToString();
        }
    }
   
}
