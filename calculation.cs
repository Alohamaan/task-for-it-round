using UnityEngine;
using TMPro;
using System;

public class calculation : MonoBehaviour
{
    public TMP_Text text;
    [SerializeField] private TMP_InputField heigth;
    [SerializeField] private TMP_InputField weigth;
    private static float high;
    private static float mass;
    internal static string ResultText;
    private static string MessageOfYourBMI;
    internal static double result;
    internal static bool isLanguageEnglish = false;

    public void Calculation()
    {
        high = Convert.ToSingle(heigth.text);
        mass = Convert.ToSingle(weigth.text);

        if(high != 0 && mass != 0)
        {
            result = Math.Round(mass/(high*high), 2);
            ResultText = isLanguageEnglish ? $"Your BMI equals {Convert.ToString(result)}, you have " : $"Ваш ИМТ равен {Convert.ToString(result)}, y вас ";
            
        }

        if(result >= 0 && result <= 16)
        {
            MessageOfYourBMI = isLanguageEnglish ? "pronounced body weight deficiency" : "выраженный дефицит массы тела";
        } 
        
        else if(result > 16 && result <= 18.5 )
        {
            MessageOfYourBMI = isLanguageEnglish ? "insufficient (deficiency) body weight" : "недостаточная (дефицит) масса тела";
        }

        else if(result > 18.5 && result <= 25)
        {
            MessageOfYourBMI = isLanguageEnglish ? "norm weight" : "нормальный вес";
        }

        else if(result > 25 && result <= 30)
        {
            MessageOfYourBMI = isLanguageEnglish ? "overweight (pre-obesity)" : "избыточная масса тела (предожирение)";
        }

        else if(result > 30 && result <= 35)
        {
            MessageOfYourBMI = isLanguageEnglish ? "obesity of the 1st degree" :  "ожирение 1 степени";
        }

        else if(result > 35 && result <= 40)
        {
            MessageOfYourBMI = isLanguageEnglish ? "obesity of the 2nd degree" : "Ожирение 2 степени";
        }

        else if(result > 40)
        {
            MessageOfYourBMI = isLanguageEnglish ? "obesity of the 3rd degree" : "ожирение 3 степени";
        }

        ResultText += MessageOfYourBMI;
        text.text = ResultText;
    }
}    