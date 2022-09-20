using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPooling : MonoBehaviour
{
    public static ObjectPooling SharedInstance;

    // 1. Projectiles :
    public List<GameObject> pooledProjectiles;
    [SerializeField] GameObject projectile;
    [SerializeField] int amountOfProjectilesToPool;

    // 2. Stars :
    [SerializeField] List<List<GameObject>> pooledShootingStars;
    [SerializeField] List<GameObject> shootingStars; // this variable will store the 3 different types of stars (blue, yellow, white) 
    [SerializeField] int[] amountOfStarsToPool = { 20, 15, 10 }; // 20 : blue stars ....

    // 3. Enemy :
    [SerializeField] List<GameObject> pooledEnemies;
    [SerializeField] GameObject enemy;
    [SerializeField] int amountOfEnemiesToPool;

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        // 1. Projectiles :
        pooledProjectiles = new List<GameObject>();
        for (int i = 0; i < amountOfProjectilesToPool; i++)
        {
            GameObject tmp = Instantiate(projectile);
            tmp.SetActive(false);
            pooledProjectiles.Add(tmp);
        }

        // 2. Stars :
        pooledShootingStars = new List<List<GameObject>>();
        for (int i = 0; i < 3; i++)
        {
            List<GameObject> stars = new List<GameObject>();
            for (int j = 0; j < amountOfStarsToPool[i]; j++)
            {
                GameObject tmp = Instantiate(shootingStars[i]);
                tmp.SetActive(false);
                stars.Add(tmp);
            }

            pooledShootingStars.Add(stars);
        }

        // 3. Enemies :
        pooledEnemies = new List<GameObject>();
        for (int i = 0; i < amountOfEnemiesToPool; i++)
        {
            GameObject tmp = Instantiate(enemy);
            tmp.SetActive(false);
            pooledEnemies.Add(tmp);
        }
    }

    public GameObject GetProjectile()
    {
        for (int i = 0; i < amountOfProjectilesToPool; i++)
        {
            // Loop through all the pooled projectiles
            // Check if current projectile is inactive, if yes then pass it's reference
            if (!pooledProjectiles[i].activeInHierarchy)
            {
                return pooledProjectiles[i];
            }
        }
        return null;
    }

    public GameObject GetEnemy()
    {
        for (int i = 0; i < amountOfEnemiesToPool; i++)
        {
            if (!pooledEnemies[i].activeInHierarchy)
                return pooledEnemies[i];
        }
        return null;
    }

    public GameObject GetStar()
    {
        int randomIndex = Random.Range(0, 100);
        randomIndex = randomIndex > 50 ? 0 : randomIndex > 20 ? 1 : 2;

        for (int i = 0; i < amountOfStarsToPool[randomIndex]; i++)
        {
            if (!pooledShootingStars[randomIndex][i].activeInHierarchy)
            {
                return pooledShootingStars[randomIndex][i];
            }
        }
        return null;
    }
}
