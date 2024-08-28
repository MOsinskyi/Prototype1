using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class TrafficMovement : MonoBehaviour
{
    [Header("VEHICLE SPEED")]
    [SerializeField] private float min;
    [SerializeField] private float max;

    private float _vehicleSpeed;

    private void Start()
    {
        _vehicleSpeed = Random.Range(min, max);
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * _vehicleSpeed));
    }
    
}
