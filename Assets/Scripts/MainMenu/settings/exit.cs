using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour
{
    public GameObject main_menu;
    public GameObject settings;
    public void Button()
    {
        main_menu.SetActive(true);
        settings.SetActive(false);
    }
}
