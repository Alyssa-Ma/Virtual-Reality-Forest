using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Opendoor : MonoBehaviour
{
	public Animator dooranimator; 
        public bool haskey; 

	public void hasKey(){
		haskey = true; 
	}

        private void OnTriggerEnter(Collider other){
	     if(haskey){
             	dooranimator.SetBool("isOpen_Obj_1", true); 
	     }
        } 
        private void OnTriggerExit(Collider other){
             dooranimator.SetBool("isOpen_Obj_1", false); 
        }
}
