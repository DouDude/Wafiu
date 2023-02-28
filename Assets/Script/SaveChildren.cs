using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveChildren : MonoBehaviour
{
    public int childCount = 0;
    public int totalChildren = 12;
    private Text childrenLeftText;



    void Update()
    {
    

        if (childCount >= totalChildren)
        {
           
        }

     
        if (childrenLeftText != null)
    {
        childrenLeftText.text = (totalChildren - childCount).ToString();
    }
    else
    {
        Debug.LogError("childrenLeftText is null");
    }
    }

 
}
