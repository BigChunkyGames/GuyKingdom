using UnityEngine;
using System;
using System.Text;

public class Utils : MonoBehaviour
{

    public static void addPoints(int pointsToAdd)
    {
        if(Game.points + pointsToAdd >= 0 || Game.Devmode) // if subtracting is not affordable. can go negative in dev mode
        {
            Game.points += pointsToAdd;
            Debug.Log("Adding " + pointsToAdd.ToString() + " points");
        } else
        {
            Debug.Log("Not enough money!");
        }
        
    }

    public static void subtractPoints(int pointsToSubtract)
    {
        addPoints(-1 * pointsToSubtract);
    }

    public static int scale(int numberToGetScaled)
    {
        return (int)((float)numberToGetScaled * Game.SCALE);
    }

    public static string roundedFloatToString(float n) // unused 
    {
        return String.Format("{0:n0}", n); // "12,346"
    }
}
