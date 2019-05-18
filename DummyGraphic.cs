using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace Syy.Logics.UI
{
    public class DummyGraphic : Graphic
    {
        protected override void OnPopulateMesh(VertexHelper vh)
        {
            vh.Clear();
        }
    }

#if UNITY_EDITOR
    [CustomEditor(typeof(DummyGraphic))]
    public class DummyGraphicsEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            EditorGUILayout.LabelField("No Draw Mesh Component");
        }
    }
#endif
}
