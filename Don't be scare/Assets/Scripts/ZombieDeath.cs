using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieDeath : MonoBehaviour
{
        public int ZombieHealth = 25;
        public GameObject zombie;

        public void DamageZombie(int damage)
        {
                ZombieHealth -= damage;
        }

    void Update()
    {
                if (ZombieHealth <= 0)
                {
                        zombie.GetComponent<Animation>().Stop("Z_Attack");
                        zombie.GetComponent<Animation>().Play("Z_FallingBack");
                        StartCoroutine(HideTime());
                }
        
    }

        IEnumerator HideTime()
        {
                yield return new WaitForSeconds(2f);
                zombie.SetActive(false);
        }
}
