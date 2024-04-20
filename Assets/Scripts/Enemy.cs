using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected float MoveSpeed;

    public void Init(Transform target, float moveSpeed)
    {
        MoveSpeed = moveSpeed;
        GetComponent<EnemyMover>().Init(target, MoveSpeed);
    }
}