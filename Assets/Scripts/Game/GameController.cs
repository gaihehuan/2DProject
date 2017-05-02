using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
    public GameObject Car;
	// Use this for initialization
	void Start ()
    {
        Car.gameObject.AddComponent<PlayerControl>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
