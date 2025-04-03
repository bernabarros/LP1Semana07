```mermaid

---
title: BetterColorSpheresClasses
---
classDiagram
Sphere-->Color
class Color{
    Color : +byte Red
    Color : +byte Green
    Color : +byte Blue
    Color : +byte Alpha
    Color : +byte Grey
    }

    class Sphere{
        -Color color
        -float radius
        -int times_thrown
        +byte GetColorRed()
        +byte GetColorGreen()
        +byte GetColorBlue()
        +byte GetColorAlpha()
        +byte GetColorGrey()
        +float GetRadius()
        +float Pop()
        +int Throw()
        +int GetTimesThrown()
    }

