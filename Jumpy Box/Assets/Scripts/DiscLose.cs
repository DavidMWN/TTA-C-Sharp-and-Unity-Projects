using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscLose : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            SceneSwitcher.SwitchScene(false);
        }
    }
}
