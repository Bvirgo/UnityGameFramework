﻿//-----------------------------------------------------------------------
// <copyright>
//     Copyright (c) 2018 Zhang Yang. All rights reserved.
// </copyright>
// <describe> #资源加载类的接口，可能需要扩展为新的资源加载方式# </describe>
// <email> yeozhang@qq.com </email>
// <time> #2018年6月22日 17点01分# </time>
//-----------------------------------------------------------------------

using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GameFramework.Taurus
{
    public interface IResourceHelper
    {
        /// <summary>
        /// 设置资源的路径,默认是为只读路径:Application.streamingAssetsPath;
        /// </summary>
        /// <param name="path"></param>
        void SetResourcePath(PathType pathType, string rootAssetBundle = "AssetBundles/AssetBundles", bool isEncrypt = false);

        /// <summary>
        /// 加载资源
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="assetName"></param>
        /// <returns></returns>
        T LoadAsset<T>(string assetName) where T : UnityEngine.Object;

	    /// <summary>
	    /// 异步加载资源
	    /// </summary>
	    /// <param name="assetName"></param>
	    /// <param name="asyncCallback"></param>
	    void LoadAssetAsync<T>(string assetName,Action<string,UnityEngine.Object> asyncCallback) where T : UnityEngine.Object;

		/// <summary>
		/// 卸载资源 主要为卸载AssetBundle
		/// </summary>
		/// <param name="assetName">资源名称</param>
		/// <param name="allAssets">是否卸载调所有资源</param>
	    void UnloadAsset(string assetName, bool allAssets);

        /// <summary>
        /// 异步加载场景
        /// </summary>
        /// <param name="sceneName"></param>
        AsyncOperation LoadSceneAsync(string sceneName, LoadSceneMode mode = LoadSceneMode.Additive);

        /// <summary>
        /// 卸载场景
        /// </summary>
        /// <param name="sceneName"></param>
        AsyncOperation UnloadSceneAsync(string sceneName);

        /// <summary>
        /// 清理资源
        /// </summary>
        void Clear();

    }
}
