using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int  enemiesDefeat;
    public bool canMove;
    public int keys;
    public bool missionone;
    public bool missiontwo;
    public float dano;
    public int escudo;
    public float time;

    public void ResetAll()
    {
        keys = 0;
        enemiesDefeat = 0;
        missionone = false;
        missiontwo = false;
        dano = 0;
        escudo = 0;
        time = 0;
    }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
