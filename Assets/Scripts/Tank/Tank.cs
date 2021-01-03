using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tank : MonoBehaviour
{
    [SerializeField] private Tower _tower;
    [SerializeField] private Caterpillar _caterpillar;
   
    public Tower Tower { get => _tower; }
    public Caterpillar Caterpillar { get => _caterpillar; }
}
