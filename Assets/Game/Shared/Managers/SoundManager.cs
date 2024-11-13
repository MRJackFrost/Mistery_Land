using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource menuMusic;
    public AudioSource Button;
    public AudioSource LevelMusic;
    public AudioSource HitEffect;
    public AudioSource ShieldEffect;
    public AudioSource VictorySound;
    public AudioSource battlemusic;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    public void StopAll()
    {
        menuMusic.Stop();
        Button.Stop();
        LevelMusic.Stop();
        HitEffect.Stop();
        ShieldEffect.Stop();
        VictorySound.Stop();
        battlemusic.Stop();
    }
    
    
}
