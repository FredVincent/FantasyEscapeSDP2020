using UnityEngine;

public class MainMenu : MonoBehaviour
{
   public void QuitGame ()
    {
        Debug.Log("Game has quit :D"); // To show us developers the game has quit.
        Application.Quit(); // this will exit the program when program is built.
    }
}
