using UnityEngine;

public class GroundDetector : MonoBehaviour
{
    [SerializeField] private float _groundCheckDistance = 0.1f;
    [SerializeField] private LayerMask _layerMask;

    public bool IsGrounded()
    {
        Vector2 raycastDirection = Vector2.down;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, raycastDirection, _groundCheckDistance, _layerMask);      

         return hit.collider != null && hit.collider.gameObject.GetComponent<Platform>() != null;
    }
}