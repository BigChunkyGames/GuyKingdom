using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

// handles UI and saveable data.

public class Game : MonoBehaviour
{
    public static bool Devmode = true;
    
    public const float SCALE = 1.35f;

    public GameObject pointsText;
    public static float points; // currency
    public static string currency = " shillings";

    public GameObject plotsButton;
    public static int plotPrice = 20;
    public static int numberOfPlots = 0;

    public Dictionary<string, int> milestones = new Dictionary<string, int>();

    void Update()
    {
        // keeps points counter UI up to date
        pointsText.GetComponent<Text>().text = points.ToString() +" "+ currency; 
        checkForMilestones();
    }

    public void checkForMilestones()
    { // iterate through milestones and unlock (set visible) if sufficient points. then remove from dict so its faster
        foreach (var i in milestones)
        {
            if(points >= i.Value)
            {
                if(i.Key == "unlock plots")
                {
                    plotsButton.SetActive(true);
                    Debug.Log("set it visible");
                    milestones.Remove("unlock plots");
                    return; // have to return to prevent problems mutating in a foreach loop
                }
            }
        }
    }



    void Start()
    {
        if (!Devmode) // if not in devmode
        {
            // hide locked
            plotsButton.SetActive(false);
        }
        

        // build milestones
        milestones.Add("unlock plots", 15);
    }
}
