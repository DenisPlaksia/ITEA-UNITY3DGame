using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PVPGameManger : MonoBehaviour
{
    [SerializeField] private GameResults gameResults;
    private List<Enemy> enemyList = new List<Enemy>();
    private List<Teammate> teamList = new List<Teammate>();
    [SerializeField] private TextMeshProUGUI _PlayerCount;

    private void Start()
    {
        var enemy = GameObject.FindObjectsOfType<Enemy>();
        var team = GameObject.FindObjectsOfType<Teammate>();

        enemyList.AddRange(enemy);
        teamList.AddRange(team);
        _PlayerCount.SetText($"Team:{teamList.Count} vs Enemy:{enemyList.Count}");
        foreach (var item in enemyList)
        {
            item.GetComponent<Tank>().OnDeath += RemoveFromEnemyList;
        }

        foreach (var item in teamList)
        {
            item.GetComponent<Tank>().OnDeath += RemoveFromTeammateList;
        }
    }

    private void RemoveFromEnemyList(Tank tank,string name)
    {
        _PlayerCount.SetText($"Team:{teamList.Count} vs Enemy:{enemyList.Count}");
        enemyList.Remove(tank.GetComponent<Enemy>());
        if(enemyList.Count == 0)
        {
            gameResults.OpenWindow();
            gameResults.SetResults("You win");
        }
    }

    private void RemoveFromTeammateList(Tank tank, string name)
    {
        _PlayerCount.SetText($"Team:{teamList.Count} vs Enemy:{enemyList.Count}");
        teamList.Remove(tank.GetComponent<Teammate>()); 
        if (teamList.Count == 0)
        {
            gameResults.OpenWindow();
            gameResults.SetResults("You lose");
        }
    }

}
