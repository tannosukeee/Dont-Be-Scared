using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirePistol : MonoBehaviour
{
        // Start is called before the first frame update
        public GameObject theGun;
        public GameObject bulletFlash;
        public AudioSource GunFire;
        public bool isFiring = false;
        public float targetDistance;
        public int damageAmount = 5;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && GlobalAmmo.AmmoCount >= 1)
                {
                        if (isFiring = true)
                        {
                                GlobalAmmo.AmmoCount -= 1;
                                StartCoroutine(firePistol());
                        }
                }
    }

        IEnumerator firePistol()
        {
                RaycastHit hit;
                isFiring = true;
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit))
                {
                        targetDistance = hit.distance;
                        hit.transform.SendMessage("DamageZombie", damageAmount, SendMessageOptions.DontRequireReceiver);
                }
                theGun.GetComponent<Animation>().Play("PistolShoot");
                bulletFlash.SetActive(true);
                bulletFlash.GetComponent<Animation>().Play("BulletFlash");
                GunFire.Play();
                yield return new WaitForSeconds(0.5f);
                isFiring = false;
        }
}
