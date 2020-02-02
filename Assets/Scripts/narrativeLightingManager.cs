using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrativeLightingManager : MonoBehaviour
{

    public GameObject light1;
    public GameObject light2;
    public GameObject light3;
    public GameObject light4;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActiveLight(int index) {
        switch (index) {
            case 1:
                light1.SetActive(true);
                break;
            case 2:
                light2.SetActive(true);
                break;
            case 3:
                light3.SetActive(true);
                break;
            case 4:
                light4.SetActive(true);
                break;
        }
    }

}
