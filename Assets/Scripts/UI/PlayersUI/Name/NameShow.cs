using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;
    [SerializeField] private PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        ShowName(PlayerPrefs.GetString("Name"));
        playerData.OnNameChange += ShowName;
    }

    private void ShowName(string name)
    {
        _name.SetText(name);
    }
}
