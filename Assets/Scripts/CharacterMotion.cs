using UnityEngine;
using System.Collections;

public class CharacterMotion : MonoBehaviour
{


    private Animator m_animator;
    private bool m_combatIdle = false;

    public KeyCode keyToPress1;
    public KeyCode keyToPress2;
    public KeyCode keyToPress3;

    public KeyCode keyToPress4;

    // Use this for initialization
    void Start()
    {
        m_animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        if (GameManager.instance.flag == false)
        {
            m_animator.SetTrigger("Hurt");
            GameManager.instance.flag = true;
        }

        if (GameManager.instance.playerHP == 0.0001f)
        {
            m_animator.SetTrigger("Death");
        }
        // -- Handle Animations --
        //Death
        if (Input.GetKeyDown(keyToPress1))
        {
            m_animator.SetTrigger("Attack");
        }

        //Hurt
        else if (Input.GetKeyDown(keyToPress2))
            m_animator.SetTrigger("Attack");

        //Attack
        else if (Input.GetKeyDown(keyToPress3))
        {
            m_animator.SetTrigger("Attack");
        }

        else if (Input.GetKeyDown(keyToPress4))
        {
            m_animator.SetTrigger("Attack");
        }

        //Combat Idle
        else if (m_combatIdle)
            m_animator.SetInteger("AnimState", 1);

        //Idle
        else
            m_animator.SetInteger("AnimState", 0);
    }
}
