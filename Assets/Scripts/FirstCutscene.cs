using UnityEngine;

public class CutsceneManager : MonoBehaviour
{
    [SerializeField]
    private CameraManagement _cameraManager;
    [SerializeField]
    private GameObject _ui;
    [SerializeField]
    private GameObject _ui2;
    [SerializeField]
    private GameObject _cockpit; 

    void Start()
    {
        _cameraManager.gameObject.SetActive(false);
        _cockpit.gameObject.SetActive(false);
        _ui.SetActive(false);
        _ui2.SetActive(false);
    }

    public void OnCutsceneEnd()
    {
        Debug.Log("Start");
        _cameraManager.gameObject.SetActive(true);
        _ui.SetActive(true);
        _cockpit.gameObject.SetActive(true);

    }
}
