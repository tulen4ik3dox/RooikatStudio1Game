using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class settings1 : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject settings;
    public void Button()
    {
        main_menu.SetActive(false);
        settings.SetActive(true);
    }

}
