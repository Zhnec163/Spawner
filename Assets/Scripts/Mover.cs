using UnityEngine;

public abstract class Mover : MonoBehaviour
{
    protected float Speed = 1F;

    protected abstract void Move();
}
