using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private int _timeStep = 2;
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Creator _creator;

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
            _creator.Create(_enemy, _target, transform.position);
            yield return waitForSeconds;
        }
    }
}
