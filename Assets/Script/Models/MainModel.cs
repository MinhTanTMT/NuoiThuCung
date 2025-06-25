using UnityEngine;

[CreateAssetMenu(fileName = "NewModels", menuName = "Custom/Models")]
public class MainModel : ScriptableObject
{
    public static string NameMouse;
    public static string NameHuman;

    //Action 
    public static int myAction { get; set; }
    public static bool typeAction = false;
    public static int mouseAction;

    // time
    public static int IdTime;
    public static int NumDay;
    public static int IdWindows;
    public static float currentTime;

    // Status
    public static int Score = 10;
    public static int Money;
    public static int Water = 2;
    public static int Food = 10;
    public static int Medicine = 10;
    public static int HPMouse;
    public static float Eat;
    public static float Flexible;
    public static float Feeling;


    public static float DoBinhNuoc =0;
    public static float VuoiVe = 0;
    public static float ChoAn = 0;
}