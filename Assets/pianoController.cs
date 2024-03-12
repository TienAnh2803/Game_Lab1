using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class pianoController : MonoBehaviour
{
    AudioSource _do, _re, _mi, _fa, _son, _la, _si, _do1;
    


    // Start is called before the first frame update
    void Start()
        
    {
        Debug.Log("Bat dau");
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();

        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();

        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();

        _fa = GameObject.FindWithTag("fa").GetComponent<AudioSource>();

        _son= GameObject.FindWithTag("son").GetComponent<AudioSource>();

        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();

        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();

        _do1 = GameObject.FindWithTag("do1").GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            _do.Play();
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            _re.Play();
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            _mi.Play();
        }
        if(Input.GetKeyUp(KeyCode.R))
        {
            _fa.Play();
        }
        if(Input.GetKeyUp(KeyCode.T))
        {
            _son.Play();
        }
        if(Input.GetKeyUp(KeyCode.Y))
        {
            _la.Play();
        }
        if(Input.GetKeyUp(KeyCode.U))
        {
            _si.Play();
        }
        if(Input.GetKeyUp(KeyCode.I))
        {
            _do1.Play();
        }
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
      
}
