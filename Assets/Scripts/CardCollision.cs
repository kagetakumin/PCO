using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardCollision : MonoBehaviour
{
    Vector3 holdPosition;

    public bool isTransportable = true;

    private bool isFocus = false;
    public bool IsFocus
    {
        get { return isFocus; }
        private set { isFocus = value; }
    }

    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.tag != TagName.Cursor) return;

        isFocus = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag != TagName.Cursor) return;

        isFocus = false;
    }
}
