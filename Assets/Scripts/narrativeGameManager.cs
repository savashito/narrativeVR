﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrativeGameManager : MonoBehaviour
{
    public narrativeVRAudioManager audioManager;
    public narrativeLightingManager lightingManager;

    public PIctureHolderController pIctureHolder;
    public GameObject picturePiecesParent;

    public GameObject drums;
    

    // void Start()
    // {
    // }

    // void Update()
    // {
    // }

    public void OnFireplaceLit()
    {
        audioManager.PlayAfterCandleLightAudio();
        picturePiecesParent.SetActive(true);
        //make pieces appear and glow
    }

    public void OnPictureComplete()
    {
        
        Debug.Log("OnPictureComplete!!!!");
        audioManager.PlayAfterPutPictureTogetherAudio();

        Debug.Log("OnPictureComplete!!!!" + pIctureHolder);
        pIctureHolder.StartGlowing();
        
    }

    public void OnPicturePutInPlaceholder()
    {
       // drums.SetActive(true);
        lightingManager.TurnOnFirstCornerLights();
    }

    public void OnDrumPutTogether()
    {
        audioManager.PlayAfterPutDrumTogetherAudio();
        //highlight drum holder
    }

    public void OnPutDrumInPlaceHolder()
    {
        lightingManager.TurnOnSecondCornerLights();
        //paint brush pieces appear
    }

    public void OnPaintBrushPutTogether()
    {
        audioManager.PlayAfterPutPaintBrushTogetherAudio();
        pIctureHolder.StartGlowing();
        pIctureHolder.ChangePhotoToFull();
    }

    public void OnPlayerNearPicture()
    {
        lightingManager.TurnOnThirdCornerLights();
        audioManager.PlayAfterSeeFullPhotoAudio();
        //wait for audio to finish
        //fade to black/credits
    }


}
