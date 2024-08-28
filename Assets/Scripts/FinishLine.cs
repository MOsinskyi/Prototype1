using TMPro;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    [Header("EFFECTS")]
    [SerializeField] private ParticleSystem particle;
    
    [Header("TMP")]
    [SerializeField] private TMP_Text result;

    private bool _finished;
    
    private void OnTriggerEnter(Collider other)
    {
        if (!other.TryGetComponent(out PlayerController player)) return;
        if (_finished) return;
        
        result.text = $"Player {player.GetPlayerNumber()} WIN!";
        Instantiate(particle, transform.position, Quaternion.identity);
        player.InvokeRestartScene(3f);
        _finished = true;
    }
}
