using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] float x_Range = 12.0f, startDelay = 2.0f, interval = 1.5f;
    [SerializeField] GameObject scoreText;
    [SerializeField] GameObject player;
    [SerializeField] GameObject titleText;
    [SerializeField] Button startButton;

    [SerializeField] GameObject gameOverText;
    public Button restartButton;

    bool isGameActive;
    private int score = 0;

    void Start()
    {
        InvokeRepeating("SpawnStars", 0f, 0.1f);
    }

    public void StartGame()
    {
        titleText.SetActive(false);
        startButton.gameObject.SetActive(false);

        scoreText.SetActive(true);
        player.SetActive(true);

        InvokeRepeating("SpawnEnemy", startDelay, interval);

        scoreText.GetComponent<TextMesh>().text = "Score : " + score;
        isGameActive = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnEnemy()
    {
        if (!isGameActive)
            return;

        Vector3 randomSpawnPos = new Vector3(Random.Range(-x_Range, x_Range),
                                             0,
                                             10);

        GameObject enemy = ObjectPooling.SharedInstance.GetEnemy();

        if (enemy != null)
        {
            enemy.transform.position = randomSpawnPos;
            enemy.SetActive(true);
        }
    }

    void SpawnStars()
    {
        // if (!isGameActive)
        //     return;

        Vector3 randomSpawnPos = new Vector3(Random.Range(-x_Range, x_Range),
                                             0,
                                             10);

        GameObject randomStar = ObjectPooling.SharedInstance.GetStar();

        if (randomStar != null)
        {
            randomStar.transform.position = randomSpawnPos;
            randomStar.SetActive(true);
        }
    }

    public void UpdateScore()
    {
        score += 1;
        scoreText.GetComponent<TextMesh>().text = "Score : " + score;
    }

    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void RestartGame()
    {
        // Reload a scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
