using UnityEngine;

[RequireComponent(typeof(EnemyMover))]
public abstract class Enemy : MonoBehaviour
{
    public void Init(Vector3 position, Transform target)
    {
        transform.position = position;
        
        if (TryGetComponent(out EnemyMover enemyMover))
        {
            enemyMover.Init(target);
        }
    }
}