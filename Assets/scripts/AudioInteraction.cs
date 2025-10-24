using Unity.VisualScripting;
using UnityEngine;

public class AudioInteraction : MonoBehaviour
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.LogWarning("we are jumping");
        }
    }
    
    private void OnMouseDown() {
        Debug.LogWarning("clicked");
        myAudioSource.Play(0);
    }
}
