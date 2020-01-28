using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValorPanfleto : MonoBehaviour
{
    private string panfletoName;
    public int panfletoValue;
    
    void Start()
    {
        panfletoName = name.Substring(0, 5);

        switch (panfletoName)
        {
            case "panf1":
                panfletoValue = 1;
                break;
        }
        
    }
}
