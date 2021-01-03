using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerData : MonoBehaviour
{
    private static string _name = "No name";
    public event Action<string> OnNameChange;


    public string GetName() => _name;
    public void SetName(string name)
    {
        if(name.Length > 9)
        {
            _name = " ";
        }
        else
        {
            _name = name;
            OnNameChange.Invoke(name);
        }
    }
}
