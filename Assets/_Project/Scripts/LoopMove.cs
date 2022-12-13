using System;
using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace _Project
{
    public class LoopMove : MonoBehaviour
    {
        private const float RightMoveTime = 5f;
        private const float LeftMoveTime = 7f;

        private void Start()
        {
            const float loopTime = RightMoveTime + LeftMoveTime;
            Observable.Timer(TimeSpan.Zero, TimeSpan.FromSeconds(loopTime))
                .Subscribe(async _ =>
                {
                    await Move.MoveOnTime(transform, new Vector3(0.05f, 0f, 0f), RightMoveTime, this.GetCancellationTokenOnDestroy());
                    await Move.MoveOnTime(transform, new Vector3(-0.05f, 0f, 0f), LeftMoveTime, this.GetCancellationTokenOnDestroy());
                }).AddTo(this);
        }
    }
}