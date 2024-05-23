
using System.Collections.Generic;
using UnityEngine;

public class DiologSilector : MonoBehaviour
{
    [SerializeField] public List<GameObject> Texts;
    [SerializeField] public GameObject Silector;
    [SerializeField] public GameObject PushE;
    private int indx = 0;

    private void Awake()
    {
        Silector.SetActive(false);
        PushE.SetActive(false); 
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log(indx);
        pupshodit hohpup = collision.GetComponent<pupshodit>();
        if (hohpup != null && indx == 0 && Input.GetKeyDown(KeyCode.E))
        {
            Silector.SetActive(true);
            Texts[indx].SetActive(true);
            indx++;                
        }  
        if (hohpup != null && indx == 2 && Input.GetKeyDown(KeyCode.E))
        {
            Silector.SetActive(true);
            Texts[indx].SetActive(true);           
        }
    }
    private void Update()
    {
        if (indx == 1 && Input.GetKeyDown(KeyCode.LeftShift))
        {
            Silector.SetActive(true);
            Texts[indx].SetActive(true);
            indx++;
        }       
    }
    
}
