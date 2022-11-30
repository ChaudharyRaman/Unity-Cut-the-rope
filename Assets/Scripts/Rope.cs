using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public Rigidbody2D hook;
    public GameObject linkPrefab;
    public int links=7;
    public Weight weight;
    private void Start() {
        GenerateRope();
    }
    void GenerateRope(){
        Rigidbody2D previousRB = hook;

        for (int i=0;i<links;i++){
           GameObject link= Instantiate(linkPrefab,transform);// this will make linkPrefab a child of transform ie where script is attached....
            HingeJoint2D joint=link.GetComponent<HingeJoint2D>();
            joint.connectedBody = previousRB;
            
            if(i<links-1){
                previousRB=link.GetComponent<Rigidbody2D>();

            }else{
                weight.ConnectRopeEnd(link.GetComponent<Rigidbody2D>());
            }
        }
    }
}
