using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class pausescript : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject quitmenu;
    public GameObject Settingsmenu;
    public GameObject pupps;
    public GameObject soundfolder;
    private bool offpause = false;


    private void Start()
    {
        pupps.GetComponent<pupshodit>();
        pupps.GetComponent<AudioSource>();
        offpause = true;
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape) && offpause == true)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            pupps.GetComponent<pupshodit>().enabled = false;
            soundfolder.SetActive(false);
            offpause = false;
        }        
        
    }
    public void resumegame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pupps.GetComponent<pupshodit>().enabled = true;
        soundfolder.SetActive(true);
        offpause = true;
    }
    public void QuitButton()
    {
        PauseMenu.SetActive(false);
        quitmenu.SetActive(true);
        offpause = false;
    }
    public void YesButton()
    {
        Time.timeScale = 1;
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index - 1);
        offpause = false;
    }
    public void NoButton()
    {
        PauseMenu.SetActive(true);
        quitmenu.SetActive(false);
        offpause = false;
    }
    public void settingsbutton()
    {
        Settingsmenu.SetActive(true);
        PauseMenu.SetActive(false);
        offpause = false;
    }
    public void exitbutton()
    {
        Settingsmenu.SetActive(false);
        PauseMenu.SetActive(true);
        offpause = false;
    }

}
