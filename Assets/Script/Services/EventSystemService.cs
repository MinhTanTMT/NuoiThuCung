using Assets.Script.Interfaces;
using Assets.Script.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Script.Services
{
    public class EventSystemService : IEventSystem
    {
        private EventSystemModel _eventSystemModel;

        public EventSystemService()
        {
            _eventSystemModel = new EventSystemModel();
        }

        public void UpdateEventSystem()
        {
            if (MainModel.currentTime < 240)
            {
                if (_eventSystemModel.elapsedTime < _eventSystemModel.duration && _eventSystemModel.runTimeOfAction)
                {
                    _eventSystemModel.elapsedTime += Time.deltaTime;
                }
                else
                {
                    if (_eventSystemModel.runOnlyFirst)
                    {
                        MainModel.typeAction = false;
                        _eventSystemModel.runOnlyFirst = false;
                        _eventSystemModel.runTimeOfAction = false;
                    }
                    else
                    {
                        _eventSystemModel.elapsedTime = 0f;
                        MainModel.myAction = 0;
                        MainModel.mouseAction = 0;
                        _eventSystemModel.runOnlyFirst = true;
                    }
                }
            }
            else if (MainModel.currentTime >= 240)
            {
                MainModel.typeAction = true;
                MainModel.myAction = 0;
                MainModel.mouseAction = 6;
            }
        }


        public void Feeding()
        {
            if (MainModel.Food > 0 && MainModel.Eat < 10)
            {
                MainModel.Eat += 3;
                MainModel.Feeling += 1;
                MainModel.Food -= 1;
                MainModel.typeAction = true;
                _eventSystemModel.runTimeOfAction = true;
                MainModel.myAction = 1;
                _eventSystemModel.duration = 7f;
                MainModel.ChoAn += 1;
            }
        }

        public void Caress()
        {
            if (MainModel.Feeling < 10)
            {
                MainModel.Feeling += 2;
            }
        }

        public void Treatment()
        {
            if (MainModel.Medicine > 0 && MainModel.Flexible < 10)
            {
                MainModel.Flexible += 3;
                MainModel.Medicine -= 1;
            }
            MainModel.VuoiVe += 1;
        }

        public void Earnmoney()
        {
            //Models.Score += 10;
            SceneManager.LoadScene("Income");
        }

        public void GoOut()
        {
            SceneManager.LoadScene("MainMenu");
        }

        public void PourWater()
        {
            if (MainModel.Water < 4)
            {
                MainModel.Water += 1;
                WaterBottle.loseWater = true;
            }
            MainModel.DoBinhNuoc += 1;
        }

        public void Dance()
        {
            MainModel.typeAction = true;
            _eventSystemModel.runTimeOfAction = true;
            MainModel.myAction = 4;
            _eventSystemModel.duration = 9f;
        }
    }
}
