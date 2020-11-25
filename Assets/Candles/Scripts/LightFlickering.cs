using UnityEngine;
using System.Collections;

public class LightFlickering: MonoBehaviour {
	
	public bool useCurrentLightIntensityInsteadOfBias = true;
	public float bias = 1.0f;
	public float flameFrequency1 = 0.12f;
	public float flameAmplitude1 = 0.09f;
	public float flameFrequency2 = 12.0f;
	public float flameAmplitude2 = 0.009f;
	
	void Start() {
		if (useCurrentLightIntensityInsteadOfBias) bias = gameObject.GetComponent<Light>().intensity;
	}
	void Update() {
		float newIntensity = bias + Mathf.Sin(Time.realtimeSinceStartup * flameFrequency1 * 2.0f * Mathf.PI) * flameAmplitude1 + Mathf.Sin(Time.realtimeSinceStartup * flameFrequency2 * 2.0f * Mathf.PI) * flameAmplitude2;
		gameObject.GetComponent<Light>().intensity = newIntensity;
	}
}
