﻿using ColossalFramework;
using GrowableOverhaul.Redirection;
using UnityEngine;

namespace GrowableOverhaul
{
    [TargetType(typeof(RoadAI))]
    public static class RoadAIDetour
    {
        [RedirectMethod(false)] // reason for detour: display correct zone area when using NetTool
        public static void GetEffectRadius(RoadAI _this, out float radius, out bool capped, out Color color)
        {
            if (_this.m_enableZoning)
            {
                radius = Mathf.Max(8f, _this.m_info.m_halfWidth) + InputThreadingExtension.userSelectedColumnCount * 8f; // modified
                capped = true;
                if (Singleton<InfoManager>.instance.CurrentMode != InfoManager.InfoMode.None)
                {
                    color = Singleton<ToolManager>.instance.m_properties.m_validColorInfo;
                    color.a *= 0.5f;
                }
                else
                {
                    color = Singleton<ToolManager>.instance.m_properties.m_validColor;
                    color.a *= 0.5f;
                }
            }
            else
            {
                radius = 0.0f;
                capped = false;
                color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
            }
        }
    }
}
