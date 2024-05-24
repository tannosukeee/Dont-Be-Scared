using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpPistol : MonoBehaviour
{
        public float theDistance;
        public GameObject ActionDisplay;
        public GameObject ActionText;
        public GameObject FakePistol;
        public GameObject RealPistol;
        public GameObject GuideArrow;

        // Update is called once per frame
        void Update()
        {
                theDistance = PlayerCasting.DistanceFromTarget;
        }
        private void OnMouseOver()
        {
                if (theDistance < 3)
                {
                        ActionText.GetComponent<Text>().text = "Pick up the gun!";
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
                                FakePistol.SetActive(false);
                                RealPistol.SetActive(true);
                                GuideArrow.SetActive(false);
                        }
                }
        }

        private void OnMouseExit()
        {
                ActionDisplay.SetActive(false);
                ActionText.SetActive(false);
        }
}
