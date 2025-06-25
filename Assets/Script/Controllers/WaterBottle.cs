using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBottle : MonoBehaviour
{

    private Animator animator;

    public static bool loseWater;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (loseWater)
        {
            animator.SetInteger("Water", 0);
            loseWater = false;
        }
        else
        {
            switch (MainModel.Water)
            {
                case 4:
                    animator.SetInteger("Water", 1);
                    break;
                case 3:
                    animator.SetInteger("Water", 2);
                    break;
                case 2:
                    animator.SetInteger("Water", 3);
                    break;
                case 1:
                    animator.SetInteger("Water", 4);
                    break;
            }
        }

    }
}
