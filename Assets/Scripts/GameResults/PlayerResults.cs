using UnityEngine;

public class PlayerResults : MonoBehaviour
{
    public static int kill;

    private void Start()
    {
        ResetData();
    }
    public void ResetData()
    {
        kill = 0;
    }
     
}
