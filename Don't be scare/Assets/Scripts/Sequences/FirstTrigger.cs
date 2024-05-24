using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstTrigger : MonoBehaviour
{
        public GameObject PlayerScripts;
        public GameObject TextBox;
        public GameObject GuideArrow;
        private void OnTriggerEnter(Collider other)
        {
                PlayerScripts.GetComponent<FirstPersonMovement>().enabled = false;
                StartCoroutine(ScenePlayer());
        }

        IEnumerator ScenePlayer()
        {
                TextBox.GetComponent<Text>().text = "Look at the arrow!";
                yield return new WaitForSeconds(2f);
                TextBox.GetComponent<Text>().text = "";
                PlayerScripts.GetComponent<FirstPersonMovement>().enabled = true;
                GuideArrow.SetActive(true);
        }
}
