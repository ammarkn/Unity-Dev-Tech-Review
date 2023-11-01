using UnityEngine;

public class ExitApplication : MonoBehaviour
{
    // Code adapted from: [How to quit the game in Unity] https://gamedevbeginner.com/how-to-quit-the-game-in-unity/
    public void QuitGame() {
        #if UNITY_EDITOR
            // Stops the scene in editor
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
            // Quits the application
            Application.Quit();
    }
}
