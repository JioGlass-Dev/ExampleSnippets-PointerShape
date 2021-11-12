using JMRSDK.InputModule;
using UnityEngine;

namespace JMRSDKExampleSnippets
{
    /// <summary>
    /// Example of changing pointer shape (inbuilt and custom prefabs).
    /// </summary>
    public class PointerShapeManager : MonoBehaviour
    {
        /// <summary>
        /// Additional Custom Cursor
        /// </summary>
        public GameObject Cursor1Prefab;
        /// <summary>
        /// Additional Custom Cursor
        /// </summary>
        public GameObject Cursor2Prefab;

        /// <summary>
        /// JMRAnimatedCursor object
        /// </summary>
        protected Transform PointerObject;
        /// <summary>
        /// Parent holding all cursor types
        /// </summary>
        protected Transform CursorParent;

        /// <summary>
        /// On first frame assign PointerObject and CursorParent; 
        /// Add custom cursors in the hierarchy of CursorParent
        /// </summary>
        public void Start()
        {
            PointerObject = FindObjectOfType<JMRAnimatedCursor>().transform;
            CursorParent = FindObjectInChilds(PointerObject.gameObject, "CursorVisual").transform;

            CursorParent.GetComponent<Animator>().enabled = false;

            AddDisabledCursor(Cursor1Prefab);
            AddDisabledCursor(Cursor2Prefab);
        }

        /// <summary>
        /// Add cursor in the hierarchy of CursorParent and caliberate it's transform
        /// </summary>
        /// <param name="cursorPrefab">Custom cursor prefab to add.</param>
        public void AddDisabledCursor(GameObject cursorPrefab)
        {
            GameObject _cursor = Instantiate(cursorPrefab, CursorParent);
            _cursor.transform.localPosition = new Vector3(0, 0, 0);
            _cursor.transform.localEulerAngles = new Vector3(90, 0, 0);
            _cursor.SetActive(false);
        }

        /// <summary>
        /// Switch between cursors
        /// </summary>
        /// <param name="index">index of cursor to activate</param>
        public void CallCursor(int index)
        {
            for (int i = 0; i < CursorParent.childCount; i++)
            {
                CursorParent.GetChild(i).gameObject.SetActive(false);
            }

            switch (index)
            {
                case 0:
                    CursorParent.GetChild(0).gameObject.SetActive(true);
                    CursorParent.GetChild(1).gameObject.SetActive(true);
                    CursorParent.GetChild(2).gameObject.SetActive(true);
                    CursorParent.GetChild(3).gameObject.SetActive(true);
                    break;
                case 1:
                    CursorParent.GetChild(4).gameObject.SetActive(true);
                    break;
                case 2:
                    CursorParent.GetChild(5).gameObject.SetActive(true);
                    break;
                case 3:
                    CursorParent.GetChild(6).gameObject.SetActive(true);
                    break;
                case 4:
                    CursorParent.GetChild(7).gameObject.SetActive(true);
                    break;
            }
        }

        GameObject FindObjectInChilds(GameObject gameObject, string gameObjectName)
        {
            Transform[] children = gameObject.GetComponentsInChildren<Transform>(true);
            foreach (Transform item in children)
            {
                if (item.name == gameObjectName)
                {
                    return item.gameObject;
                }
            }

            return null;
        }
    }
}