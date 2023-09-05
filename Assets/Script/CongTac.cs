using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CongTac : MonoBehaviour
{
    [SerializeField] GameObject[] _target;
    bool _isActive = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.tag == "Player" && _isActive == false)
        {
            Debug.Log("cham player");
            gameObject.transform.DOShakeScale(1f);
            gameObject.GetComponent<SpriteRenderer>().DOColor(Color.green, 1f).SetEase(Ease.OutQuad).OnComplete(() =>
            {

                var sequence = DOTween.Sequence();
                foreach (var shap in _target)
                {
                    sequence.Append(shap.GetComponent<SpriteRenderer>().DOFade(1f, 0.2f));
                    // sequence.Append(shap.gameObject.GanmeGetComponent<BoxCollider2D>().isTrigger = false);
                    sequence.Append(shap.transform.DOMoveY(-5.5f, 1f)).SetEase(Ease.InOutBounce);
                }

            });

            _isActive = true;
        }
    }
}
