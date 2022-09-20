using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingStarMovement : MonoBehaviour
{
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * speed * -1);
    }
}
