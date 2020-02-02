using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject flame;
    private AudioSource flameSoundSource;
    void Start()
    {
        flame.SetActive(false);
        flameSoundSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        //check for collision with candle
        // if(collision)
        // {
        //     StartFlame();
        // }
    }

    private void StartFlame()
    {
        flame.SetActive(true);
        flameSoundSource.Play();
    }
}
