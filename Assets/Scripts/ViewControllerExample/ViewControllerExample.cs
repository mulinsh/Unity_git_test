///=====================================================
/// - FileName:      ViewControllerExample.cs
/// - NameSpace:     YukiFrameWork.Example
/// - Description:   框架自定ViewController
/// - Creation Time: 2025/2/9 12:27:52
/// -  (C) Copyright 2008 - 2025
/// -  All Rights Reserved.
///=====================================================
using YukiFrameWork;
using UnityEngine;
using System;
using Sirenix.OdinInspector;
namespace YukiFrameWork.Example
{
	public partial class ViewControllerExample : ViewController
	{
		
			[Button("点击我")]
			private void Test()
			{
				LogKit.I("信息");
			}
		
	}
}
