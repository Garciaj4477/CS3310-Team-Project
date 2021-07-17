using UnityEngine;

public class SecretEndTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter()
    {

        gameManager.CompleteSecretEnd();

    }
}
