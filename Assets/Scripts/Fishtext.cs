using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fishtext : MonoBehaviour {
	// Update is called once per frame
        public void Update()
        {
            Camera camera = Camera.main;
            transform.LookAt(transform.position + camera.transform.rotation * Vector3.forward, camera.transform.rotation * Vector3.up);
        }
}
