using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class pickupkey : MonoBehaviour
{
	public float radialTimer = 0f; 
	public Transform radialProgress; 
	public Opendoor sethim; 
	void Start(){
		radialProgress.GetComponent<Image>().fillAmount = radialTimer; 
	} 

	void Update(){
		radialTimer += Time.deltaTime; 
		radialProgress.GetComponent<Image>().fillAmount = radialTimer / 2; 
 		if(radialTimer >= 2f){ 
			sethim.hasKey(); 
			Destroy(gameObject); 
		} 
	} 
	
	public void Reset(){
		radialTimer = 0f; 
		radialProgress.GetComponent<Image>().fillAmount = radialTimer; 
	}
}
