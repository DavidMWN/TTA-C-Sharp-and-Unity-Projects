using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall_end : MonoBehaviour
{
    public bool zone = false;
    [SerializeField] GameObject _wallEnd;

    private void Update()
    {
        if (zone == true)
        {
            _wallEnd.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            zone = true;
        }
    }
}
