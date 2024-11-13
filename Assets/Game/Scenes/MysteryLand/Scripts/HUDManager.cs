using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Image = UnityEngine.UI.Image;

public class HUDManager : MonoBehaviour
{
    public Image lifebar;
    public Image enemylifebar;
    public Image shield;
    public Image enemyshield;
    public Status player;
    public Status enemy;
    public Animator mission1;
    public Animator mission2;
    

    public void LifeChange()
    {
        lifebar.fillAmount = player.life / player.maxlife;
        enemylifebar.fillAmount = enemy.life / enemy.maxlife;
    }

    public void ShieldChange()
    {
        enemyshield.fillAmount = enemy.defense / enemy.maxdefense;
        shield.fillAmount = player.defense / player.maxdefense;
    }

    private void Update()
    {
        LifeChange();
        ShieldChange();
        MissionOneAnim();
        MissionTwoAnim();
    }

    private void MissionOneAnim()
    {
        if (GameManager.Instance.keys >= 2 && GameManager.Instance.missionone == false)
        {
            mission1.GetComponent<Animator>().enabled = true;
            GameManager.Instance.missionone = true;
            Destroy(mission1.gameObject, 2);
            SoundManager.Instance.ShieldEffect.Play();
        }
    }
    private void MissionTwoAnim()
    {
        if (GameManager.Instance.enemiesDefeat >= 1 && GameManager.Instance.missiontwo == false)
        {
            mission2.GetComponent<Animator>().enabled = true;
            GameManager.Instance.missiontwo = true;
            Destroy(mission2.gameObject, 2);
            SoundManager.Instance.ShieldEffect.Play();
        }
    }
}
