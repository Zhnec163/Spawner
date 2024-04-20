using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private EnemyType _enemyType;
    [SerializeField] private EnemyCreator _enemyCreator;
    [SerializeField] private int _timeStep = 2;

    private bool _isWork = true;
    
    private void Start()
    {
        StartCoroutine(GenerateEnemies());
    }

    private IEnumerator GenerateEnemies()
    {
        WaitForSeconds waitForSeconds = new WaitForSeconds(_timeStep);
        
        while (_isWork)
        {
             _enemyCreator.Create(_target, _enemyType, transform.position);
            yield return waitForSeconds;
        }
    }
}
