using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Transform bar1;
    private Transform bar2;


    // Start is called before the first frame update
    void Awake()
    {
        bar1 = transform.Find("PlayerBar");
        bar2 = transform.Find("EnemyBar");
    }

    // Update is called once per frame

    public void SetSizeBar1(float sizeNormalized)
    {
        bar1.localScale = new Vector3(sizeNormalized, 1f);
    }

    public void SetSizeBar2(float sizeNormalized)
    {
        bar2.localScale = new Vector3(sizeNormalized, 1f);
    }
}
