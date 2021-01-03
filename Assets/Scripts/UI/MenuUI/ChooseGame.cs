using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChooseGame : MonoBehaviour
{
    [SerializeField] private GameObject _chooseGamePanel;
    [SerializeField] private GameObject _menuPanel;


    [SerializeField] private Button _backButton;
    [SerializeField] private Button _PVPButton;


    private void Start()
    {
        _backButton.onClick.AddListener(BackButton);
        _PVPButton.onClick.AddListener(OpenPVPGame);
    }

    private void BackButton()
    {
        _menuPanel.SetActive(true);
        _chooseGamePanel.SetActive(false);
    }

    private void OpenPVPGame()
    {
        SceneManager.LoadScene("PVPScenes");
    }
}
