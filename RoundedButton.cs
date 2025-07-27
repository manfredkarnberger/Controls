using System.Windows;
using System.Windows.Controls;

namespace CustomControls
{
    public class RoundedButton : Button
    {
        static RoundedButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundedButton),
                new FrameworkPropertyMetadata(typeof(RoundedButton)));
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(RoundedButton),
                new PropertyMetadata(new CornerRadius(10)));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
    }
}
