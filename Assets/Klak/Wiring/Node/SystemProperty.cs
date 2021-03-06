//
// Klak - Utilities for creative coding with Unity
//
// Copyright (C) 2016 Keijiro Takahashi
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//
using UnityEngine;
using UnityEngine.Events;

namespace Klak.Wiring
{
    [AddComponentMenu("Klak/Wiring/System Property")]
    public class SystemProperty : NodeBase
    {
        #region Public Properties

        [Inlet]
        public float timeScale {
            get { return Time.timeScale; }
            set { Time.timeScale = value; }
        }

        [Inlet]
        public Vector3 gravity {
            get { return Physics.gravity; }
            set { Physics.gravity = value; }
        }

        [Inlet]
        public float ambientIntensity {
            get { return RenderSettings.ambientIntensity; }
            set { RenderSettings.ambientIntensity = value; }
        }

        [Inlet]
        public float reflectionIntensity {
            get { return RenderSettings.reflectionIntensity; }
            set { RenderSettings.reflectionIntensity = value; }
        }

        [Inlet]
        public bool fog {
            get { return RenderSettings.fog; }
            set { RenderSettings.fog = value; }
        }

        [Inlet]
        public Color fogColor {
            get { return RenderSettings.fogColor; }
            set { RenderSettings.fogColor = value; }
        }

        [Inlet]
        public float fogDensity {
            get { return RenderSettings.fogDensity; }
            set { RenderSettings.fogDensity = value; }
        }

        [Inlet]
        public float fogStartDistance {
            get { return RenderSettings.fogStartDistance; }
            set { RenderSettings.fogStartDistance = value; }
        }

        [Inlet]
        public float fogEndDistance {
            get { return RenderSettings.fogEndDistance; }
            set { RenderSettings.fogEndDistance = value; }
        }

        #endregion
    }
}
