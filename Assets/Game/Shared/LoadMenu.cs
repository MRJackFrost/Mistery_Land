using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadMenuButton()
    {
        GameManager.Instance.ResetAll();
        SceneManager.LoadScene("Menu");
        SoundManager.Instance.StopAll();
        SoundManager.Instance.menuMusic.Play();
    }
}
