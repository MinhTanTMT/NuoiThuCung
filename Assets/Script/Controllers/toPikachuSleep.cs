using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toPikachuSleep : MonoBehaviour
{

    public float moveSpeed = 5f;

    void Update()
    {
        if (MainModel.currentTime < 240)
        {
            Vector3 targetPosition1 = new Vector3(-20.81f, 7.27f, 0f);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition1, moveSpeed * Time.deltaTime);
        }
        else if (MainModel.currentTime >= 240)
        {
            Vector3 targetPosition2 = new Vector3(-20.9f, 5.18f, 0f);
            transform.position = Vector3.MoveTowards(transform.position, targetPosition2, moveSpeed * Time.deltaTime);
        }

    }
}
