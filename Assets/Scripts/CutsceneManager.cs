using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField]
    private CameraManagement _cameraManager; 
    void Start()
    {
        _cameraManager.gameObject.SetActive(false); 
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void OnCutsceneEnd()
    {
        _cameraManager.gameObject.SetActive(true);
    }
}
