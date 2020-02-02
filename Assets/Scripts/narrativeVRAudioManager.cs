using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrativeVRAudioManager : MonoBehaviour
{
  public AudioClip afterCandleLightAudio;
  public AudioClip afterPutPictureTogetherAudio;
  public AudioClip afterPutDrumTogetherAudio;
  public AudioClip afterPutRockingHorseTogetherAudio;
  public AudioClip afterPutPaintBrushTogetherAudio;
  public AudioClip afterSeeFullPhotoAudio;
  
//SORRY FOR NAMING THESE LIKE A LITERAL CRAZY PERSON!!!

  private AudioSource source;

  public void Start()
  {
    source = GetComponent<AudioSource>();
    if(!source)
    {
      Debug.LogError("Awake no audiosource on manager");
    }
  }

  public void PlayAfterCandleLightAudio()
  {
    PlayAudio(afterCandleLightAudio);
  }

  public void PlayAfterPutPictureTogetherAudio()
  {
    PlayAudio(afterPutPictureTogetherAudio);
  }
 
  public void PlayAfterPutDrumTogetherAudio()
  {
    PlayAudio(afterPutDrumTogetherAudio);
  }
 
  public void PlayAfterPutRockingHorseTogetherAudio()
  {
    PlayAudio(afterPutRockingHorseTogetherAudio);
  }
 
  public void PlayAfterPutPaintBrushTogetherAudio()
  {
    PlayAudio(afterPutPaintBrushTogetherAudio);
  }
 
  public void PlayAfterSeeFullPhotoAudio()
  {
    PlayAudio(afterSeeFullPhotoAudio);
  }

  private void PlayAudio(AudioClip clip)
  {
    source.clip = clip;
    source.Play();
  }

  // void Update()
  // {
  //   if(Input.GetKeyDown(KeyCode.A))
  //   {
  //     PlayAfterCandleLightAudio();
  //   }
  // }
  
}
