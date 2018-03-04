using System.Collections.Generic;

public interface ILeutenantGeneral : ISoldier
{
    List<ISoldier> Privates { get; }
}
