﻿using System.Collections.Generic;

namespace VRMShaders
{
    /// <summary>
    /// TextureImportParam の集合を Unique な集合にする。
    /// </summary>
    public sealed class TextureImportParamSet
    {
        private readonly Dictionary<SubAssetKey, TextureImportParam> _params = new Dictionary<SubAssetKey, TextureImportParam>();

        public void Add(TextureImportParam param)
        {
            if (_params.ContainsKey(param.SubAssetKey)) return;

            _params.Add(param.SubAssetKey, param);
        }

        public IEnumerable<TextureImportParam> GetEnumerable()
        {
            foreach (var kv in _params)
            {
                yield return kv.Value;
            }
        }
    }
}
