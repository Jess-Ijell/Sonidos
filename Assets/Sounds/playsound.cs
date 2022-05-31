using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playsound : MonoBehaviour
{
    public AudioClip Golpe;
    public AudioClip Grito;

    AudioSource fuenteAudio;

    // Start is called before the first frame update
    void Start()
    {
        fuenteAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            fuenteAudio.clip = Golpe;
            fuenteAudio.Play();
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            fuenteAudio.clip = Grito;
            fuenteAudio.Play();
        }
    }
}
