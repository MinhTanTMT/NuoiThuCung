using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pikachu : MonoBehaviour
{

    //public Models models = new Models();

    public float speed;
    Animator animator;
    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private float duration = 3f;
    private float elapsedTime = 0f;
    private int setActionRandom = 1;
    private bool noMoveAnyMore = true;


    public int routeSleep = 0;

    // Start is called before the first frame update
    void Start()
    {
        //models.Score = 3;
        animator = GetComponent<Animator>();
        speed = 5f;
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

    }
    // Update is called once per frame

    private void FixedUpdate()
    {
        
    }

    void Update()
    {
        //Debug.Log("Da cham tuong la : " + noMoveAnyMore);
        //Debug.Log("So lieu cua ben kia la : " + Models.Eat);

        if (MainModel.typeAction)
        {
            MyActionCommand();
        }
        else
        {
            if (elapsedTime < duration)
            {
                if (!noMoveAnyMore)
                {
                    UpdateStateMouseActionRandom();
                }
                else
                {     
                    animator.SetInteger("isAnimation", 0);
                }
                elapsedTime += Time.deltaTime;
            }
            else
            {
                animator.SetInteger("isAnimation", 0);
                noMoveAnyMore = false;
                duration = Random.Range(1, 3);
                setActionRandom = Random.Range(1, 15);
                elapsedTime = 0f;
            }
        }
    }

    private void MyActionCommand()
    {

        switch(MainModel.myAction)
        {
            case 1:
                // cho an
                animator.SetInteger("isAnimation", 5);
                MainModel.Eat += 3;
                break;
            case 2:
                // takecare
                MainModel.Feeling += 3;
                break;
            case 3:
                break;
            case 4:
                animator.SetInteger("isAnimation", 7);
                break;
            default:
                CurrentStateMouse();
                break;
        }
    }

    private void CurrentStateMouse()
    {
        switch (MainModel.mouseAction)
        {
            case 1:
                // thank
                break;
            case 2:
                // sick
                animator.SetInteger("isAnimation", 6);
                break;
            case 3:
                // hate
                break;
            case 4:
                // !want
                break;
            case 5:
                // drink
                break;
            case 6:
                GoSleep();
                break;
            default:
                animator.SetInteger("isAnimation", 0);
                break;
        }
    }

    private void GoSleep()
    {
        Vector3 targetPosition2 = new Vector3(-20.91f, 5.02f, 0f);

        Vector3 targetPosition1 = new Vector3(15.34f, -3.87f, 0f);

        if (transform.position == targetPosition1)
        {
            routeSleep = 1;
        }
        if (transform.position == targetPosition2)
        {
            routeSleep = 0;
        }

        if (routeSleep == 0)
        {
            spriteRenderer.flipX = true;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition1, speed * Time.deltaTime);
            animator.SetInteger("isAnimation", 1);
        }
        else if (routeSleep == 1)
        {
            spriteRenderer.flipX = false;
            transform.position = Vector3.MoveTowards(transform.position, targetPosition2, speed * Time.deltaTime);
            animator.SetInteger("isAnimation", 1);
        }
    }

    private void UpdateStateMouseActionRandom()
    {
        switch (setActionRandom)
        {
            case 1:
                animator.SetInteger("isAnimation", 1);
                spriteRenderer.flipX = true;
                transform.Translate(Vector3.right * (speed) * Time.deltaTime);
                break;
            case 2:
                animator.SetInteger("isAnimation", 1);
                spriteRenderer.flipX = false;
                transform.Translate(Vector3.left * (speed) * Time.deltaTime);
                break;
            case 3:
                animator.SetInteger("isAnimation", 1);
                transform.Translate(Vector3.up * (speed) * Time.deltaTime);
                break;
            case 4:
                animator.SetInteger("isAnimation", 1);
                transform.Translate(Vector3.down * (speed) * Time.deltaTime);
                break;
            case 5:
                animator.SetInteger("isAnimation", 2);
                break;
            case 6:
                animator.SetInteger("isAnimation", 3);
                break;
            case 7:
                animator.SetInteger("isAnimation", 4);
                break;
            default:
                animator.SetInteger("isAnimation", 0);
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            noMoveAnyMore = true;
            rb.SetRotation(0);
        }
        if (collision.gameObject.CompareTag("drinkWater"))
        {
            noMoveAnyMore = true;
            if (MainModel.Water > 1)
            {
                MainModel.Water -= 1;
                WaterBottle.loseWater = true;
            }
            rb.SetRotation(0);
        }
        
        if (collision.gameObject.CompareTag("placeSleep"))
        {
            Debug.Log("Đã xảy ra va chạm");
            Windows.goSleep = true;
            SceneManager.LoadScene(2);
        }
    }
}
