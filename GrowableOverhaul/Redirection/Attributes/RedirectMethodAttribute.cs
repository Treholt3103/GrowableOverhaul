﻿using System;

namespace GrowableOverhaul.Redirection.Attributes
{
    [AttributeUsage(AttributeTargets.Method)]
    internal class RedirectMethodAttribute : RedirectAttribute
    {
        public RedirectMethodAttribute() : base(false)
        {
        }

        public RedirectMethodAttribute(bool onCreated) : base(onCreated)
        {
        }
    }
}
