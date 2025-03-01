using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleScreenManager : MonoBehaviour
{
    public Button startButton; 

    void Start()
    {
        
        if (startButton != null)
        {
            startButton.onClick.AddListener(OnStartButtonClicked);
        }
        else
        {
            Debug.LogError("Start button is not assigned.");
        }
    }

    public void OnStartButtonClicked()
    {
       
        SceneManager.LoadScene("GameScene"); 
    }
}
