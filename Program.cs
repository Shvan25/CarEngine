﻿using System;
class Car<T1> where T1 : Engine
{
    public T1 Engine;
    public virtual void ChangePart<T2> (T2 NewPart) where T2 : CarPart
    {
        
    }
}
class Engine
{

}
class ElectricEngine : Engine
{

}
class GasEngine : Engine
{

}
class CarPart
{

}
class Battery : CarPart
{

}
class Differential : CarPart
{

}
class Wheel : CarPart
{

}