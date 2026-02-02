using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DOTweenExample : MonoBehaviour
{
    [SerializeField] CanvasGroup canvasGroup;

    [SerializeField] AnimationCurve curve;

    // Start is called before the first frame update
    void Start()
    {
        //transform.DOLocalMove(new Vector3(200, 200), 1f).SetEase(Ease.InOutBounce).SetLoops(-1, LoopType.Incremental);

        //transform.DORotate(new Vector3(0f, 0f, 360f), 1f, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart).SetEase(Ease.Linear);

        //transform.DOLocalMove(new Vector3(200, 200), 1f).SetEase(Ease.InOutBounce).OnComplete(DoSomething);

        //var sequence = DOTween.Sequence();

        //sequence.Append(transform.DOLocalMove(new Vector3(200, 200), 1f));
        //sequence.Append(transform.DORotate(new Vector3(0f, 0f, 40f), 1f));

        //var tween = DOTween.To(() => canvasGroup.alpha, x => canvasGroup.alpha = x, 0, 1f);


        transform.DOLocalMove(new Vector3(200, 200), 1f).SetEase(curve);

        curve.Evaluate(0.3f);
    }


}