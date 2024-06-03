using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private Transform _movingPosition;

    public void Spawn()
    {
        Enemy enemy = Instantiate(_enemy, transform.position, Quaternion.identity);

        enemy.Initialize(_movingPosition.position);
    }
}
