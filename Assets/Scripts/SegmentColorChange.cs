using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SegmentColorChange : MonoBehaviour
{
    [SerializeField] Material redColor;
    [SerializeField] Material offColor;

    [SerializeField] GameObject[] Segments;
    [SerializeField] TMP_InputField sayiInput;
    [SerializeField] Button button;
    int sayi;
    int[][] segmentIndex = new int[][] 
    {
        new int[] {0, 1, 2, 4, 5, 6}, //0
        new int[] {2, 4}, //1
        new int[] {0, 2, 3, 5, 6}, //2
        new int[] {0, 2, 3, 4, 6}, //3
        new int[] {1, 2, 3, 4,}, //4
        new int[] {0, 1, 3, 4, 6}, //5      
        new int[] {0, 1, 3, 4, 5, 6}, //6
        new int[] {0, 2, 4}, //7
        new int[] {0, 1, 2, 3, 4, 5, 6}, //8
        new int[] {0, 1, 2, 3, 4, 6} //9
    };
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }
    void OnButtonClick()
    {
        SayiGir(sayiInput.text);
    }

    public void SayiGir(string input)
    {
        if (int.TryParse(input, out sayi)) 
        {
            ChangeColor();    
        
        }
        
    }

    public void ChangeColor()
    {
        foreach (GameObject segment in Segments)
        {
            segment.GetComponent<Renderer>().material = offColor;
        }

        switch (sayi)
        {
            case 0:
                foreach (int index in segmentIndex[0])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 1:
                foreach (int index in segmentIndex[1])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 2:
                foreach (int index in segmentIndex[2])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 3:
                foreach (int index in segmentIndex[3])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 4:
                foreach (int index in segmentIndex[4])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 5:
                foreach (int index in segmentIndex[5])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 6:
                foreach (int index in segmentIndex[6])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 7:
                foreach (int index in segmentIndex[7])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 8:
                foreach (int index in segmentIndex[8])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            case 9:
                foreach (int index in segmentIndex[9])
                {
                    Segments[index].GetComponent<Renderer>().material = redColor;
                }
                break;

            default:
                Debug.LogError("Sayi 1-9 arasi olmali.");
                break;
        }
    }


    public void OffColor()
    {
        foreach (GameObject segment in Segments)
        {
            segment.GetComponent<Renderer>().material = offColor;
        }
    } 
} 
