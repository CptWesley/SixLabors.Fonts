// Copyright (c) Six Labors.
// Licensed under the Apache License, Version 2.0.

using System;
using SixLabors.Fonts.Unicode;

namespace SixLabors.Fonts
{
    /// <summary>
    /// Represents a <see cref="Glyph"/> metric.
    /// </summary>
    public readonly struct GlyphMetric
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GlyphMetric"/> struct.
        /// </summary>
        /// <param name="value">The char representing the UTF-16 code unit for the glyph.</param>
        /// <param name="bounds">The glyph bounds.</param>
        /// <exception cref="ArgumentException">
        /// If <paramref name="value"/> represents a UTF-16 surrogate code point
        /// U+D800..U+DFFF, inclusive.
        /// </exception>
        public GlyphMetric(char value, FontRectangle bounds)
            : this(new CodePoint(value), bounds)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GlyphMetric"/> struct.
        /// </summary>
        /// <param name="codePoint">The Unicode codepoint for the glyph.</param>
        /// <param name="bounds">The glyph bounds.</param>
        public GlyphMetric(CodePoint codePoint, FontRectangle bounds)
        {
            this.Codepoint = codePoint;
            this.Bounds = bounds;
        }

        /// <summary>
        /// Gets the Unicode codepoint of the glyph.
        /// </summary>
        public CodePoint Codepoint { get; }

        /// <summary>
        /// Gets the glyph bounds.
        /// </summary>
        public FontRectangle Bounds { get; }

        /// <inheritdoc/>
        public override string ToString()
            => $"Codepoint: {this.Codepoint}, Bounds: {this.Bounds}.";
    }
}
