using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject CompleteLevelUI;
    public GameObject CompleteSecretStartUI;
    public GameObject CompleteSecretMidUI;
    public GameObject CompleteSecretEndUI;

    public void CompleteLevel()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void CompleteSecretStart()
    {
        CompleteSecretStartUI.SetActive(true);
    }

    public void CompleteSecretMid()
    {
        CompleteSecretMidUI.SetActive(true);
    }

    public void CompleteSecretEnd()
    {
        CompleteSecretEndUI.SetActive(true);
    }

    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            //Debug.Log("Game Over");
            //restart game
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
