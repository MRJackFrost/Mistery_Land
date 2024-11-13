using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundCheck : MonoBehaviour
{
   private Scene cena;
   private void Start()
   {
      cena = SceneManager.GetActiveScene();
      if (cena.name == "Menu")
      {
         SoundManager.Instance.StopAll();
         MenuMusic();
      }else if (cena.name == "MysteryLand")
      {
          SoundManager.Instance.StopAll();
         LevelMusic();
      }else if (cena.name == "EndFase")
      {
          SoundManager.Instance.StopAll();
         EndLevel();
      }
   }

   public void Button()
   {
      SoundManager.Instance.Button.Play();
   }

   public void MenuMusic()
   {
      SoundManager.Instance.menuMusic.Play();
   }

   public void LevelMusic()
   {
      SoundManager.Instance.LevelMusic.Play();
   }

   public void EndLevel()
   {
      SoundManager.Instance.VictorySound.Play();
   }
   
   
}
