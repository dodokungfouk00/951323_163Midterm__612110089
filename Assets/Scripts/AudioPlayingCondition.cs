using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayingCondition : MonoBehaviour
{
    [SerializeField] AudioClip shoot;
    [SerializeField] AudioClip impact;
    [SerializeField] AudioClip impact_wall;
    [SerializeField] AudioSource audioSource;

    void Awake()
    {
        audioSource.PlayOneShot(shoot);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullseyes")
        {
            audioSource.PlayOneShot(impact_wall);
        }
        else{audioSource.PlayOneShot(impact);}
        if (other.gameObject.name == "Ground")
        {
            Destroy(this.gameObject.GetComponent<Collider>(), 3);
        }
    }
}
