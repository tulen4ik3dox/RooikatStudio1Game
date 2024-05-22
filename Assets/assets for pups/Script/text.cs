using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class text : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] string[] lines;
    [SerializeField] float Textspeed;
    public GameObject textpole;
    private int Index;
    public GameObject code;
    public GameObject pups;
    void Start()
    {
        _text.text = string.Empty;
        startDiolog();
        pups.GetComponent<pupshodit>().enabled = false;
        pups.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        pups.GetComponent<Animator>().StopPlayback();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            if (_text.text == lines[Index]) 
            {
                IsNextLine();
            }
            else
            {
                StopAllCoroutines();
                _text.text = lines[Index];
            }
        }
    }
    void startDiolog()
    { 
       Index = 0;
        StartCoroutine(TypeLine());
    }
    IEnumerator TypeLine()
    {
        foreach (char c in lines[Index].ToCharArray())
        {
            _text.text += c;
            yield return new WaitForSeconds(Textspeed);
        }
    }
    void IsNextLine()
    {
        if (Index < lines.Length - 1) 
        {
            Index++;
            _text.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            pups.GetComponent<pupshodit>().enabled = true;
            textpole.SetActive(false);
            gameObject.SetActive(false);
        }
    }
}
