using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlMover : MonoBehaviour {
    private Animator anim;
    public float rotationSpeed = 90f;
    public float runSpeed = 1f;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        var hor = Input.GetAxis("Horizontal");
        var ver = Input.GetAxis("Vertical");

        transform.Rotate(Vector3.up * hor * rotationSpeed * Time.deltaTime);

        anim.SetFloat("speed", runSpeed * ver, 0.2f, Time.deltaTime);
	}
}
