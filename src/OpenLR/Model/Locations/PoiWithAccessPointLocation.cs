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

using OpenLR.Model;

namespace OpenLR.Model.Locations
{
    /// <summary>
    /// Represents a POI with access point location.
    /// </summary>
    public class PoiWithAccessPointLocation : ILocation
    {
        /// <summary>
        /// Gets or sets the first location reference point.
        /// </summary>
        public LocationReferencePoint First { get; set; }

        /// <summary>
        /// Gets or sets the last location reference point.
        /// </summary>
        public LocationReferencePoint Last { get; set; }

        /// <summary>
        /// Gets or sets the coordinate of the access point (COORD).
        /// </summary>
        public Coordinate Coordinate { get; set; }

        /// <summary>
        /// Gets or sets the positive offset (POFF).
        /// </summary>
        public int? PositiveOffset { get; set; }

        /// <summary>
        /// Gets or sets the side of road information (SOR).
        /// </summary>
        public SideOfRoad? SideOfRoad { get; set; }

        /// <summary>
        /// Gets or sets the SideOfRoad (ORI).
        /// </summary>
        public Orientation? Orientation { get; set; }
    }
}