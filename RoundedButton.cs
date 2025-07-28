using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace CustomControls
{
    public class RoundedButton : Button
    {
        static RoundedButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RoundedButton),
                new FrameworkPropertyMetadata(typeof(RoundedButton)));
        }

        // CornerRadius (bereits bekannt)
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(RoundedButton),
                new PropertyMetadata(new CornerRadius(10)));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        // Icon (z. B. PNG oder DrawingImage)
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register(nameof(Icon), typeof(ImageSource), typeof(RoundedButton),
                new PropertyMetadata(null));

        public ImageSource Icon
        {
            get => (ImageSource)GetValue(IconProperty);
            set => SetValue(IconProperty, value);
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register(nameof(IconWidth), typeof(double), typeof(RoundedButton),
                new PropertyMetadata(16.0));

        public double IconWidth
        {
            get => (double)GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }

        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.Register(nameof(IconMargin), typeof(Thickness), typeof(RoundedButton),
                new PropertyMetadata(new Thickness(5, 0, 5, 0)));

        public Thickness IconMargin
        {
            get => (Thickness)GetValue(IconMarginProperty);
            set => SetValue(IconMarginProperty, value);
        }
    }
}
