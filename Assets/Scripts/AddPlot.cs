using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class AddPlot : MonoBehaviour
{

    public GameObject plotObject; // object to spawn
    public GameObject plotContentArea;


    public void BuyPlot()
    {
        Utils.subtractPoints(Game.plotPrice); // subtract price of plot
        Game.plotPrice = Utils.scale(Game.plotPrice); // increase price
        Game.numberOfPlots += 1; // inc plot count
        SpawnPlot();
        GameObject.Find("BuyPlotButton").GetComponentInChildren<Text>().text = "Buy Plot ($" + Utils.roundedFloatToString(Game.plotPrice) + ")"; // update price on button
    }

    public void SpawnPlot() // adds 1 plot to plot content area
    {

        //create a new item, name it, and set the parent
        GameObject newItem = Instantiate(plotObject) as GameObject;
        newItem.name = "Plot number " + Game.numberOfPlots;
        newItem.transform.parent = gameObject.transform;

        //move and size the new item
        RectTransform rectTransform = newItem.GetComponent<RectTransform>();
        newItem.transform.localScale = new Vector3(1, 1, 1);
    }
}
