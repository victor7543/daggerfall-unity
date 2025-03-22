// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2022 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Podleron (podleron@gmail.com)

using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

namespace DaggerfallWorkshop.Game.Addons.RmbBlockEditor.Elements
{
    public class Tab : VisualElement
    {
        public new class UxmlFactory : UxmlElementAttribute
        {
        }

        public new class UxmlTraits : UxmlElementAttribute
        {
            UxmlIntAttributeDescription value =
                new UxmlIntAttributeDescription { name = "value", defaultValue = 0 };
            UxmlStringAttributeDescription label =
                new UxmlStringAttributeDescription { name = "label", defaultValue = "" };
        }

        public int value { get; set; }
        public string label { get; set; }
    }
}