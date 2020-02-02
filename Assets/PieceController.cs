using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    public DebugController d;
    // Start is called before the first frame update
    void Start()
    {
        d.Clear();
        d.Debug("Piece Controller started");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
