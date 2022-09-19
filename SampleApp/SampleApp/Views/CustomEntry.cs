using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Views
{
    public class CustomEntry : Border
    {

        public static BindableProperty AnimationSpeedProperty = BindableProperty.Create(nameof(AnimationSpeed), typeof(int), typeof(SmoothStack)
, 500, propertyChanged: OnAnimationSpeedChanged);



        public new bool IsVisible
        {
            get => (bool)GetValue(IsVisibleProperty);
            set => SetValue(IsVisibleProperty, value);
        }

        public int AnimationSpeed
        {
            get => (int)GetValue(AnimationSpeedProperty);
            set => SetValue(AnimationSpeedProperty, value);
        }
    }
}
