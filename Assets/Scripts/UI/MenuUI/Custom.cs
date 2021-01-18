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
    [SerializeField] private TMP_Dropdown caterpillarItem;
    [SerializeField] private Tank tank;
    [SerializeField] private Button _backButton;
    [SerializeField] private TankItem tankItem;

    public const string TOWER = "Tower";
    public const string CATERPILLAR = "Caterpillar";

    private void Start()
    {
        _backButton.onClick.AddListener(BackButton);
        towerItem.onValueChanged.AddListener(SetTowerTank);
        caterpillarItem.onValueChanged.AddListener(SetCaterpillar);


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
        PlayerPrefs.SetInt(TOWER, value);
    }

    private void SetCaterpillar(int value)
    {
        Test.CaterpillarTankData = tankItem.caterpillarTankDatas[value];
        tank.Caterpillar.SetCaterpillarTankData(tankItem.caterpillarTankDatas[value]);
        PlayerPrefs.SetInt(CATERPILLAR, value);
    }
}


[Serializable]

public class TankItem
{
    public List<TowerTankData> towerTankDatas = new List<TowerTankData>();
    public List<CaterpillarTankData> caterpillarTankDatas = new List<CaterpillarTankData>();
}
