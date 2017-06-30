﻿// The MIT License (MIT)

// Copyright (c) 2016 Ben Abelshausen

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System.Collections.Generic;

namespace OpenLR.Referenced.Codecs.Scoring
{
    /// <summary>
    /// A combined score compared.
    /// </summary>
    internal class CombinedScoreComparer : IComparer<CombinedScore>
    {
        /// <summary>
        /// Compares the two combine scores.
        /// </summary>
        public int Compare(CombinedScore x, CombinedScore y)
        {
            var comparison = y.Score.Value.CompareTo(x.Score.Value);
            if(comparison == 0)
            {
                if (y.Target.Path.Equals(x.Target.Path) && x.Source.Path.Equals(y.Source.Path) &&
                    y.Target.Location.EdgeId.Equals(x.Target.Location.EdgeId) && 
                    x.Source.Location.EdgeId.Equals(y.Source.Location.EdgeId) &&
                    y.Target.Location.Offset.Equals(x.Target.Location.Offset) &&
                    x.Source.Location.Offset.Equals(y.Source.Location.Offset))
                { // only return 0 on items that are actually equal.
                    return 0;
                }
                return 1;
            }
            return comparison;
        }
    }
}