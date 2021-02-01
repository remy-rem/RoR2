using UnityEngine;

namespace riskofrainfunsies
{
    public class Loader
    {
        // Declare our GameObject
        public static GameObject Load;

        // Our Loader Method
        public static void Init()
        {
            // Create an instance of the Gameobject
            Load = new GameObject();

            // Example of adding an MonoBehaviour component to our GameObject
            Load.AddComponent<Main>();

            // Telling Unity not to destory our GameObject on level change
            Object.DontDestroyOnLoad(Load);
        }

        public static void Unload()
        {
            // Destory our GameObject
            Object.Destroy(Load);
        }
    }
}

