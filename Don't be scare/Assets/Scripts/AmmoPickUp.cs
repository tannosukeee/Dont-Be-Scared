using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour
{
        public GameObject AmmoPanel;
        public GameObject AmmoBox;
        private void OnTriggerEnter(Collider other)
        {
                AmmoBox.SetActive(false);
                AmmoPanel.SetActive(true);
                GlobalAmmo.AmmoCount += 7;
        }
}
