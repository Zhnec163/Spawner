using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private EnemyType _enemyType;
    [SerializeField] private int _timeStep = 2;
    [SerializeField] private WarriorCreator _warriorCreator;
    [SerializeField] private MagCreator _magCreator;

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
            switch (_enemyType)
            {
                case EnemyType.Warrior:
                    _warriorCreator.Create(_target, transform.position);
                    break;
                
                case EnemyType.Mag:
                    _magCreator.Create(_target, transform.position);
                    break;
            }
            
            yield return waitForSeconds;
        }
    }
}
