using UnityEngine;

public class playerco : MonoBehaviour
{
   void OnCollisionEnter (Collision collisionInfo){
	if (collisionInfo.collider.name == "Friend 3-Megan"){
	
		Debug.Log(collisionInfo.collider.name);
		}	
	}

}
