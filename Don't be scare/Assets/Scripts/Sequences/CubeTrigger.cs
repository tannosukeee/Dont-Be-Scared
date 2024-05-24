using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeTrigger : MonoBehaviour
{
        public AudioSource doorBang;
        public AudioSource zombieScream;
        public GameObject theZombie;
        public GameObject theDoor;
        public GameObject torch;

        private void OnTriggerEnter()
        {
                GetComponent<BoxCollider>().enabled = false;
                theDoor.GetComponent<Animation>().Play("DoorOpen02");

                doorBang.Play();
                zombieScream.Play();

                StartCoroutine(Tstart());
        }

        IEnumerator Tstart()
        {
                yield return new WaitForSeconds(1f);
                torch.SetActive(false);
                theZombie.SetActive(false);
                yield return new WaitForSeconds(10f);
                torch.SetActive(true);
        }
}
