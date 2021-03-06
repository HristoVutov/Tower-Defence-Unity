﻿using UnityEngine;
using System.Collections;

public class Projectile : MonoBehaviour {

    //TODO: Better code...
    private Transform target;
    private float arrowSpeed;

    public float damage;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {       
        //TODO: Fix arrow LookAt();
        var lookDir = target.position - transform.position;
        lookDir.y = 0f;
        gameObject.transform.LookAt(lookDir);
        transform.position = Vector3.MoveTowards(transform.position, target.position, arrowSpeed);
    }

    public void ShootProjectile(Transform target, float arrowSpeed, float damage)
    {
        //Give Target
        this.target = target;
        this.arrowSpeed = arrowSpeed;
        this.damage = damage;

        //Add current gameObject to target list of projectiles following it
        target.GetComponent<Unit>().projectilesList.Add(gameObject);
    }
}
