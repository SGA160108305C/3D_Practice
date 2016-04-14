using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
    [Range(5,10)]
    public float speed = 7.0f;

	// Use this for initialization
	void Start ()
    {
        //Debug.Log("스타트");
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Debug.Log("업데이트");
        //if( Input.GetKey(KeyCode.Space) )
        //{
        //    Debug.Log("Space!!!!!!!!!!");
        //}

        //if( Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("Space down");
        //}

        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    Debug.Log("Space up");
        //}

        if( Input.GetButtonDown("Jump") )
        {
            Debug.Log("Jump");
            //this.transform.position = new Vector3(
            //    this.transform.position.x,
            //    this.transform.position.y + 1.0f,
            //    this.transform.position.z);
            this.transform.Translate(0, 1, 0);

            //this.transform.forward;
            //this.transform.right;
            //this.transform.up;
        }

        if( Input.GetButtonDown("Submit"))
        {
            Debug.Log("Submit");
            //this.transform.rotation = Quaternion.Euler(0, 45.0f, 0);
            this.transform.Rotate(0,30,0);
        }

        float h = Input.GetAxis("Horizontal");  //`-1 ~ 1
        //Debug.Log(h);
        this.transform.Translate(h*Time.deltaTime*speed, 0, 0);

    }
}
