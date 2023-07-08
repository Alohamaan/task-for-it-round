using TMPro;
using UnityEngine;

public class languageChange : MonoBehaviour
{
    private static int language_number = 0;
    [SerializeField] private TMP_Text finaltext;
    public void ChangeLanguage()
    {
        language_number++;
        calculation.isLanguageEnglish = language_number % 2 == 0 ? false : true;
        finaltext.text = " ";
    }
}
