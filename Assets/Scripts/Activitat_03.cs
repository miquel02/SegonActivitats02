using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activitat_03 : MonoBehaviour
{
    //We set the board limits
    private float boardLimits = 4.7f;
    //We set a jump distance
    private float jumpDistance = 2.35f;

    //Next position
    private Vector3 nextPos;

    void Update()
    {
        //We jump to the next positions uning the arrows
        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y != boardLimits)
        {
            nextPos = new Vector3(transform.position.x, transform.position.y + jumpDistance, transform.position.z);
            transform.position = nextPos;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y != -boardLimits)
        {
            nextPos = new Vector3(transform.position.x, transform.position.y - jumpDistance, transform.position.z);
            transform.position = nextPos;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x != boardLimits)
        {
            nextPos = new Vector3(transform.position.x + jumpDistance, transform.position.y, transform.position.z);
            transform.position = nextPos;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x != -boardLimits)
        {
            nextPos = new Vector3(transform.position.x - jumpDistance, transform.position.y, transform.position.z);
            transform.position = nextPos;
        }
    }
}