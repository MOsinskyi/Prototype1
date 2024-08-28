using UnityEngine;

public class ClearZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out PlayerController player)) return;
        Destroy(other.gameObject);
    }
}
