using UnityEngine;
using System.Collections;

public class Tower : MonoBehaviour {
    //TODO: Create abstract

    public GameObject arrowPrefab;
    [Range(0.1f, 5)]
    public float FireRate = 1.0f;
    [Range(0.01f, 0.05f)]
    public float ArrowSpeed = 0.3f;
    [Range(1, 100)]
    public float TowerDamage = 15;

    private float NextFire;

    // Use this for initialization
    void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void ShootEnemy(GameObject enemy)
    {
        if (Time.time > NextFire)
        {
            NextFire = Time.time + FireRate;

            var arrow = Instantiate(arrowPrefab, gameObject.transform.position, Quaternion.identity) as GameObject;
            arrow.transform.SetParent(gameObject.transform);
            arrow.GetComponent<Projectile>().ShootProjectile(enemy.transform, ArrowSpeed, TowerDamage);

        }
    }
}
