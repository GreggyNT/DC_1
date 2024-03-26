namespace lab_1.Dtos.ResponseDtos
{
    public class StoryResponseDto:BaseResponseDto
    {
        public long _authorId;
        public string? _title;
        public string? _content;
        public DateTime _created;
        public DateTime _modified;
    }
}
