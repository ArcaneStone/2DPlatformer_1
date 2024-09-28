using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private List<Transform> _waypoints;

    private Quaternion _turnRight = Quaternion.Euler(0, 0, 0);
    private Quaternion _turnLeft = Quaternion.Euler(0, 180, 0);

    private bool _isRight;

    private int _currentWaypoint = 0;

    private void Update()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = ++_currentWaypoint % _waypoints.Count;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);

        _isRight = _waypoints[_currentWaypoint].position.x > transform.position.x;

        Turn();
    }

    private void Turn()
    {
        if (_isRight)
        {
            transform.rotation = _turnRight;
        }
        else
        {
            transform.rotation = _turnLeft;
        }
    }
}