using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarFollower : MonoBehaviour
{
    [SerializeField] private float YOffset = 1.5f;

    [SerializeField] private Slider _slider;
    [SerializeField] private Transform _target;

    private bool _isDestroyed = false;
    private Health _targetHealth;

    private void Start()
    {
        _targetHealth = _target.GetComponent<Health>();
    }

    private void Update()
    {
        if (_targetHealth.IsDead && !_isDestroyed)
        {
            Destroy(_slider.gameObject);
            _isDestroyed = true;
        }
        else if (_targetHealth != null && !_targetHealth.IsDead)
        {
            if (_slider != null)
            {
                Vector3 targetPosition = _target.position;
                targetPosition.y += YOffset;

                _slider.transform.position = targetPosition;
            }
        }
    }
}
