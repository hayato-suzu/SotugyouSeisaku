using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Tutorial : MonoBehaviour
{
    public GameObject TutorialImage;

    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        TutorialImage.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        TutorialImage.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == player.name)
        {
            //ƒ^ƒCƒgƒ‹‚É–ß‚é
            SceneManager.LoadScene("TitleScene");
        }
    }
}
