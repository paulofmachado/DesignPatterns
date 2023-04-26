namespace Prototype;

public class ConcretePrototypeB : Prototype
{
    public ConcretePrototypeB(string name) : base(name) { }

    public override Prototype Clone() => (Prototype)MemberwiseClone();
}
