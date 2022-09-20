using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProjectile : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject projectile = ObjectPooling.SharedInstance.GetProjectile();
            if (projectile != null)
            {
                projectile.transform.position = gameObject.transform.position;
                // projectile.transform.rotation = gameObject.transform.rotation;
                projectile.SetActive(true);
            }
        }
    }
}
