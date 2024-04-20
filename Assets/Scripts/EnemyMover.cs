using UnityEngine;

public class EnemyMover : Mover
{
    private Transform _target;

    private void Update()
    {
        Move();
    }

    public void Init(Transform target, float speed)
    {
        _target = target;
        Speed = speed;
    }

    protected override void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, Speed * Time.deltaTime);;
    }
}
