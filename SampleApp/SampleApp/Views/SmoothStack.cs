using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Views
{
    public class SmoothStack : StackLayout
    {
        public static new BindableProperty IsVisibleProperty = BindableProperty.Create(nameof(IsVisible), typeof(bool), typeof(SmoothStack)
            , true, propertyChanged: OnIsVisibleChanged);

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

        static void OnIsVisibleChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (SmoothStack)bindable;

            var newValueAsBool = (bool)newValue;

            if (newValueAsBool == true)
            {
                _ = control.FadeTo(1, (uint)control.AnimationSpeed);
            }
            else
            {
                _ = control.FadeTo(0, (uint)control.AnimationSpeed);
            }
        }

        private static void OnAnimationSpeedChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var control = (SmoothStack)bindable;

            var newValueAsUint = (int)newValue;

            control.AnimationSpeed = newValueAsUint;

        }
    }
}
