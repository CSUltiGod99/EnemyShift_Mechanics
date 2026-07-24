using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectCharacter : MonoBehaviour {

  [SerializeField]
  CameraFollow cameraFollow;

  public Character[] characters;
  public int selectedCharacter = 0;

  public void NextCharacter()
  {
      characters[selectedCharacter].gameObject.SetActive(false);
      selectCharacter = (selectCharacter + 1) % characters.Length;
      characters[selectedCharacter].gameObject.SetActive(true);
    
  }
  
  
}

