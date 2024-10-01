using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Player _player;
    [SerializeField] private List<Transform> _waypoints;
    [SerializeField] private float _viewDistance = 1f;

    private Quaternion _turnRight = Quaternion.Euler(0, 0, 0);
    private Quaternion _turnLeft = Quaternion.Euler(0, 180, 0);

    private bool _isRight;

    private int _currentWaypoint = 0;
    private bool _isChasingPlayer = false;

    private void Update()
    {
        if (_isChasingPlayer)
        {
            ChasePlayer();
        }
        else
        {
            Patrol();
        }

        Turn();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {
            _isChasingPlayer = true;
        }
    }

    private void Patrol()
    {
        if (transform.position == _waypoints[_currentWaypoint].position)
        {
            _currentWaypoint = ++_currentWaypoint % _waypoints.Count;
        }

        transform.position = Vector3.MoveTowards(transform.position, _waypoints[_currentWaypoint].position, _speed * Time.deltaTime);

        _isRight = _waypoints[_currentWaypoint].position.x > transform.position.x;
    }

    private void ChasePlayer()
    {
        if (_player != null && Vector2.Distance (transform.position, _player.transform.position) <= _viewDistance)
        {
            transform.position = Vector3.MoveTowards (transform.position, _player.transform.position, _speed * Time.deltaTime);

            _isRight = _player.transform.position.x > transform.position.x;
        }
        else
        {
            _isChasingPlayer = false;
        }
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