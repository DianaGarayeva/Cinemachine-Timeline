using Cinemachine;
using UnityEngine;
public class CameraManagemen : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera _cockpitCamera;
    [SerializeField]
    private CinemachineVirtualCamera _shipCamera;
    [SerializeField]
    private GameObject[] _cameras;
    [SerializeField]
    private GameObject _cockpit;
    [SerializeField]
    private GameObject _ship; 
    [SerializeField]
    private bool _isCockpit;
    private float _timer=5f; 
    private float _now=5f;
    private int _order=0;
    private void Start()
    {
        ResetCameras();
        _isCockpit = true;
        _cockpitCamera.GetComponent<CinemachineVirtualCamera>().Priority = 15;
    }
    void Update()
    {   
        if(_isCockpit == false)
        {
            if (Input.anyKey || Input.GetMouseButton(0) || Input.GetMouseButton(1) || Input.GetAxis("Mouse X") != 0 || Input.GetAxis("Mouse Y") != 0)
            {
                _now = Time.time + _timer;
                if (_order != 0)
                {
                    _order = 0;
                    ResetCameras();
                    SetPriority(0);
                }
            }
            CameraSystem();
        }
            SwitchCamera();
    }

    private void CameraSystem()
    {
        if (Time.time > _now )
        {
                _now = _timer + Time.time;
                if (_order != 5)
                {
                    _order += 1;
                }
                else
                {
                    _order = 0;
                }
                ResetCameras();
                SetPriority(_order);
        }
    }

    private void ResetCameras()
    {
        foreach(var camera in _cameras)
        {
            if (camera.TryGetComponent<CinemachineVirtualCamera>(out var vcam))
            {
                vcam.Priority = 10;
            }
            else if (camera.TryGetComponent<CinemachineBlendListCamera>(out var blendCam))
            {
                blendCam.Priority = 10;
            }
        }
    }

    private void SetPriority(int camera)
    {
        if (_cameras[camera].TryGetComponent<CinemachineVirtualCamera>(out var vcam))
        {
            vcam.Priority = 15;
        }
        else if (_cameras[camera].TryGetComponent<CinemachineBlendListCamera>(out var blendCam))
        {
            blendCam.Priority = 15;
        }
    }



    private void SwitchCamera()
    {

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (!_isCockpit)
            {
                _shipCamera.gameObject.SetActive(false);
                _cockpitCamera.gameObject.SetActive(true);
                _cockpit.gameObject.SetActive(true);
                _ship.gameObject.SetActive(false);
                _isCockpit = true;
            }
            else if (_isCockpit)
            {
                _cockpitCamera.gameObject.SetActive(false);
                _shipCamera.gameObject.SetActive(true);
                _cockpit.gameObject.SetActive(false);
                _ship.gameObject.SetActive(true);
                _isCockpit = false;
            }
        }
    }



}
