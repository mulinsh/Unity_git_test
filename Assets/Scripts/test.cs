///=====================================================
/// - FileName:      test.cs
/// - NameSpace:     YukiFrameWork.Example
/// - Description:   高级定制脚本生成
/// - Creation Time: 2025/2/9 12:03:42
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using Sirenix.OdinInspector;

namespace YukiFrameWork.Example
{
    public class test : MonoBehaviour
    {
        // 示例字段，用于在 Inspector 中显示和编辑
        [SerializeField, BoxGroup("Example Group")]
        private int exampleInt = 10;

        [SerializeField, BoxGroup("Example Group")]
        private string exampleString = "Hello, Odin!";

        // 使用 [Button] 属性创建一个按钮
        [Button("点击我")]
        private void TestButton()
        {
            Debug.Log($"按钮被点击了！exampleInt: {exampleInt}, exampleString: {exampleString}");
        }
    }
}