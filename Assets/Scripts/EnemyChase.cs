
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 10f;
    public float stopRange = 15f;
    public float speed = 3f;

    private bool chasing = false;

    void Start()
    {
        if (player == null)
        {
            GameObject playerObject =
                GameObject.FindWithTag("Player");

            if (playerObject != null)
            {
                player = playerObject.transform;
            }
        }
    }

    void Update()
    {
        if (player == null) return;

        Vector3 direction = player.position
                            - transform.position;

        direction.y = 0;

        float distance = direction.magnitude;

        if (distance <= detectionRange)
            chasing = true;

        if (distance > stopRange)
            chasing = false;

        if (chasing)
        {
            transform.position +=
                direction.normalized * speed
                * Time.deltaTime;
        }
    }
}
