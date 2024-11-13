using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class CombatScript : MonoBehaviour
{
    public Status player;
    public Status enemy;
    public Animator playeranim;
    public Animator enemyanim;
    public GameObject combatPanel;
    public Button attackbutton;
    public Button defensebutton;
    private float d4;
    private int d10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartCombat(Status gplayer, Status genemy, Animator playeran, Animator enemyan)
    {
        SoundManager.Instance.LevelMusic.Stop();
        SoundManager.Instance.battlemusic.Play();
        player = gplayer;
        enemy = genemy;
        playeranim = playeran;
        enemyanim = enemyan;
        combatPanel.SetActive(true);
    }

    public void EndCombat()
    {
        SoundManager.Instance.LevelMusic.Play();
        SoundManager.Instance.battlemusic.Stop();
        combatPanel.SetActive(false);
        Destroy(enemy.gameObject);
        GameManager.Instance.canMove = true;
        GameManager.Instance.enemiesDefeat++;
    }

    public void PlayerAttack()
    {
        SoundManager.Instance.HitEffect.Play();
        SetButtonFalse();
        d4 = Random.Range(1, player.power);
        enemy.life -= d4 - enemy.defense;
        enemy.defense -= d4;
        if (enemy.defense < 0)
        {
            enemy.defense = 0;
        }
        if (enemy.life <= 0)
        {
            EndCombat();
        }
        else
        {
            d10 = Random.Range(0, 10);
            if (d10 < 8)
            {
                Invoke("EnemyAttack", 2);
            }
            else
            {
                Invoke("EnemyDefense", 2);
            }
            
        }

    
    }

    private void EnemyAttack()
    {
        SoundManager.Instance.HitEffect.Play();
        d4 = Random.Range(1, player.power);
        player.life -= d4 - player.defense;
        GameManager.Instance.dano += d4;
        player.defense -= d4;
        if (player.defense < 0)
        {
            player.defense = 0;
        }
        enemyanim.SetTrigger("Attack");
        if (player.life <= 0)
        {
            GameManager.Instance.LoadGameOver();
        }
        Invoke("SetButtonTrue",1);
    }

    public void PlayerDefender()
    {
        SoundManager.Instance.ShieldEffect.Play();
        SetButtonFalse();
        player.defense = player.maxdefense;
        GameManager.Instance.escudo++;
        Invoke("EnemyAttack", 2);
        
    }

    private void EnemyDefense()
    {
        SoundManager.Instance.ShieldEffect.Play();
        enemy.defense = enemy.maxdefense;
        enemyanim.SetTrigger("Attack");
        Invoke("SetButtonTrue",1);
    }

    public void SetButtonFalse()
    {
        attackbutton.interactable = false;
        defensebutton.interactable = false;
    }
    public void SetButtonTrue()
    {
        attackbutton.interactable = true;
        defensebutton.interactable = true;
    }
}
