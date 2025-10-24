using Unity.VisualScripting;
using UnityEngine;

public class Physicsinteractions : MonoBehaviour
{

    AudioSource myAudioSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
         myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision other)
    {
        Debug.LogWarning("collision!");
        myAudioSource.Play();    
    }
}
