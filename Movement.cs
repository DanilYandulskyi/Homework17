using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField , Range(0, 100)] private float _speed;
    
    private bool _isMoving = false;

    public void MovePosition(Vector3 target)
    {
        if (_isMoving == false)
        {
            Vector2 direction = -(transform.position - target).normalized;
            transform.Translate(direction * (_speed * Time.deltaTime));

            if (transform.position == target)
            {
                _isMoving = true;
            }
        }
    }

    public void MovePosition()
    {

    }
}