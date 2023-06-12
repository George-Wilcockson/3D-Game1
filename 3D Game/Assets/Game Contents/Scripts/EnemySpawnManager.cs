using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] public GameObject enemyPrefab;
    [SerializeField] GameObject player;
    [SerializeField] int enemyCount;

    private float genInterval = 10.0f;
    private int maxEnemies = 5;

    private Vector3 offset = new Vector3(0.0f, 0.0f, -10.0f);




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy(genInterval, enemyPrefab));
    }


    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);

        for(int i = 0; i < maxEnemies; i++)
        {
            GameObject newEnemy = Instantiate(enemy, player.transform.position - offset, player.transform.rotation);
            StartCoroutine(SpawnEnemy(interval, enemy));
        }

    }
}
