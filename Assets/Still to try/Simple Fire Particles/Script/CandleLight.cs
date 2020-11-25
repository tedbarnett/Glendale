using UnityEngine;
using System.Collections;


public class CandleLight : MonoBehaviour {
	public float amount = 1;
	public int flickerSpeed = 10;
	float lightoriginal;
	// Use this for initialization
	void Start () {
		lightoriginal = GetComponent<Light>().intensity;
	}
	
	// Update is called once per frame
	void Update () {
		if(Random.Range(1,flickerSpeed) == 1){
			GetComponent<Light>().intensity = Random.Range(lightoriginal-amount,lightoriginal+amount);
		}
	}
}
