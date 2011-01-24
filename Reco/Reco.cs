﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ResourceCompiler.Renderers;
using ResourceCompiler.Assets;

namespace ResourceCompiler
{
    public static class Reco
    {
        private static string _linkTemplate = "<link rel=\"stylesheet\" type=\"text/css\" {0} href=\"{1}\" />";
        private static string _scriptTemplate = "<script type=\"text/javascript\" src=\"{0}\" ></script>";

        public static IStyleSheetRenderer StyleSheets()
        {
            return new StyleSheetRenderer(RecoAssets.StyleSheet());
        }

        public static IJavaScriptRenderer JavaScript()
        {
            return new JavaScriptRenderer(RecoAssets.JavaScript());
        }

        public static string Link(string path)
        {
            //check if path has a starting slash, if not add it
            //dont add v=? if not versioning
            //handle situation where we dont want to combine
            IStyleSheetAssets assets = RecoAssets.StyleSheet();

            string media = "media=\"{0}\"";
            string version = string.Empty;
            string url = "{0}?v={1}";

            if (assets.Versioned)
            {
                version = assets.GetLastWriteTimestamp();
            }

            media = string.Format(media, assets.MediaType);
            url = string.Format(url, path, version);
            return String.Format(_linkTemplate, media, url);
        }

        public static string Script(string path)
        {
            IJavaScriptAssets assets = RecoAssets.JavaScript();

            string version = string.Empty;
            string url = "{0}?v={1}";

            if (assets.Versioned)
            {
                version = assets.GetLastWriteTimestamp();
            }

            url = string.Format(url, path, version);
            return String.Format(_scriptTemplate, url);
        }
    }
}
