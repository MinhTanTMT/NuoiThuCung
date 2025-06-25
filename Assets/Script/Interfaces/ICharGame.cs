using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Script.Interfaces
{
    internal interface ICharGame
    {
        Rigidbody2D CharRigid { set; }
        Animator CharAnimator { set; }
        SpriteRenderer CharSpriteRenderer { set; }
        void InitializeInitialValue();
        void CollisionHandling(Collision2D collision);
        void EventHandling();
    }
}
