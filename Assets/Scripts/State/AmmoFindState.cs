using UnityEngine;

[CreateAssetMenu]
public class AmmoFindState : State
{

    private Transform _ammo;
    public State NonAmmmoState;
    public override void Init()
    {
        var ammos = GameObject.FindGameObjectsWithTag("Ammo");

        if(ammos.Length == 0)
        {
            unit.SetState(NonAmmmoState);
            return;
        }

        _ammo = ammos[Random.Range(0, ammos.Length)].transform;
    }
    public override void Run()
    {
        if(IsFinished)
        {
            return;
        }
        else
        {
            MoveToAmmo();
        }

    }

    public override void Stop()
    {
        IsFinished = true;
    }

    private void MoveToAmmo()
    {
        unit.MeshAgent.SetDestination(_ammo.position);
    }
}
