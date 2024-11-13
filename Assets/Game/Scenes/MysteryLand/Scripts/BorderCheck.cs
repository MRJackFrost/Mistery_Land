using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BorderCheck : MonoBehaviour
{
    private float time;
    private void Update()
    {
        time += Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.collider.CompareTag("Player"))
        {
            if (GameManager.Instance.missionone && GameManager.Instance.missiontwo)
            {
                GameManager.Instance.time = time;
                SceneManager.LoadScene("EndFase");
            }
        }
    }
}
