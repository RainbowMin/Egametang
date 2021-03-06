﻿using System;
using UnityEngine;

namespace Model
{
	public static class GameObjectHelper
	{
		public static T Get<T>(this GameObject gameObject, string key) where T : class
		{
			try
			{
				return gameObject.GetComponent<ReferenceCollector>().Get<T>(key);
			}
			catch (Exception e)
			{
				throw new ConfigException($"获取{gameObject.name}的ReferenceCollector key失败, key: {key}", e);
			}
		}
	}
}