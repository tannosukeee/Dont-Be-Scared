using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorOpen : MonoBehaviour
{
        public float theDistance;
        public GameObject ActionDisplay;
        public GameObject ActionText;
        public GameObject TheDoor;
        public AudioSource sound;

    // Update is called once per frame
    void Update()
    {
                theDistance = PlayerCasting.DistanceFromTarget;
        }
        private void OnMouseOver()
        {
                if (theDistance < 3)
                {
                        ActionDisplay.SetActive(true);
                        ActionText.SetActive(true);

                }
                if (Input.GetButtonDown("Action"))
                {
                        if (theDistance < 3)
                        {
                                this.GetComponent<BoxCollider>().enabled = false;
                                ActionDisplay.SetActive(false);
                                ActionText.SetActive(false);
                                TheDoor.GetComponent<Animation>().Play("DoorOpen01");
                                sound.Play();
                        }
                }
        }

        private void OnMouseExit()
        {
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
        }
}
