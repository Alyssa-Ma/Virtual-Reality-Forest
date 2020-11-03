using UnityEngine;
using System.Collections;

public class Flash_Light : MonoBehaviour 
{
	public KeyCode flashlightToggleKey = KeyCode.F;	
	public AudioClip toggleSound;
	public float batteryLifeSeconds = 60f;
	public float bat_life = 0;
	
	
	public float maxIntensity= 10f;
	
	public float batteryLife;
	
	private bool isActive;
	
	private AudioSource myAudioSource;
	private Light myLight;
	
	void Start()
	{
		myLight = GetComponent<Light>();
		batteryLife = myLight.intensity;
		
	}
	
	void Update()
	{
		
		
		myLight.enabled = true;
		myLight.intensity -= batteryLife / batteryLifeSeconds * Time.deltaTime;
		bat_life = myLight.intensity*10;
		
		
		
		
	}
	
	public void AddBatteryLife(float _batteryPower)
	{
		myLight.intensity += _batteryPower;
		if(myLight.intensity > maxIntensity);
			myLight.intensity = maxIntensity;
	}

	
	  void OnGUI()
    {
        GUI.Box(new Rect(0, Screen.height / 1.21f, Screen.width / 6.16f, Screen.height / 19.58f),bat_life.ToString());
    }



}