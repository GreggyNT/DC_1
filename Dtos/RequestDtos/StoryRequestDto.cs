namespace lab_1.Dtos.RequestDtos
{
    public class StoryRequestDto:BaseRequestDto
    {
        public long _authorId;
        public string? _title;
        public string? _content;
        public  DateTime _created;
        public DateTime _modified;
    }
}
