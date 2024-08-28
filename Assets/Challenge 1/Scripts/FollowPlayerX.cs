using UnityEngine;

namespace Challenge_1.Scripts
{
    public class FollowPlayerX : MonoBehaviour
    {
        [SerializeField] private GameObject plane;
        
        private Vector3 _offset;
        
        private void Start()
        {
            _offset = transform.position;
        }
        
        private void Update()
        {
            transform.position = plane.transform.position + _offset;
        }
    }
}
