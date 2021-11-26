using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public AudioSource source;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Smack");
        source.Play();
        
    }
}
