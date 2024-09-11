using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private List<Transform> _waypoints;

    private bool _isRight;

    private int _currentWaypoint = 0;

    private void Update()
    {
        Turn();

        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = (_currentWaypoint + 1) % _waypoints.Count;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);

        if (_waypoints[_currentWaypoint].position.x > transform.position.x)
        {
            _isRight = true;
        }
        else
        {
            _isRight = false;
        }
    }

    private void Turn()
    {
        if (_isRight)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }
}