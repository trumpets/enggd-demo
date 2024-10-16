using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BarFiller : MonoBehaviour
{
    public Image image;
    
    // Start is called before the first frame update
    void Start()
    {
        image.fillAmount = 0f;
    }

    public void AddToFill(float percentToAdd)
    {
        image.fillAmount += percentToAdd;

        if(image.fillAmount == 1f)
        {
            Debug.Log("I am full");
        }
    }
}
