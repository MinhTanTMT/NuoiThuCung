using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Models
{
    [System.Serializable]
    public class CharGameModel
    {
        public KeyCode[] Keys = new[] { KeyCode.LeftArrow, KeyCode.RightArrow };
        public bool Gold = true;
        public int Score = 0;
        public float speed;
        public Animator animator;
        public int jumPower;
        public Rigidbody2D rb;
        public SpriteRenderer spriteRenderer;

        public bool canJump = true;
    }
}
