using UnityEngine;
using System.Collections;

public class RandomizeParticleSystem: MonoBehaviour {
	//public float emissionRateVariance = 0.05f;
	//public float emissionRateVarianceOffset = 0.0f;
	public float simulationVariance = 1.0f;

	private ParticleSystem ps;
	//private float pser;

	void Start() {
		if ((ps = (ParticleSystem)gameObject.GetComponent("ParticleSystem")) != null) {
			//ps.emissionRate = (pser = ps.emissionRate) - (Random.value * 1.0f - emissionRateVarianceOffset) * ps.emissionRate * emissionRateVariance;
			ps.Simulate(ps.duration * Random.value * simulationVariance);
			ps.Play();
		}
	}

	//void FixedUpdate() {
	//	//if (ps != null) ps.emissionRate = pser - (Random.value * 1.0f - emissionRateVarianceOffset) * ps.emissionRate * emissionRateVariance;
	//}
}
