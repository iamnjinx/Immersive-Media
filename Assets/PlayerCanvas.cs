using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCanvas : MonoBehaviour
{
    private void Update()
    {
        transform.position = Camera.main.transform.position;
    }
}
