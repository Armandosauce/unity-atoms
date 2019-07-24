using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityAtoms
{
    [CreateAssetMenu(menuName = "Unity Atoms/App Management/Quit App")]
    public class Quit : VoidAction
    {
        public float timeBeforeExit;
        private bool _exit;

        public override void Do()
        {
            CoroutineObject.inst.StartCoroutine(QuitAppAfterDelay(timeBeforeExit));
        }

        private IEnumerator QuitAppAfterDelay(float delay)
        {
            yield return new WaitForSecondsRealtime(delay);

#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
                Application.Quit();
#endif

        }
    }
}
