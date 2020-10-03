using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField] KeyCode ShootKey, AddForceKey, RemoveForceKey;
    [SerializeField] GameObject Bullets;
    [SerializeField] float Delay = .5f;
    float NextChange;
    float nextShot;
    [SerializeField] [Range(1, 30)] float force = 10;
    AudioPlayingCondition audioPlayingCondition;

    private void Awake() {
        audioPlayingCondition = this.GetComponent<AudioPlayingCondition>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(ShootKey))
        {
            if (Time.time > nextShot)
            {
                GameObject bullet = Instantiate(Bullets, new Vector3(transform.position.x,transform.position.y,transform.position.z+1), Quaternion.identity);
                Rigidbody rb = bullet.GetComponent<Rigidbody>();
                rb.AddForce(new Vector3(0, .33f, 1) * force, ForceMode.Impulse);
                if (bullet != null)
                {
                    Destroy(bullet, 10);
                }
                nextShot = Time.time + Delay;
            }
        }
        if (Time.time > NextChange)
        {
            if (Input.GetKey(AddForceKey))
            {
                force += 1;
            }
            else if (Input.GetKey(RemoveForceKey))
            {
                force -= 1;
            }
            NextChange = Time.time + .1f;
        }
        if (force < 1)
        {
            force = 1;
        }
        else if (force > 30)
        {
            force = 30;
        }
    }
}
