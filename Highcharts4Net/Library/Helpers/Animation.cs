﻿using Highcharts4Net.Library.Enums;

namespace Highcharts4Net.Library.Helpers
{
    public class Animation
    {
        public bool? EnableAnimation { get; private set; }

        public AnimationConfig AnimationConfig { get; private set; }

        public Animation(bool animation) { EnableAnimation = animation; }

        public Animation(AnimationConfig animation) { AnimationConfig = animation; }
    }

    public class AnimationConfig
    {
        /// <summary>
        /// The duration of the animation in milliseconds.
        /// </summary>
        /// <see cref="http://www.highcharts.com/ref/#chart--animation"/>
        public int? Duration { get; set; }

        /// <summary>
        /// When using jQuery as the general framework, the easing can be set to linear or swing. 
        /// More easing functions are available with the use of jQuery plug-ins, most notably the jQuery UI suite. 
        /// See the jQuery docs. When using MooToos as the general framework, use the property name transition instead of easing.
        /// </summary>
        /// <see cref="http://www.highcharts.com/ref/#chart--animation"/>
        public EasingTypes? Easing { get; set; }
    }
}