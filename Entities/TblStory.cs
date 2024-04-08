using System;
using System.Collections.Generic;

namespace lab_1.Entities;

public partial class TblStory
{
    public TblStory()
    {
    }

    public long Id { get; set; }

    public long AuthorId { get; set; }

    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public DateOnly Created { get; set; }

    public DateOnly Modified { get; set; }
}
