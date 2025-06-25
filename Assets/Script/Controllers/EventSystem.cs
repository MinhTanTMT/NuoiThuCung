using Assets.Script.Services;
using Assets.Script.Interfaces;
using Assets.Script.Models;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventSystem : MonoBehaviour
{

    private IEventSystem _eventSystem;

    private void Awake()
    {
        _eventSystem = new EventSystemService();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _eventSystem.UpdateEventSystem();
    }

    public void OnFeeding() => _eventSystem.Feeding();

    public void OnCaress() => _eventSystem.Caress();

    public void OnTreatment() => _eventSystem.Treatment();

    public void OnEarnmoney() => _eventSystem.Earnmoney();

    public void OnGoOut() => _eventSystem.GoOut();

    public void OnPourWater() => _eventSystem.PourWater();


    public void OnDance() => _eventSystem.Dance();

}
