
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnDistance = 8f;
    public int enemiesPerWave = 4;
    public float waveInterval = 8f;

    void Start()
    {
        SpawnWave();

        InvokeRepeating(
            nameof(SpawnWave),
            waveInterval,
            waveInterval
        );
    }

    public void SpawnWave()
    {
        if (enemyPrefab == null)
        {
            Debug.LogWarning(
                "Assign an Enemy Prefab!"
            );
            return;
        }

        for (int i = 0; i < enemiesPerWave; i++)
        {
            float angle =
                i * Mathf.PI * 2f / enemiesPerWave;

            Vector3 offset = new Vector3(
                Mathf.Cos(angle),
                0f,
                Mathf.Sin(angle)
            ) * spawnDistance;

            Vector3 spawnPosition =
                transform.position + offset;

            Instantiate(
                enemyPrefab,
                spawnPosition,
                Quaternion.identity
            );
        }

        Debug.Log("New enemy wave spawned!");
    }
}
