
using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public Transform player;
    public float detectionRange = 5f;
    public float stopRange = 10f;
    public float speed = 3f;

    private bool chasing = false;

    void Update()
    {
        if (player == null) return;

        float distance = Vector3.Distance(
            transform.position, player.position);

        if (distance <= detectionRange)
            chasing = true;

        if (distance > stopRange)
            chasing = false;

        if (chasing)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                player.position,
                speed * Time.deltaTime);
        }
    }
}
