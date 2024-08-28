using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private Vector3 _cameraStartPosition;
    
    private void Start()
    {
        _cameraStartPosition = transform.position - player.transform.position;
    }
    
    private void LateUpdate()
    {
        transform.position = player.transform.position + _cameraStartPosition;
    }
}
