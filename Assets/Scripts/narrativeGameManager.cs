using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrativeGameManager : MonoBehaviour
{
    public narrativeVRAudioManager audioManager;
    public narrativeLightingManager lightingManager;

    public PIctureHolderController pIctureHolder;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void OnFireplaceLit()
    {
        //play first audio
        audioManager.PlayAfterCandleLightAudio();
        //make pieces appear and glow
    }

    public void OnPictureComplete()
    {
        //play second audio
        pIctureHolder.StartGlowing();

    }

    public void OnPicturePutInPlaceholder()
    {
        //drum pieces appear
        lightingManager.TurnOnFirstCornerLights();
        //lights in corner 1 appear
    }

    public void OnDrumPutTogether()
    {
        //play audio 3
        //highlight drum holder
    }

    public void OnPutDrumInPlaceHolder()
    {
        //lights in corner 2 of 3 appear
        lightingManager.TurnOnSecondCornerLights();
        //paint brush pieces appear
    }

    public void OnPaintBrushPutTogether()
    {
        //audio plays
        //picture changes its image to the full version 
        //picture starts glowing
    }

    public void OnPlayerNearPicture()
    {
        lightingManager.TurnOnThirdCornerLights();
        //play audio 
        //wait for audio to finish
        //fade to black/credits
    }


}
