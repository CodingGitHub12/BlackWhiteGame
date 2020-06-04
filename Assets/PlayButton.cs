using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayButton : MonoBehaviour
{
    // Start is called before the first frame update
   public void ChangeToScene(int ChangeTheScene)
    {
        SceneManager.LoadScene(ChangeTheScene);
    }
}
