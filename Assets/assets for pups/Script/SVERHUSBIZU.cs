using UnityEngine;

public class SVERHUSBIZU : MonoBehaviour
{
    public Transform PUPS;
    public GameObject SEfL;
    public Transform self;
    SortingLayer thisl;
    void Start()
    {
        
    }


    void Update()
    {
        if (PUPS.position.y <= self.position.y )
        {
            SEfL.layer -= 2;
        }
        else
        {
            SEfL.layer -= 2;
        }
    }
}
