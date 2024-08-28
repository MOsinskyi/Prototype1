using UnityEngine;

namespace Challenge_1.Scripts
{
    public class PlayerControllerX : MonoBehaviour
    {
        [SerializeField] private float speed;
        [SerializeField] private float rotationSpeed;
        
        private float _verticalInput;
        
        private void FixedUpdate()
        {
            _verticalInput = Input.GetAxis("Vertical");
            
            transform.Translate(Vector3.forward * (Time.deltaTime * speed));
            transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * -_verticalInput);
        }
    }
}
