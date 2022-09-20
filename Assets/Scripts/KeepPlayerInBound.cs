using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepPlayerInBound : MonoBehaviour
{
    [SerializeField] float xBound, zBound;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Check if out of bound, if so reset position
        if (transform.position.x < -xBound)
            transform.position = new Vector3(-xBound, transform.position.y, transform.position.z);
        else if (transform.position.x > xBound)
            transform.position = new Vector3(xBound, transform.position.y, transform.position.z);

        if (transform.position.z < -zBound)
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        else if (transform.position.z > zBound)
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);

    }
}
