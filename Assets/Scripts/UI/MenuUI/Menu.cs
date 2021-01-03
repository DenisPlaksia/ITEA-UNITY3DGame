using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private GameObject _customPanel;
    [SerializeField] private GameObject _settingPanel;
    [SerializeField] private GameObject _chooseGamePanel;
    [SerializeField] private GameObject _nameChagePanel;
    [SerializeField] private Button _nameChange;
    [SerializeField] private Button _setting;
    [SerializeField] private Button _custom;
    [SerializeField] private Button _chooseGame;

    private void Start()
    {
        _nameChange.onClick.AddListener(OpenNameChangeWindow);
        _menuPanel.SetActive(true);
        _nameChagePanel.SetActive(false);
        _setting.onClick.AddListener(OpenSettingPanel);
        _custom.onClick.AddListener(OpenCustomPanel);
        _chooseGame.onClick.AddListener(OpenChooseGamePanel);
    }

    private void OpenNameChangeWindow()
    {
        _nameChagePanel.SetActive(true);
    }
    private void OpenSettingPanel()
    {
        _menuPanel.SetActive(false);
        _settingPanel.SetActive(true);
    }

    private void OpenCustomPanel()
    {
        _menuPanel.SetActive(false);
        _customPanel.SetActive(true);
    }

    private void OpenChooseGamePanel()
    {
        _menuPanel.SetActive(false);
        _chooseGamePanel.SetActive(true);
    }
}
