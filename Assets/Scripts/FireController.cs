using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireController : MonoBehaviour
{
    public GameObject flame;
    private AudioSource flameSoundSource;

    public narrativeGameManager gameManager;

    void Start()
    {
        flame.SetActive(false);
        flameSoundSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider collider)
    {
        Debug.LogError("OnTrigger ENTER!!!!");
            // StartFlame();
        if(collider.gameObject.tag == "candle")
        {
            gameManager.OnFireplaceLit();
            StartFlame();
        }
    }

    private void StartFlame()
    {
        flame.SetActive(true);
        flameSoundSource.Play();
    }
}
