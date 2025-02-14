using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SegmentColorChange : MonoBehaviour
{
    [SerializeField] protected TMP_InputField sayiInput;
    [SerializeField]  protected Button button;
    [SerializeField] protected List<GameObject> Digits = new List<GameObject>();
    protected int sayi;
   
    private List<int> rakamlar = new List<int>();

    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    public void OnButtonClick()
    {
        RakamlaraAyir(sayiInput.text);
    }
     void RakamlaraAyir(string input)
    {
        if(int.TryParse(input, out sayi))
        {
            rakamlar.Clear();
            // int yuzler = sayi / 100;
            // int onlar = (sayi % 100) / 10;
            // int birler = sayi % 10;
            // rakamlar.Add(yuzler);
            // rakamlar.Add(onlar);
            // rakamlar.Add(birler);

            for (int i = 0; i < Digits.Count; i++)
            {
                int hane = (sayi / (int)Mathf.Pow(10, i)) % 10;
                rakamlar.Add(hane);   
            }
            rakamlar.Reverse();
            DigitlereGonder();          
        }
    }

    void DigitlereGonder()
    {
        for (int i = 0; i < Digits.Count; i++)
        {
            Digits[i].GetComponent<Digit>().ChangeColor(rakamlar[i]);
        }
    }
 
    

} 
