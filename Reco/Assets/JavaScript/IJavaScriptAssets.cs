﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResourceCompiler.Files;
using ResourceCompiler.JavaScript.Minifiers;

namespace ResourceCompiler.Assets
{
    public interface IJavaScriptAssets
    {
        IJavaScriptAssets Combine(bool value);
        IJavaScriptAssets Compress(bool value);
        IJavaScriptAssets Version(bool value);
        IJavaScriptAssets Add(string path);
        IJavaScriptAssets Media(string value);
        IJavaScriptAssets SetCompressor(IJavaScriptCompressor compressor);
        IList<IResource> GetFiles();

        bool Versioned { get; set; }
        bool Combined { get; set; }
        bool Compressed { get; set; }
        string MediaType { get; set; }
        IJavaScriptCompressor Compressor { get; set; }
        string GetLastWriteTimestamp();
    }
}
