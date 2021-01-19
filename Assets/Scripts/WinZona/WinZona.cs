using UnityEngine;

public class WinZona : MonoBehaviour
{

    [SerializeField] private LayerMask _whatIsEnemy;
    [SerializeField] private PVPGameManger pVPGame;
    [SerializeField] private string message;
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == _whatIsEnemy)
        {
            pVPGame.LoseGame(message);
        }
    }
}
