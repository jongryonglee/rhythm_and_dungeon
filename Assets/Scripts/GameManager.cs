using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public ChangeText changeText;
    public HealthBar healthBar1;

    public HealthBar healthBar2;

    public AudioSource theMusic;

    public AudioSource WinMusic;

    public AudioSource LostMusic;

    public bool startPlaying;

    public bool flag = true;

    public BeatScroller theBS;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 500;

    public float playerHP = 1.0f;

    public float enemyHP = 1.0f;



    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        healthBar1.SetSizeBar1(playerHP);
        healthBar2.SetSizeBar2(enemyHP);
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                startPlaying = true;

                changeText.TextChange();

                theBS.hasStarted = true;

                theMusic.Play();

            }
        }



    }
    public void NoteHit()
    {
        Debug.Log("Hit On Time");
        currentScore += 100;
        if (enemyHP > 0.1f)
        {
            enemyHP -= 0.04f;
            healthBar2.SetSizeBar2(enemyHP);
        }
        else
        {
            enemyHP = 0.0001f;
            healthBar2.SetSizeBar2(enemyHP);
            changeText.TextChange2();
            WinMusic.Play();
            theMusic.Stop();
            Time.timeScale = 0;
        }

    }

    public void NoteMissed()
    {
        Debug.Log("Missed Note");
        if (playerHP > 0.2f)
        {
            playerHP -= 0.1f;
            healthBar1.SetSizeBar1(playerHP);
        }
        else
        {
            playerHP = 0.0001f;
            healthBar1.SetSizeBar1(playerHP);
            changeText.TextChange3();
            LostMusic.Play();
            theMusic.Stop();
            Time.timeScale = 0;


        }

        flag = false;
        Debug.Log(playerHP);
    }


}


