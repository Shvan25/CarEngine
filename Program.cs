using System;
class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;
    public virtual void ChangePart<TPart>(TPart NewPart) where TPart : CarPart
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