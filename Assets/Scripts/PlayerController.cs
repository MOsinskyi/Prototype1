using System;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]
public class PlayerController : MonoBehaviour
{
    private const float RayDistance = 3f;

    [Header("GENERAL")] [SerializeField] private int playerNumber = 1;

    [Header("ACCELERATION")] [SerializeField]
    private float maxSpeed = 20f;

    [Header("HANDLING")] [SerializeField] private float maxTurnSpeed = 10f;

    [Header("INPUT")] [SerializeField] private string[] inputAxisNames = { "Horizontal", "Vertical" };

    private float _horizontalInput;
    private float _forwardInput;

    private int _layerMask;

    private bool _onGround;

    private void Start()
    {
        _layerMask = 1 << 2;
        _layerMask = ~_layerMask;
    }

    private void FixedUpdate()
    {
        var ray = new Ray(transform.localPosition + Vector3.up, Vector3.down);

        _onGround = Physics.Raycast(ray, RayDistance, _layerMask);
         
        _horizontalInput = Input.GetAxis(inputAxisNames[0]);
        _forwardInput = Input.GetAxis(inputAxisNames[1]);

        transform.Translate(Vector3.forward * (Time.deltaTime * maxSpeed * _forwardInput * Convert.ToInt32(_onGround)));

        transform.Rotate(Vector3.up, Time.deltaTime * maxTurnSpeed * _horizontalInput);

        if (Input.GetKeyDown(KeyCode.R))
        {
            RestartScene();
        }
    }

    private void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void InvokeRestartScene(float time)
    {
        Invoke(nameof(RestartScene), time);
    }

    public int GetPlayerNumber() => playerNumber;
}