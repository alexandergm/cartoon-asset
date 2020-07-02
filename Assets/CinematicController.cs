using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicController : MonoBehaviour
{
    private StarsController _StarsController;

    private void Start()
    {
        _StarsController = GetComponent<StarsController>();
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
