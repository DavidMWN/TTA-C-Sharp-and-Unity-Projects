using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_start : MonoBehaviour
{
    public bool zone = true;
    [SerializeField] GameObject _wallStart;

    private void Update()
    {
        if (zone == false)
        {
            _wallStart.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            zone = false;
        }
    }
}
