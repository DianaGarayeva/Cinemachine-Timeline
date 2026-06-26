using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Trigger : MonoBehaviour
{
    [SerializeField] private PlayableDirector _cutscene2;
    [SerializeField] private PlayableDirector _cutscene3;
    [SerializeField] private int _cutsceneNum; 
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (_cutsceneNum == 0)
            {
                _cutscene2.gameObject.SetActive(true);
                _cutscene2.Play();
            }
            else if(_cutsceneNum == 1)
            {
                _cutscene2.gameObject.SetActive(true);
                _cutscene2.Play();
            }
        }
    }
}
