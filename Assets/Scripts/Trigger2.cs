using UnityEngine;
using UnityEngine.Playables;
public class Trigger2 : MonoBehaviour
{
    [SerializeField] private PlayableDirector _cutscene2;
    [SerializeField] private GameObject _ui; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _cutscene2.gameObject.SetActive(true);
            _cutscene2.Play();
            _ui.SetActive(true);
        }
    }
}
