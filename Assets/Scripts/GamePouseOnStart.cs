using UnityEngine;

public class GamePouseOnStart
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void InitGame()
    {
        Time.timeScale = 0f;
    }
}
