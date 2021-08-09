using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void Menu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);

    }

    public void Level1()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }

    public void Level2()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }

    public void Level3()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
