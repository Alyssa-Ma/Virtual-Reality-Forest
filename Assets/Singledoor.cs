using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Singledoor : MonoBehaviour
{
	public Animator singledooranimator; 
	private void OnTriggerEnter(Collider other){
		if(other.tag == "GameController"){
			singledooranimator.SetBool("isOpen_Obj_1",true); 
		}
        } 
        private void OnTriggerExit(Collider other){
        	if(other.tag == "GameController"){
			singledooranimator.SetBool("isOpen_Obj_1",false); 
		}
        }
}
