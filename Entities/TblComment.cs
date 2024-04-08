using System;
using System.Collections.Generic;

namespace lab_1.Entities;

public partial class TblComment
{
    
    public TblComment()
    {
    }

    public TblComment(long id, long storyId, string content)
    {
        Id = id;
        StoryId = storyId;
        Content = content;
      
    }

    public long Id { get; set; }

    public long StoryId { get; set; }

    public string Content { get; set; } = null!;
    
}
