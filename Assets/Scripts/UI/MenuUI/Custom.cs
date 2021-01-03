using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Custom : MonoBehaviour
{
    [SerializeField] private GameObject _customPanel;
    [SerializeField] private GameObject _menuPanel;
    [SerializeField] private TMP_Dropdown towerItem;
    [SerializeField] private Tank tank;
    [SerializeField] private Button _backButton;
    [SerializeField] private TankItem tankItem;
    private void Start()
    {
        _backButton.onClick.AddListener(BackButton);
        towerItem.onValueChanged.AddListener(SetTowerTank);
    }

    private void BackButton()
    {
        _menuPanel.SetActive(true);
        _customPanel.SetActive(false);
    }


    private void SetTowerTank(int value)
    {
        Test.TowerTankData = tankItem.towerTankDatas[value];
        tank.Tower.SetTowerTankData(tankItem.towerTankDatas[value]);
    }
}


[Serializable]

public class TankItem
{
    public List<TowerTankData> towerTankDatas = new List<TowerTankData>();
}
