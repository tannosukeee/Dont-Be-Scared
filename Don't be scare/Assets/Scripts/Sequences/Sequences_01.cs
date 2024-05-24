using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sequences_01 : MonoBehaviour
{
        // Start is called before the first frame update

        public GameObject playerScripts;
        public GameObject FadeScreenIn;
        public GameObject TextBox;

    void Start()
    {
                playerScripts.GetComponent<FirstPersonMovement>().enabled = false;
                StartCoroutine(ScenePlayer());
        
    }

    IEnumerator ScenePlayer()
    {
                yield return new WaitForSeconds(1.5f);
                FadeScreenIn.SetActive(false);
                TextBox.GetComponent<Text>().text = "I need to get out of here!";
                yield return new WaitForSeconds(2f);
                TextBox.GetComponent<Text>().text = "";
                playerScripts.GetComponent<FirstPersonMovement>().enabled = true;
    }

    // Update is called once per frame
}
