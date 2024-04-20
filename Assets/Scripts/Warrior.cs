using UnityEngine;

[RequireComponent(typeof(EnemyMover))]
public class Warrior : Enemy
{
    private float _moveSpeed = 1.5F;
    
    public void Init(Transform target)
    {
        base.Init(target, _moveSpeed);
    }
}
