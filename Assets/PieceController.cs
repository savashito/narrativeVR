﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PieceController : MonoBehaviour
{
    // public DebugController d;
    GameObject piece1;
    GameObject piece2;

    GameObject localPiece1;
    GameObject localPiece2;

    public bool isPicture;
    narrativeGameManager nGameManager;
    int peacesGather = 0;
    // Start is called before the first frame update
    void Start()
    {
        // d.Clear();
        // d.Debug("Piece Controller started");
        // get 
        // piece1 = GameObject.Find("enemy");
        // Debug.Log("start111 " + transform.Find("a"));
        localPiece1 = transform.Find("a").gameObject;
        // Debug.Log("start111 " + localPiece1);
        localPiece2 = transform.Find("b").gameObject;
        nGameManager = GameObject.Find("NarrativeGameManager").GetComponent<narrativeGameManager>();
        //
        piece1 = GameObject.Find(GetPiezeName(name, 0));
        piece2 = GameObject.Find(GetPiezeName(name, 1));
        //Debug.Log(name) ;
        //Debug.Log(GetPiezeName(name,0));
        //Debug.Log(GetPiezeName(name,1));
        //Debug.Log("jojojo");
        //// GetPiezeName("1",1);
        //Debug.Log( name.Substring(name.Length - 1));

    }
    char[] GetOtherChar(char c)
    {
        switch (c)
        {
            case '1':
                char[] regredo = { '2', '3' };
                return regredo;
            case '2':
                char[] regredo1 = { '1', '3' };
                return regredo1;
            default:
                char[] regredo2 = { '1', '2'};
                return regredo2;
        }
    }

    string GetPiezeName(string n1, int index)
    {
        int n = n1.Length;
        char cLastCharacter = n1[n - 1];
        char a = GetOtherChar(cLastCharacter)[index];
        // char b = GetOtherChar(cLastCharacter)[1];
        return name.Substring(0, name.Length - 1) + a;
        // n1.Length;
        // return n1;
        // name.Last();
        // char cLastCharacter = n1[n1.Lenght - 1];
       // string sNum = name.Substring(name.Length - 1)
            /*
       switch (name)
        {
            case "1":
                break;
            default:
                break;
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (piece1.activeInHierarchy && Collition(piece1))
        {
            localPiece1.SetActive(true);
            piece1.GetComponentInParent<Transform>().gameObject.SetActive(false);
            int otherPeaces = piece1.GetComponent<PieceController>().peacesGather;
            Debug.Log("other " + otherPeaces);
            peacesGather++;
            Debug.Log("their " + peacesGather);
            if (otherPeaces + peacesGather == 2)
            {
                localPiece2.SetActive(true);
                if (isPicture)
                    nGameManager.OnPictureComplete();
                else
                    nGameManager.OnDrumPutTogether();
            }
            // check if piece has selected other thing

            // piece1.SetActive(false);

            //if (!piece2.activeInHierarchy) {
            //    // nGameManager.OnPictureComplete();
            //}
        }
        
        if (piece1.activeInHierarchy && Collition(piece2))
        {
            localPiece2.SetActive(true);
            piece2.GetComponentInParent<Transform>().gameObject.SetActive(false);
            int otherPeaces = piece2.GetComponent<PieceController>().peacesGather;
            Debug.Log("other " + otherPeaces);
            peacesGather++;
            Debug.Log("their " + peacesGather);
            if (otherPeaces + peacesGather == 2)
            {
                localPiece1.SetActive(true);
                if (isPicture)
                    nGameManager.OnPictureComplete();
                else
                    nGameManager.OnDrumPutTogether();
            }
            /*
            piece2.GetComponentInParent<Transform>().gameObject.SetActive(false);
            // piece2.SetActive(false);
            if (!piece1.activeInHierarchy)
            {
                // nGameManager.OnPictureComplete();
            }
            */
        }
    }

    bool Collition(GameObject other)
    {
        Debug.Log("Collition " + other.name);
        Transform t1 = other.GetComponentInParent<Transform>();
        // Transform t1 = other.GetComponent<Transform>();
        Transform t2 = GetComponentInParent<Transform>();

        float dist = Vector3.Distance(t1.position, t2.position);
        // print("Distance to other: " + dist + "\t" + t1.position + "\t" + transform.position);
        return dist < 0.05;
        // return dist < 0.04;
    }
    // Transform t1 = 

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "pictureHolder")
        {
            this.gameObject.SetActive(false);
        }
    }
}
