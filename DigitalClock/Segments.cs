using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalClock
{
    internal static class Segments
    {
        //"UpdateSegments", который помогает нам управлять тем, какие сегменты должны быть видимыми и какие - нет.

        //Например, если мы хотим показать цифру "1" на часах, мы вызываем метод "UpdateSegments" и говорим ему
        //включить только определенные сегменты, чтобы они выглядели как "1". Если мы хотим показать цифру "2", мы
        //меняем настройки сегментов, чтобы они выглядели как "2", и так далее.

        //sevenSegmentIndicator - это объект типа Indicator, который передается в метод как параметр. 
        //BoxView - это тип данных или класс \ элемент интерфейса \ предназначение: создания прямоугольных границ или рамок вокруг других элементов интерфейса
        //topSegment - это параметр метода типа BoxView, 

        public static void UpdateSegments(this Indicator sevenSegmentIndicator, BoxView topSegment, BoxView leftTopSegment,
            BoxView rightTopSegment, BoxView middleSegment, BoxView leftBottomSegment, BoxView rightBottomSegment, BoxView bottomSegment)
        {
            topSegment.IsVisible = sevenSegmentIndicator.TopSegment;
            leftTopSegment.IsVisible = sevenSegmentIndicator.LeftTopSegment;
            rightTopSegment.IsVisible = sevenSegmentIndicator.RightTopSegment;
            middleSegment.IsVisible = sevenSegmentIndicator.MiddleSegment;
            leftBottomSegment.IsVisible = sevenSegmentIndicator.LeftBottomSegment;
            rightBottomSegment.IsVisible = sevenSegmentIndicator.RightBottomSegment;
            bottomSegment.IsVisible = sevenSegmentIndicator.BottomSegment;
        }
    }
}
