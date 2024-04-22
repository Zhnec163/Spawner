using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorCreator : MonoBehaviour
{
    [SerializeField] private Warrior _prefab;

    public void Create(Transform target, Vector3 position)
    {
        Instantiate(_prefab, position, Quaternion.identity).Init(target);
    }
}
