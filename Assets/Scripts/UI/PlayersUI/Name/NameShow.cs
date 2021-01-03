using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NameShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _name;

    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {
        _name.SetText(PlayerData.Name);
    }
}
