using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PIctureHolderController : MonoBehaviour
{

    public narrativeGameManager gameManager;

    public GameObject glowingFrame;
    public GameObject completePictureErased;
    public GameObject completePictureFull;

    public bool isSecondStage;

    void Start()
    {
        isSecondStage = false;
        glowingFrame.SetActive(false);
        completePictureErased.SetActive(false);
        completePictureFull.SetActive(false);
    }

    public void StartGlowing()
    {
        completePictureErased.SetActive(true);
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

    public void ChangePhotoToFull()
    {
        completePictureErased.SetActive(false);
        completePictureFull.SetActive(true);
    }

}
