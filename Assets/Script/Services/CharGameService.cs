using Assets.Script.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine;
using Assets.Script.Interfaces;

namespace Assets.Script.Services
{
    public class CharGameService : ICharGame
    {
        private CharGameModel _charGameModel;
        private readonly Transform _transform;

        public CharGameService(Transform transform)
        {
            _charGameModel = new CharGameModel();
            _transform = transform;
        }

        public Rigidbody2D CharRigid
        {
            get => _charGameModel.rb;
            set 
            {
                _charGameModel.rb = value;
            }
        }

        public Animator CharAnimator
        {
            get => _charGameModel.animator;
            set
            {
                _charGameModel.animator = value;
            }
        }

        public SpriteRenderer CharSpriteRenderer
        {
            get => _charGameModel.spriteRenderer;
            set
            {
                _charGameModel.spriteRenderer = value;
            }
        }

        public void InitializeInitialValue()
        {
            _charGameModel.speed = 5f;
            _charGameModel.jumPower = 10;
        }

        public void CollisionHandling(Collision2D collision)
        {
            // Reset canJump when the player touches the ground
            if (collision.gameObject.CompareTag("Ground"))
            {
                _charGameModel.canJump = true;
                CharRigid.SetRotation(0);
            }

            if (collision.gameObject.CompareTag("Money"))
            {
                //_charGameModel.Gold = true;

                MainModel.Money = MainModel.Money + 1;
            }
        }

        private int InputMoveHandling(KeyCode keyInput)
        {
            switch (keyInput)
            {
                case KeyCode.RightArrow:
                    CharAnimator.SetInteger("targetAnimation", 1);
                    _charGameModel.spriteRenderer.flipX = false;
                    return 1;
                case KeyCode.LeftArrow:
                    CharAnimator.SetInteger("targetAnimation", 1);
                    _charGameModel.spriteRenderer.flipX = true;
                    return -1;
                default:
                    CharAnimator.SetInteger("targetAnimation", 0);
                    return 0;
            }
        }


        public void EventHandling()
        {
            int move = 0;
            bool keyPressed = false;

            foreach (KeyCode key in _charGameModel.Keys)
            {
                if (Input.GetKey(key))
                {
                    move += InputMoveHandling(key);
                    keyPressed = true;
                }
            }

            if (!keyPressed)
            {
                move = InputMoveHandling(KeyCode.None);
            }

            if (_charGameModel.canJump && Input.GetKeyDown(KeyCode.Space))
            {
                _charGameModel.canJump = false;
                CharRigid.AddForce(Vector2.up * _charGameModel.jumPower, ForceMode2D.Impulse);
            }

            _transform.Translate((_charGameModel.speed) * move * Time.deltaTime * Vector3.right);

            //if (_charGameModel.Gold)
            //{
            //    _charGameModel.Gold = false;

            //    Debug.Log(MainModel.Score);
            //}
            Debug.Log(MainModel.Score);
        }

    }
}
