using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {
	
	ParticleSystem.Particle[] particles = new ParticleSystem.Particle[10000];
	int length;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		length = this.particleSystem.GetParticles(particles);
		
		for (int i = 0; i < length; i++) {
			
			particles[i].color = new Color (Random.value, Random.value, Random.value, 1);
			
		}
		
		this.particleSystem.SetParticles(particles, length);
	
	}
}
