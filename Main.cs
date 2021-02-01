using UnityEngine;

public class Main : MonoBehaviour
{
    RoR2.CharacterMaster Player;
    private void Start()
    {
        //Do stuff here once for initialization
        Player = FindObjectOfType<RoR2.CharacterMaster>();
    }
    private void Update()
    {
        //Do stuff here on every tick
        if (Input.GetKeyDown(KeyCode.G))
        {
            Player.GiveMoney(1);
        }

        if (Input.GetKeyDown(KeyCode.Delete))
        {
            riskofrainfunsies.Loader.Unload();
        }
    }
    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 100, 20), "fork");
    }
}





