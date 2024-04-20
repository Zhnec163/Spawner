using UnityEngine;

public class EnemyCreator : MonoBehaviour
{
    [SerializeField] private Warrior _warriorPrefab;
    [SerializeField] private Mag _magPrefab;
    
    public void Create(Transform target, EnemyType enemyType, Vector3 position)
    {
        switch (enemyType)
        {
            case EnemyType.Warrior:
                Instantiate(_warriorPrefab, position, Quaternion.identity).Init(target);
                break;
            case EnemyType.Mag:
                Instantiate(_magPrefab, position, Quaternion.identity).Init(target);
                break;
        }
    }
}