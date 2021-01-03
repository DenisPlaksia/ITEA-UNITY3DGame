using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameChangePanel : MonoBehaviour
{
    [SerializeField] private GameObject _nameChangePanel;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Button saveName;


    private void Start()
    {
        saveName.onClick.AddListener(SetNameFromInput);
        
    }
    private void SetNameFromInput()
    {
        inputField.onValueChanged.AddListener(GetNameFromInput);
        _nameChangePanel.SetActive(false);
    }
    private void GetNameFromInput(string name)
    {
        PlayerData.Name = name;
    }
}
