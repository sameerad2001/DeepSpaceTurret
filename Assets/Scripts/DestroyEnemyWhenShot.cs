using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemyWhenShot : MonoBehaviour
{
    void Start()
    {
        gameManagerScript = GameObject.Find("Game Manager").GetComponent<GameManager>();
    }

    private GameManager gameManagerScript;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Projectile"))
        {
            // Disable the projectile
            other.gameObject.SetActive(false);
            // Disable itself i.e enemy
            gameObject.SetActive(false);
            gameManagerScript.UpdateScore();
        }
    }
}
