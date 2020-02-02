using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    // public DebugController d;
    GameObject piece1;
    GameObject piece2;

    GameObject localPiece1;
    GameObject localPiece2;
    // Start is called before the first frame update
    void Start()
    {
       // d.Clear();
       // d.Debug("Piece Controller started");
        // get 
        // piece1 = GameObject.Find("enemy");
        
       // localPiece1 = transform.Find("a").gameObject;
        // localPiece2 = transform.Find("b").gameObject;
        //
        Debug.Log( name.Substring(name.Length - 1));
        
    }

    // Update is called once per frame
    void Update()
    {
        return;
        if (Collition(piece1))
        {
            localPiece1.SetActive(true);
            piece1.SetActive(false);
        }
    }

    bool Collition(GameObject other)
    {
        Transform t1 = other.GetComponent<Transform>();
        // Transform t2 = GetComponent<Transform>();
        float dist = Vector3.Distance(t1.position, transform.position);
        print("Distance to other: " + dist);
        return false;
    }
            // Transform t1 = 
}
