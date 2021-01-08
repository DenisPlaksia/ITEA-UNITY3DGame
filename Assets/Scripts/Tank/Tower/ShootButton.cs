using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootButton : MonoBehaviour
{
    private Button shootButton;
    [SerializeField] private ShootComponent shootComponent;
    private void Start()
    {
        shootButton = GetComponent<Button>();
        shootButton.onClick.AddListener(Shoot);
    }

    private void Shoot()
    {
        shootComponent.Shoot();
    }
}
