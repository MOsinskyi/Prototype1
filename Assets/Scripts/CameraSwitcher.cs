using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField] private GameObject[] cameras;
    [SerializeField] private KeyCode cameraSwitchButton;
    
    private int _currentCamera;

    private void Start()
    {
        cameras[_currentCamera].SetActive(true);
    }

    private void Update()
    {
        if (!Input.GetKeyDown(cameraSwitchButton)) return;
        
        foreach (var cam in cameras)
            cam.SetActive(false);
            
        if (_currentCamera < cameras.Length - 1)
            _currentCamera++;
        else
            _currentCamera = 0;

        cameras[_currentCamera].SetActive(true);
    }
}
