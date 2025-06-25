using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptGoUp : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        if (MainModel.currentTime < 240)
        {
            Vector3 targetPosition1 = new Vector3(-5.48f, -1.2931f, 0f);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition1, moveSpeed * Time.deltaTime);
        }
        else if (MainModel.currentTime >= 240)
        {
            Vector3 targetPosition2 = new Vector3(-15.04f, 7.4f, 0f);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition2, moveSpeed * Time.deltaTime);
        }
    }
}
