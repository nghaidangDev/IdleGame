using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMiner : MonoBehaviour
{
    private float moveSpeed = 5f;
    private int intialCollectParacity = 200;
    private float goldCollectPerSecond = 50f;

    public int CollectCapacity { get; set; }
    public int CurrentGold {  get; set; }
    public float CollectPerSecond { get; set; }
    public bool isTimeToCollect { get; set; }

    private void Awake()
    {
        isTimeToCollect = true;
        CurrentGold = 0;
        CollectCapacity = intialCollectParacity;
        CollectPerSecond = goldCollectPerSecond;
    }

    public void MoveMiner(Vector3 newPosition)
    {
        transform.DOMove(newPosition, 10f / moveSpeed).OnComplete((() =>
        {
            if (isTimeToCollect)
            {
                CollectGold();
            }
        })).Play();
    }

    protected virtual void CollectGold()
    {

    }

    protected virtual IEnumerator IECollect(int collectGold, float collectTime)
    {
        yield return null;
    }

}
