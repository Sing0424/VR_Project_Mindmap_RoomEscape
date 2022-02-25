using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {

    private Animator _animator;
    private Collider other;

	// Use this for initialization
	void Start () {
        _animator = GetComponent<Animator>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _animator.SetBool("open", true);
        }
    }
    // Update is called once per frame
    void Update ()
    {
        {
            if (other.tag == "Player")
            {
                _animator.SetBool("open", true);
            }
            else
            {
                _animator.SetBool("open", false);
            }
        }

    }
}
