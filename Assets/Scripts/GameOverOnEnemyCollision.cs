using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverOnEnemyCollision : MonoBehaviour
{
    private GameManager gameManagerScript;

    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            Destroy(other.gameObject);
            gameManagerScript.GameOver();
        }
    }
}
