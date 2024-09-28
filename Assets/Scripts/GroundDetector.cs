using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    [SerializeField] private float _groundCheckRadius = 0.2f;
    [SerializeField] private LayerMask _layerMask;

    public bool IsGrounded()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, _groundCheckRadius, _layerMask);
        
        return hit != null && hit.TryGetComponent<Platform>(out _);
    }
}
