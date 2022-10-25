using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ChangeText : MonoBehaviour
{

    public Text changingText;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TextChange()
    {
        changingText.text = "Fight!";
        changingText.color = Color.red;
    }

    public void TextChange2()
    {
        changingText.text = "You Win!!";
        changingText.color = Color.yellow;
    }

    public void TextChange3()
    {
        changingText.text = "You Lost!!";
        changingText.color = Color.blue;
    }
}
