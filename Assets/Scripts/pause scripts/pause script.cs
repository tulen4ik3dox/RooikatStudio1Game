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



    private void Start()
    {
        pupps.GetComponent<pupshodit>();
        pupps.GetComponent<AudioSource>();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            pupps.GetComponent<pupshodit>().enabled = false;
            soundfolder.SetActive(false);

        }
         //else if (visible == true && Input.GetKeyDown(KeyCode.Escape))
        {
            //resumegame here
        }
        
    }
    public void resumegame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        pupps.GetComponent<pupshodit>().enabled = true;
        soundfolder.SetActive(true);
    }
    public void QuitButton()
    {
        PauseMenu.SetActive(false);
        quitmenu.SetActive(true);
    }
    public void YesButton()
    {
        Time.timeScale = 1;
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index - 1);

    }
    public void NoButton()
    {
        PauseMenu.SetActive(true);
        quitmenu.SetActive(false);
    }
    public void settingsbutton()
    {
        Settingsmenu.SetActive(true);
        PauseMenu.SetActive(false);
    }
    public void exitbutton()
    {
        Settingsmenu.SetActive(false);
        PauseMenu.SetActive(true);
    }

}
