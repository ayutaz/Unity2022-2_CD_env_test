using System;
using System.Threading;
using Cysharp.Threading.Tasks;
using UniRx;
using UnityEngine;

namespace _Project
{
    public static class Move
    {
        private const float MoveTimePerTick = 0.1f;
        private const float MoveValuePerTick = 0.1f;

        public static async UniTask MoveOnTime(Transform transform, Vector3 moveValue, float moveTime, CancellationToken token)
        {
            var moveDispose = Observable.Timer(TimeSpan.Zero, TimeSpan.FromSeconds(MoveTimePerTick))
                .Subscribe(_ => { transform.Translate(moveValue * (MoveTimePerTick / moveTime)); });

            try
            {
                await UniTask.Delay(TimeSpan.FromSeconds(moveTime), cancellationToken: token);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                moveDispose.Dispose();
            }

            moveDispose.Dispose();
        }
    }
}