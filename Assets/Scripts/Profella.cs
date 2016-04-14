using UnityEngine;
using System.Collections;

public class Profella : MonoBehaviour {
    public float speed = 100.0f;
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(0, 0, speed*Time.deltaTime);
	}
}
