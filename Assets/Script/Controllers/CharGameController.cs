using Assets.Script.Interfaces;
using Assets.Script.Models;
using Assets.Script.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharGameController : MonoBehaviour
{

    private ICharGame _charGame;

    private void Awake()
    {
        _charGame = new CharGameService(transform);
    }


    private void OnAnimatorMove()
    {
        
    }

    private void OnMouseDown()
    {
        
    }

    void Start()
    {
        Time.fixedDeltaTime = 0.01f;
        _charGame.InitializeInitialValue();
        _charGame.CharAnimator = GetComponent<Animator>();
        _charGame.CharRigid = GetComponent<Rigidbody2D>();
        _charGame.CharSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        _charGame.EventHandling();
    }


    void FixedUpdate()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        _charGame.CollisionHandling(collision);
    }


}
