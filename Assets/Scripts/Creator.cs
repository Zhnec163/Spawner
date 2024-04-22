using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creator : MonoBehaviour
{
    [SerializeField] private Warrior _warrior;
    [SerializeField] private Mag _mag;
    
    public void Create(Enemy enemy, Transform target, Vector3 position)
    {
        if (enemy is Warrior)
        {
            Instantiate(_warrior, enemy.transform.position, Quaternion.identity).Init(position, target);
        }
        else if (enemy is Mag)
        {
            Instantiate(_mag, enemy.transform.position, Quaternion.identity).Init(position ,target);
        }
    }
}
