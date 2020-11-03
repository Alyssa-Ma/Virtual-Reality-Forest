using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour 
{
	public float batteryPower;
	public void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("GameController"))
		{
		GameObject.FindGameObjectWithTag("Flash_Light").GetComponent<Flash_Light>().AddBatteryLife(batteryPower);
		Destroy(gameObject);
		}
	}
	
	
}