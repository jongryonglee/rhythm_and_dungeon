using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instruction : MonoBehaviour
{

    public Canvas canvas;
    public bool flag = false;

    private void Start()
    {
        canvas.enabled = false;
    }
    public void popup()
    {

        if (flag == false)
        {
            flag = true;
            canvas.enabled = true;
        }
        else if (flag == true)
        {
            flag = false;
            canvas.enabled = false;
        }
    }


}
