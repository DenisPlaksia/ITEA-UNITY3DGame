using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameResults : MonoBehaviour
{
    [SerializeField] private GameObject _windowGameResult;
    [SerializeField] private Button _menuBackButton;
    [SerializeField] private TextMeshProUGUI _title;
    [SerializeField] private TextMeshProUGUI _kill;
    private void Start()
    {
        _menuBackButton.onClick.AddListener(OpenMenuButton);
    }

    public void OpenWindow()
    {
        _windowGameResult.SetActive(true);
    }

    private void OpenMenuButton()
    {
        ScenesLoader.Load(ScenesLoader.Scene.Menu);
    }

    public void SetResults(string title)
    {
        _title.SetText(title);
        _kill.SetText((PlayerResults.kill).ToString());
    }
}
