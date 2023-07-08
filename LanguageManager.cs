using UnityEngine;
using TMPro;
using System;

public class LanguageManager : MonoBehaviour
{
    [SerializeField] private TMP_Text inputYourHeight;
    [SerializeField] private TMP_Text inputYourMass;
    [SerializeField] private TMP_Text ChangeLanguage;
    [SerializeField] private TMP_Text Calculate;
    void Update()
    {
        calculation.ResultText = calculation.isLanguageEnglish ? $"Your BMI equals {Convert.ToString(calculation.result)}, you have " : $"Ваш ИМТ равен {Convert.ToString(calculation.result)}, y вас ";
        if(calculation.isLanguageEnglish)
        {
            inputYourHeight.text = "enter your height";
            inputYourMass.text = "enter your weight";
            ChangeLanguage.text = "Change Language";
            Calculate.text = "Calculate";
        }
        else
        {
            inputYourMass.text = "Введите свой вес";
            inputYourHeight.text = "Введите свой рост";
            ChangeLanguage.text = "Сменить язык";
            Calculate.text = "Сосчитать";
        }
    }
}
