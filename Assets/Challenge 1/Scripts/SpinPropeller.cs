using UnityEngine;

namespace Challenge_1.Scripts
{
    public class SpinPropeller : MonoBehaviour
    {
        [SerializeField] private float spinningSpeed;
    
        private void Update()
        {
            transform.Rotate(Vector3.forward, Time.deltaTime * spinningSpeed);
        }
    }
}
