using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardAndTowardPlayer : MonoBehaviour
{
    [SerializeField] float speed;
    GameObject player;

    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (!player)
        {
            Destroy(gameObject);
            return;
        }

        transform.Translate(GetMovementDirection() * Time.deltaTime * speed);
    }

    Vector3 GetMovementDirection()
    {
        // Direction vector from the enemy to the player
        Vector3 playerDirection = player.transform.position - transform.position;

        // If the enemy has not moved passed the player then move towards the player 
        if (transform.position.z > player.transform.position.z)
            return new Vector3(playerDirection.normalized.x, 0, -1);
        // Else move forward
        else
            return Vector3.forward * -1;
    }
}
