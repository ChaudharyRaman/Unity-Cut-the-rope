using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RopeCutter : MonoBehaviour
{
   private void Update() {
       if(Input.GetMouseButton(0)){
         RaycastHit2D hit=Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);// ray is not goind anywhere
         // it is colliding only where our mouse is...
         //RaycastHit2D hit=Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition),Vector2.zero);// ray is not goind anywhere
           
         if(hit.collider!=null){
             if(hit.collider.tag=="link"){
                 
                 Destroy(hit.collider.gameObject);
                 Destroy(hit.transform.parent.gameObject,2f);
             }
         }


       }
   }
}
