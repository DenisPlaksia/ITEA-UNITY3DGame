using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PVPGameManger : MonoBehaviour
{
    [SerializeField] private GameResults gameResults;
    private List<Enemy> enemyList = new List<Enemy>();
    private List<Teammate> teamList = new List<Teammate>();


    private void Start()
    {
        var enemy = GameObject.FindObjectsOfType<Enemy>();
        var team = GameObject.FindObjectsOfType<Teammate>();

        enemyList.AddRange(enemy);
        teamList.AddRange(team);
        Debug.Log($"EnemyList Length is {enemyList.Count}");
        Debug.Log($"EnemyList Length is {teamList.Count}");

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
        enemyList.Remove(tank.GetComponent<Enemy>());
        Debug.LogError($"Kill {tank.gameObject.name} == who kill {name}");
        Debug.Log($"EnemyList Length is {enemyList.Count}");

        if(enemyList.Count == 0)
        {
            gameResults.OpenWindow();
            gameResults.SetResults("You win");
        }
    }

    private void RemoveFromTeammateList(Tank tank, string name)
    {
        teamList.Remove(tank.GetComponent<Teammate>()); 
        Debug.LogError($"Kill {tank.gameObject.name} == who kill {name}");
        if (teamList.Count == 0)
        {
            gameResults.OpenWindow();
            gameResults.SetResults("You lose");
        }
    }

}
