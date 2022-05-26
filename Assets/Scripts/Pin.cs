using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
   
    [SerializeField] GameObject _pinPref;


    private void Update()
    {
        if (Input.GetButtonDown("Fire1")) 
        {
            SpawnPin();
        }
    }

    public void SpawnPin()
    {
        Instantiate(_pinPref, transform.position, transform.rotation);
    }


}
