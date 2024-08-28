using TMPro;
using UnityEngine;

public class CompetitionSystem : MonoBehaviour
{
    [Header("PLAYERS")]
    [SerializeField] private PlayerController player1;
    [SerializeField] private PlayerController player2;

    [Header("TMP")] 
    [SerializeField] private TMP_Text firstPlayerPlace;
    [SerializeField] private TMP_Text secondPlayerPlace;

    private void Update()
    {
        if (player1.transform.position.z > player2.transform.position.z)
        {
            firstPlayerPlace.text = "1st";
            secondPlayerPlace.text = "2nd";
        }
        else
        {
            firstPlayerPlace.text = "2nd";
            secondPlayerPlace.text = "1st";
        }
    }
}
