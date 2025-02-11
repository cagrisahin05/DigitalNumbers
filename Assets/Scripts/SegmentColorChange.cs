using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentColorChange : MonoBehaviour
{
    [SerializeField] Material redColor;

    [SerializeField] GameObject[] Segments;
    [SerializeField] int sayi;
    void Start()
    {
        ChangeColor();
    }
    public void ChangeColor()
    {
       switch (sayi)
        {
            case 1:
                sayi = 1;
                Segments[2].GetComponent<Renderer>().material = redColor;
                Segments[4].GetComponent<Renderer>().material = redColor;          
            break;

            case 2:
                sayi = 2;
                Segments[0].GetComponent<Renderer>().material = redColor;
                Segments[2].GetComponent<Renderer>().material = redColor;
                Segments[3].GetComponent<Renderer>().material = redColor; 
                Segments[5].GetComponent<Renderer>().material = redColor;
                Segments[6].GetComponent<Renderer>().material = redColor; 
            break;

            case 3:  
               sayi = 3;
                Segments[0].GetComponent<Renderer>().material = redColor;
                Segments[2].GetComponent<Renderer>().material = redColor;
                Segments[3].GetComponent<Renderer>().material = redColor; 
                Segments[4].GetComponent<Renderer>().material = redColor;
                Segments[6].GetComponent<Renderer>().material = redColor; 
            break;

            case 4:
               sayi = 4;
                Segments[1].GetComponent<Renderer>().material = redColor;
                Segments[2].GetComponent<Renderer>().material = redColor;
                Segments[3].GetComponent<Renderer>().material = redColor; 
                Segments[4].GetComponent<Renderer>().material = redColor; 
            break;

            case 5:
               sayi = 5;
                Segments[0].GetComponent<Renderer>().material = redColor;
                Segments[1].GetComponent<Renderer>().material = redColor;
                Segments[3].GetComponent<Renderer>().material = redColor; 
                Segments[4].GetComponent<Renderer>().material = redColor;
                Segments[6].GetComponent<Renderer>().material = redColor; 
            break;

            case 6:
               sayi = 6;
                Segments[0].GetComponent<Renderer>().material = redColor;
                Segments[1].GetComponent<Renderer>().material = redColor;
                Segments[3].GetComponent<Renderer>().material = redColor;
                Segments[4].GetComponent<Renderer>().material = redColor; 
                Segments[5].GetComponent<Renderer>().material = redColor;
                Segments[6].GetComponent<Renderer>().material = redColor; 
            break;

            case 7:
               sayi = 7;
                Segments[0].GetComponent<Renderer>().material = redColor;
                Segments[2].GetComponent<Renderer>().material = redColor;
                Segments[4].GetComponent<Renderer>().material = redColor; 
            break;  

            case 8:
               sayi = 8;
                Segments[0].GetComponent<Renderer>().material = redColor;
                Segments[1].GetComponent<Renderer>().material = redColor;
                Segments[2].GetComponent<Renderer>().material = redColor;
                Segments[3].GetComponent<Renderer>().material = redColor; 
                Segments[4].GetComponent<Renderer>().material = redColor; 
                Segments[5].GetComponent<Renderer>().material = redColor;
                Segments[6].GetComponent<Renderer>().material = redColor;
            break;

            case 9:
               sayi = 9;
                Segments[0].GetComponent<Renderer>().material = redColor;
                Segments[1].GetComponent<Renderer>().material = redColor;
                Segments[2].GetComponent<Renderer>().material = redColor;
                Segments[3].GetComponent<Renderer>().material = redColor; 
                Segments[4].GetComponent<Renderer>().material = redColor; 
                Segments[6].GetComponent<Renderer>().material = redColor;
            break;    

            default:
                Segments[0].GetComponent<Renderer>().material = redColor;
                Segments[1].GetComponent<Renderer>().material = redColor;
                Segments[2].GetComponent<Renderer>().material = redColor;
                Segments[4].GetComponent<Renderer>().material = redColor; 
                Segments[5].GetComponent<Renderer>().material = redColor; 
                Segments[6].GetComponent<Renderer>().material = redColor;
            break;
            
            
        }
      
    }
}
