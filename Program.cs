using System;
abstract class Car<TEngine> where TEngine : Engine
{
    public TEngine Engine;
    public virtual void ChangePart<TPart>(TPart NewPart) where TPart : CarPart
    {
        
    }
}
abstract class Engine
{

}
class ElectricEngine : Engine
{

}
class GasEngine : Engine
{

}
abstract class CarPart
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
class ElectricCar : Car<ElectricEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}

class GasCar : Car<GasEngine>
{
    public override void ChangePart<TPart>(TPart newPart)
    {

    }
}