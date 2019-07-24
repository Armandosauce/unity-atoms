using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineObject : MonoBehaviour
{
    private static CoroutineObject coroutine = null;

    public static CoroutineObject inst
    {
        get
        {
            if (coroutine == null)
            {
                coroutine = new GameObject("RunningCoroutine").AddComponent<CoroutineObject>();
            }

            return coroutine;
        }
    }
    
}
