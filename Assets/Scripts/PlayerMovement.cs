using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 10.0f;
    float horizontalInput;
    float verticalInput;

    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward
                             * Time.deltaTime
                             * speed * verticalInput);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right
                             * Time.deltaTime
                             * speed * horizontalInput);
    }
}
