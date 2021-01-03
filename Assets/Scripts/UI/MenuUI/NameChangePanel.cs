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
    [SerializeField] private PlayerData playerData;

    private void Start()
    {
        saveName.onClick.AddListener(SetNameFromInput);
        inputField.onValueChanged.AddListener(GetNameFromInput);
    }
    private void SetNameFromInput()
    {
        _nameChangePanel.SetActive(false);
        PlayerPrefs.SetString("Name", playerData.GetName());
    }
    private void GetNameFromInput(string name)
    {
        playerData.SetName(name);
    }
}
