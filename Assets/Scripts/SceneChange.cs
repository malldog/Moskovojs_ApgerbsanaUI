using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{

	public void UzSakumu()
    {
        SceneManager.LoadScene("Sakums", LoadSceneMode.Single);
    }
    public void Apturet()
    {
        Application.Quit();
    }
    public void UzMain()
    {
        SceneManager.LoadScene("Main", LoadSceneMode.Single);
    }
    public void UzInfo()
    {
        SceneManager.LoadScene("Info", LoadSceneMode.Single);
    }
    public void UzGame()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}

