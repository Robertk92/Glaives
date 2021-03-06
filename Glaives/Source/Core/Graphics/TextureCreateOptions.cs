﻿// MIT License
// 
// Copyright(c) 2018 Glaives Game Engine.
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using Glaives.Core;

namespace Glaives.Core.Graphics
{
    /// <inheritdoc />
    /// <summary>
    /// The create options to use for the texture
    /// </summary>
    public class TextureCreateOptions : ContentCreateOptions
    {
        /// <summary>
        /// The way the texture is filtered
        /// </summary>
        public readonly TextureFilterMode FilterMode;

        /// <summary>
        /// The way the texture is wrapped outside of the texture coordinates
        /// </summary>
        public readonly TextureWrapMode WrapMode;

        /// <summary>
        /// Create new texture create options
        /// </summary>
        /// <param name="filterMode">The way the texture is filtered</param>
        /// <param name="wrapMode">The way the texture is wrapped outside of the texture coordinates</param>
        public TextureCreateOptions(TextureFilterMode filterMode, TextureWrapMode wrapMode)
        {
            FilterMode = filterMode;
            WrapMode = wrapMode;
        }

        /// <inheritdoc />
        protected override bool IsEqualContent(ContentCreateOptions otherContent)
        {
            TextureCreateOptions other = (TextureCreateOptions) otherContent;
            if (other != null)
            {
                if (FilterMode == other.FilterMode &&
                    WrapMode == other.WrapMode)
                {
                    return true;
                }
            }

            return false;
        }

        /// <inheritdoc />
        public override string ToString()
        {
            return $"(Filter: {FilterMode}, Wrap: {WrapMode})";
        }
        
        /// <summary>
        /// <para>FilterMode : Smooth</para>
        /// <para>WrapMode : ClampToEdge</para>
        /// </summary>
        public static TextureCreateOptions Smooth => new TextureCreateOptions(TextureFilterMode.Smooth, TextureWrapMode.ClampToEdge);

        /// <summary>
        /// <para>FilterMode : Sharp</para>
        /// <para>WrapMode : ClampToEdge</para>
        /// </summary>
        public static TextureCreateOptions Sharp => new TextureCreateOptions(TextureFilterMode.Sharp, TextureWrapMode.ClampToEdge);
    }
}