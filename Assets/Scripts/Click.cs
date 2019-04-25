using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// this triggers when a button is pressed

public class Click : MonoBehaviour
{

    

    public void OnButtonClick()
    {
        Debug.Log("Clicked!");
        Utils.addPoints(1);
    }

    

    

}
