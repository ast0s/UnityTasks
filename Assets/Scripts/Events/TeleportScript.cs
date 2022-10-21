using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour
{
    void OnEnable()
    {
        EventManager.OnClicked += Teleport;
    }


    void OnDisable()
    {
        EventManager.OnClicked -= Teleport;
    }


    void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(-2.5f - 3.0f, -2.5f + 3.0f);
        transform.position = pos;
    }
}
