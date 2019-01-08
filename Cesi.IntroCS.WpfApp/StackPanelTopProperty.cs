using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Cesi.IntroCS.WpfApp
{
    public class StackPanelTopProperty : DependencyObject
    {
        public static readonly DependencyProperty TopProperty =
            DependencyProperty.RegisterAttached("Top", typeof(int), typeof(StackPanel),
            new FrameworkPropertyMetadata(0));

        public static void SetTop(UIElement element, int value)
        {
            element.SetValue(TopProperty, value);
        }

        public static int GetTop(UIElement element)
        {
            return (int)element.GetValue(TopProperty);
        }
    }
}
