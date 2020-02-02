using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIctureHolderController : MonoBehaviour
{

    public narrativeGameManager gameManager;

    public GameObject glowingFrame;
    public GameObject completePicture;

    void Start()
    {
        glowingFrame.SetActive(false);
        completePicture.SetActive(false);
    }

    public void StartGlowing()
    {
        completePicture.SetActive(true);
        glowingFrame.SetActive(true);
    }

    private void OnTriggerEnter( Collider collider)
    {
        if(collider.gameObject.tag == "picture")
        {
            //play a completion audio?
            glowingFrame.SetActive(false);
            gameManager.OnPicturePutInPlaceholder();
        }

    }

}
