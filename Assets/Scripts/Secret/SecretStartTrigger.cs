using UnityEngine;

public class SecretStartTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter()
    {

        gameManager.CompleteSecretStart();

    }
}
