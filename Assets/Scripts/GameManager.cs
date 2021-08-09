using System;
using System.Collections;
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
        gameHasEnded = true;
    }

    public void CompleteSecretStart()
    {
        if (gameHasEnded == false)
        {
            FindObjectOfType<Spawner>().GenerateObjects();
            FindObjectOfType<AudioManager>().Stop("Theme");
            StartCoroutine(playSecretSound());
            CompleteSecretStartUI.SetActive(true);
        }
    }
    
    public void CompleteSecretMid()
    {
        FindObjectOfType<AudioManager>().Pause("SecretStartAudio");
        StartCoroutine(playSecretSound());
        CompleteSecretMidUI.SetActive(true);
    }

    IEnumerator playSecretSound()
    {
        FindObjectOfType<AudioManager>().Play("SecretMidAudio");
        yield return new WaitForSeconds(FindObjectOfType<AudioManager>().ClipLength("SecretMidAudio") + -2);
        FindObjectOfType<AudioManager>().Play("SecretStartAudio");
    }

    public void CompleteSecretEnd()
    {
        FindObjectOfType<AudioManager>().Stop("SecretStartAudio");
        FindObjectOfType<AudioManager>().Stop("Theme");
        FindObjectOfType<AudioManager>().Play("SecretEndAudio");
        CompleteSecretEndUI.SetActive(true);
        gameHasEnded = true;
    }

    public void EndGame()
    {

        if (gameHasEnded == false)
        {
            FindObjectOfType<AudioManager>().Stop("Theme");
            FindObjectOfType<AudioManager>().Stop("SecretStartAudio");
            FindObjectOfType<AudioManager>().Play("PlayerDeath");
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
