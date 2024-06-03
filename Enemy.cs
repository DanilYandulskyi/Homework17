using UnityEngine;

[RequireComponent(typeof(Movement))]
public class Enemy : MonoBehaviour
{
    private Movement _movement;
    private Vector3 _target;

    private void Awake()
    {
        _movement = GetComponent<Movement>(); 
    }

    private void Update()
    {
        _movement.MovePosition(_target);     
    }

    public void Initialize(Vector3 target)
    {
        _target = target;
    }
}
