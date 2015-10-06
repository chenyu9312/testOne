using UnityEngine;
using System.Collections;

public class RandomRotator : MonoBehaviour {
    public Rigidbody go;
    public float tumble;
	// Use this for initialization
	void Start () {
        go = GetComponent<Rigidbody>();
        go.angularVelocity = Random.insideUnitSphere * tumble;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
