using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour
{
    [SerializeField] public GameObject Panel;
        
    public void Playbutton()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitButtton()
    {
        Application.Quit();
    }

    public void MenuButton()
    {
        SceneManager.LoadScene("GameMenu");
    }

    public void instructionbutton()
    {
        Panel.SetActive(true);
    }

    public void instructionButtonExit()
    {
        Panel.SetActive(false);
    }

}
