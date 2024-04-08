using System;
using System.Collections.Generic;

namespace lab_1.Entities;

public partial class TblMarker
{

    public TblMarker(){}
    public TblMarker(long id,string name)
    {
        Id = id;
        Name = name;
    }
    public long Id { get; set; }

    public string Name { get; set; } = null!;
    
}
