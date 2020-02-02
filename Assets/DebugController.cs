using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DebugController : MonoBehaviour
{
    public Text t;

    public void Debug (string s)
    {
        t.text += s + "\n";
    }
    public void Clear()
    {
        t.text = "";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
