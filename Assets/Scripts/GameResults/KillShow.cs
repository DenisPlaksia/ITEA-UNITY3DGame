using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KillShow : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _kill;
    [SerializeField] private List<Tank> tanks;
    private void Start()
    {
        var tank = GameObject.FindObjectsOfType<Tank>();
        tanks.AddRange(tank);

        foreach (var item in tanks)
        {
            item.OnDeath += ShowKill;
        }
    }

    private void ShowKill(Tank tank,string name)
    {
        var txt = Instantiate(_kill);
        txt.transform.parent = transform;
        txt.SetText($"{name} kill {tank.name}");
        Destroy(txt, 3);
    }
}
