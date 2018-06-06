using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{

    public GameObject obj;
    public float MoveSpeed = 0.2f;

    public void MoveLeft(GameObject obj)
    {
        Vector3 PlayerPos = new Vector3(obj.transform.position.x, obj.transform.position.y, 0f);

        PlayerPos.x -= MoveSpeed;
        obj.transform.position = PlayerPos;
        Debug.Log("pressed");
    }

}