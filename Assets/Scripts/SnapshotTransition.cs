using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SnapshotTransition : MonoBehaviour
{
    public AudioMixerSnapshot transToRuins;
    public AudioMixerSnapshot transToForest;
    public float transitionTime;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
   
    {
        if (collision.CompareTag("Player"))
        {
            transToRuins.TransitionTo(transitionTime);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            transToForest.TransitionTo(transitionTime);
        }
    }
}
