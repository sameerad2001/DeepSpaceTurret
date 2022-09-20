using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundProjectile : MonoBehaviour
{
    private ObjectPooling objectPoolingScript;

    [SerializeField] float zBound;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -zBound)
            gameObject.SetActive(false);
        else if (transform.position.z > zBound)
            gameObject.SetActive(false);
    }
}
