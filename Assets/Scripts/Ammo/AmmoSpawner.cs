using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _ammo;

    private void Start()
    {
        StartCoroutine(ItemSpawner());
    }

    private IEnumerator ItemSpawner()
    {
        var obj = Instantiate(_ammo, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(5f);
    }
}
