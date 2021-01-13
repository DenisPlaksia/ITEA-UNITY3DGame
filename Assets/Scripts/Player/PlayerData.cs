using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerData : MonoBehaviour
{
    private static string _name = "No name";
    public event Action<string> OnNameChange;
    public static string Name
    {
        get
        {
            return _name;
        }
    }
    private void Start()
    {
        _name = PlayerPrefs.GetString("Name");
        gameObject.name = _name;
    }
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
