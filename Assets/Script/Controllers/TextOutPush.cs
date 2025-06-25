using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextOutPust : MonoBehaviour
{

    public Text text;

    void Start()
    {
        
    }

    private void Update()
    {
        text.text = "Số điểm: " + MainModel.Score +"\n"
            + "Đồ ăn: " + MainModel.Food +"\n"
            + "Thuốc men: " + MainModel.Medicine +"\n"
            + "Bụng chuột: " + TextEmotion() + "\n"
            //+ "Sự linh hoạt: " + MainModel.Flexible +"\n"
            //+ "Cảm xúc: " + MainModel.Feeling +"\n"
            //+ "Nước: " + MainModel.Water + "\n"
            + "Money: " + MainModel.Money + "\n"
            //+ "Cho an: " + MainModel.ChoAn + "\n"
            //+ "Do binh nuoc: " + MainModel.DoBinhNuoc + "\n"
            //+ "Vuot ve: " + MainModel.VuoiVe + "\n"
            ;
    }

    private string TextEmotion()
    {
        if (MainModel.Food > 2)
        {
            return "Đói";
        } 
        else if (MainModel.Food > 8)
        {
            return "No";
        }
        else
        {
            return "Thường";
        }
    }



}
