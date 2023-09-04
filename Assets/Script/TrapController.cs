using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour
{
    [SerializeField] Transform[] _target;
    // Start is called before the first frame update
    void Start()
    {
        //var sequence = DOTween.Sequence();
        //foreach (var shap in _target)
        //{
        //    sequence.Append(shap.DOMoveY(5f, 2f));
        //}
        for (int i = 0; i < _target.Length; i++)
        {
            _target[i].DOMoveY(5f, 2f);
            _target[i].DORotate(new Vector3(0, 0, 90), 1f);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
