using UnityEngine;
using UnityEngine.UI;
public class Setting : MonoBehaviour
{
    [SerializeField] private GameObject _settingPanel;
    [SerializeField] private GameObject _menuPanel;


    [SerializeField] private Button _backButton;

    private void Start()
    {
        _backButton.onClick.AddListener(BackButton);
    }

    private void BackButton()
    {
        _menuPanel.SetActive(true);
        _settingPanel.SetActive(false);
    }
}
