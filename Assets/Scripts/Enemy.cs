using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float MoveSpeed;

    public void Init(Transform target, float moveSpeed)
    {
        MoveSpeed = moveSpeed;

        if (TryGetComponent(out EnemyMover enemyMover))
        {
            enemyMover.GetComponent<EnemyMover>().Init(target, MoveSpeed);
        }
    }
}