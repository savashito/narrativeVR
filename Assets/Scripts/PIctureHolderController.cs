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
        Debug.Log("StartGlowing!!!!");
        glowingFrame.SetActive(true);
    }

    private void OnTriggerEnter( Collider collider)
    {
        Debug.Log("col " + collider.gameObject.name);
        if (collider.gameObject.tag == "picture")
        {
            collider.gameObject.SetActive(false);
            completePictureErased.SetActive(true);
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
