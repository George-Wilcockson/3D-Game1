using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    [SerializeField] public GameObject enemyPrefab;
    [SerializeField] int enemyCount;
    [SerializeField] GameObject player;
    private Vector3 offset = new Vector3(0.0f, 0.0f, -10.0f);

    private float genInterval = 3.0f;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy(genInterval, enemyPrefab));
    }


    private IEnumerator SpawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);

        GameObject newEnemy = Instantiate(enemy, player.transform.position - offset, player.transform.rotation);
        StartCoroutine(SpawnEnemy(interval, enemy));
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
