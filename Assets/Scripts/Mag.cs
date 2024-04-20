using UnityEngine;

[RequireComponent(typeof(EnemyMover))]
public class Mag : Enemy
{
    private float _moveSpeed = 1.2F;
    
    public void Init(Transform target)
    {
        base.Init(target, _moveSpeed);
    }
}
