using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Script.Interfaces
{
    public interface IEventSystem
    {
        /// <summary>Update all states</summary>
        void UpdateEventSystem();

        /// <summary>Feed the pet</summary>
        void Feeding();

        /// <summary>Pet interaction</summary>
        void Caress();

        /// <summary>Heal the pet</summary>
        void Treatment();

        /// <summary>Earn some money</summary>
        void Earnmoney();

        /// <summary>Go outside</summary>
        void GoOut();

        /// <summary>Water the plant</summary>
        void PourWater();

        /// <summary>Make it dance</summary>
        void Dance();
    }

}
