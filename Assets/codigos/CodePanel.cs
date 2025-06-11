using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePanel : MonoBehaviour
{
    public Text codeText;
    string codeTextValue = "";
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        codeText.text = codeTextValue;
        if (codeTextValue == "7895") {
            movedplayer.isSafeOpened = true;
        }
        if (codeTextValue.Length >= 4) {
            codeTextValue = "";
        }
    }
    public void AddDigit(string digit) {
        codeTextValue += digit;
    }
}
