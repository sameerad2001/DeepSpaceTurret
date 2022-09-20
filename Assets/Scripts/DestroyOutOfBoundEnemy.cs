using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundEnemy : MonoBehaviour
{
    [SerializeField] float zBound;

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z < -1 * zBound)
            gameObject.SetActive(false);
    }
}
