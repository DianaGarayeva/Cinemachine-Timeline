using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{
    [SerializeField] private PlayableDirector _cutscene2;
    [SerializeField] private GameObject _bigShip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _cutscene2.gameObject.SetActive(true);
            _cutscene2.Play();
            this.gameObject.SetActive(false);
            _bigShip.SetActive(true);
        }
    }
}
