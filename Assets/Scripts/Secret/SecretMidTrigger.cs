using UnityEngine;

public class SecretMidTrigger : MonoBehaviour
{

    public GameManager gameManager;

    void OnTriggerEnter()
    {

        gameManager.CompleteSecretMid();

    }
}
