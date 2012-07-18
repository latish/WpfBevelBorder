using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BevelEffect
{
    public partial class BevelBorderUserControl : UserControl
    {
        public BevelBorderUserControl()
        {
            InitializeComponent();
        }

        public CornerRadius CornerRadius
        {
            get { return (CornerRadius) GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public Thickness BevelBorderThickness
        {
            get { return (Thickness) GetValue(BevelBorderThicknessProperty); }
            set { SetValue(BevelBorderThicknessProperty, value); }
        }

        public Brush FirstHalfBrush
        {
            get { return (Brush) GetValue(FirstHalfBrushProperty); }
            set { SetValue(FirstHalfBrushProperty, value); }
        }

        public Brush SecondHalfBrush
        {
            get { return (Brush) GetValue(SecondHalfBrushProperty); }
            set { SetValue(SecondHalfBrushProperty, value); }
        }

        public Brush BackgroundFill
        {
            get { return (Brush) GetValue(BackgroundFillProperty); }
            set { SetValue(BackgroundFillProperty, value); }
        }

        static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register(
            "CornerRadius", typeof(CornerRadius), typeof(BevelBorderUserControl));
        static readonly DependencyProperty BevelBorderThicknessProperty = DependencyProperty.Register(
            "BevelBorderThickness", typeof(Thickness), typeof(BevelBorderUserControl));


        static readonly DependencyProperty FirstHalfBrushProperty = DependencyProperty.Register(
            "FirstHalfBrush", typeof(Brush), typeof(BevelBorderUserControl));

        static readonly DependencyProperty SecondHalfBrushProperty = DependencyProperty.Register(
            "SecondHalfBrush", typeof(Brush), typeof(BevelBorderUserControl));

        static readonly DependencyProperty BackgroundFillProperty = DependencyProperty.Register(
            "BackgroundFillProperty", typeof(Brush), typeof(BevelBorderUserControl));
    }
}
