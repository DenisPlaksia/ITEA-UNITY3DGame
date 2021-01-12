using UnityEngine;

public class TowerMoveComponent : MonoBehaviour
{
    [SerializeField] private VariableJoystick _towerMovementJoystick = null;

    private Vector3 _direction;

    public float Speed { get; private set; }
    private void Start()
    {
        Speed = GetComponent<Tower>()._towerTankData.GetSpeed();
    }
    private void Update()
    {
        _direction = new Vector3(0f, _towerMovementJoystick.Direction.x + _towerMovementJoystick.Direction.y, 0f);
        Rotation(_direction);
    }
    private void Rotation(Vector3 direction)
    {
        transform.Rotate(direction * Speed);
    }
}
