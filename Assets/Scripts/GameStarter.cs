using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStarter : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private string startLevel = "demo";
    public void NewGameButton()
    {
        SceneManager.LoadScene(startLevel);
    }


}
