using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    private static string name = "Denis";
    public static string Name
    {
        get => name;
        set
        {
            if(value.Length > 9)
            {
                name = " ";
            }
            else
            {
                name = value;
            }
        }
    }
}
