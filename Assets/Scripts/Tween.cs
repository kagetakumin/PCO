using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Tween : MonoBehaviour
{
    public Tweener tweener;
    public AnimationCurve curve;
    public Vector3 toMove;
    public Vector3 toRotate;
    public Vector3 toScale;

    private Sequence sequence;

    public void Play()
    {
        tweener.Play();
    }
}
