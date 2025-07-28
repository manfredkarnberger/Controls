using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Media;

namespace CustomControls
{
    public class PushButton : ToggleButton
    {
        static PushButton()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(PushButton),
                new FrameworkPropertyMetadata(typeof(PushButton)));
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(PushButton),
                new PropertyMetadata(new CornerRadius(10)));

        public CornerRadius CornerRadius
        {
            get => (CornerRadius)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public static readonly DependencyProperty ActiveIconProperty =
            DependencyProperty.Register(nameof(ActiveIcon), typeof(ImageSource), typeof(PushButton),
                new PropertyMetadata(null));

        public ImageSource ActiveIcon
        {
            get => (ImageSource)GetValue(ActiveIconProperty);
            set => SetValue(ActiveIconProperty, value);
        }

        public static readonly DependencyProperty InactiveIconProperty =
            DependencyProperty.Register(nameof(InactiveIcon), typeof(ImageSource), typeof(PushButton),
                new PropertyMetadata(null));

        public ImageSource InactiveIcon
        {
            get => (ImageSource)GetValue(InactiveIconProperty);
            set => SetValue(InactiveIconProperty, value);
        }

        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register(nameof(IconWidth), typeof(double), typeof(PushButton),
                new PropertyMetadata(16.0));

        public double IconWidth
        {
            get => (double)GetValue(IconWidthProperty);
            set => SetValue(IconWidthProperty, value);
        }

        public static readonly DependencyProperty IconMarginProperty =
            DependencyProperty.Register(nameof(IconMargin), typeof(Thickness), typeof(PushButton),
                new PropertyMetadata(new Thickness(5, 0, 5, 0)));

        public Thickness IconMargin
        {
            get => (Thickness)GetValue(IconMarginProperty);
            set => SetValue(IconMarginProperty, value);
        }
    }
}
