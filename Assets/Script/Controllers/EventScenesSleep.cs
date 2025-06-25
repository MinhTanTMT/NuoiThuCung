using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventScenesSleep : MonoBehaviour
{
    private float duration = 5f;
    private float elapsedTime = 0f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
        }
        else
        {
            elapsedTime = 0f;
            SceneManager.LoadScene(1);
        }
    }
}
