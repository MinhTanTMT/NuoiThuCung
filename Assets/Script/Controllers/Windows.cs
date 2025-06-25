using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Windows : MonoBehaviour
{
    private Animator animator;

    private float duration = 240f;

    public static bool goSleep = false;

    public static float reduceTime = 0.1f;
    
    //public static int ABC = 8112002;

    void Start()
    {
        animator = GetComponent<Animator>();
        MainModel.currentTime = 0f;
    }

    void Update()
    {
        if (MainModel.currentTime < duration)
        {

            if (MainModel.Eat > 0)
            {
                MainModel.Eat -= Time.deltaTime * 0.2f;
            }

            if (MainModel.Feeling > 0)
            {
                MainModel.Feeling -= Time.deltaTime * 0.2f;
            }

            if (MainModel.Flexible > 0)
            {
                MainModel.Flexible -= Time.deltaTime * 0.2f;
            }

            if (MainModel.currentTime < 60)
            {
                animator.SetInteger("chanceWin", 1);
            }
            else if (MainModel.currentTime >= 60 && MainModel.currentTime < 120 )
            {
                animator.SetInteger("chanceWin", 2);
            }
            else if (MainModel.currentTime >= 120 && MainModel.currentTime < 180)
            {
                animator.SetInteger("chanceWin", 3);
            }
            else if (MainModel.currentTime >= 180 && MainModel.currentTime < 240)
            {
                animator.SetInteger("chanceWin", 4);
            }
            MainModel.currentTime += Time.deltaTime;
        }
        else
        {
            if (goSleep)
            {
                MainModel.currentTime = 0f;
                goSleep = false;
            }
        }
    }
}
