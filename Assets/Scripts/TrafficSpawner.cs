using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class TrafficSpawner : MonoBehaviour
{
    [Serializable]
    private struct Spawner
    {
        public GameObject spawner;
        public float spawnDuration;
    }

    [SerializeField] private Spawner[] spawners;
    [SerializeField] private GameObject[] trafficVehicles;

    private GameObject _randomTrafficVehicle;
    private GameObject _randomSpawner;

    private void Start()
    {
        foreach (var sp in spawners)
        {
            StartCoroutine(SpawnVehicle(sp.spawner, sp.spawnDuration));
        }
    }

    private IEnumerator SpawnVehicle(GameObject spawner, float duration)
    {
        while (true)
        {
            _randomTrafficVehicle = trafficVehicles[Random.Range(0, trafficVehicles.Length - 1)];
            Instantiate(_randomTrafficVehicle, spawner.transform.position, spawner.transform.localRotation);
            yield return new WaitForSeconds(duration);
        }
    }
}