namespace lab_1.Dtos.ResponseDtos
{
    public class StoryResponseDto:BaseResponseDto
    {
        public long? _authorId { get; set; }
        public string? _title { get; set; }
        public string? _content { get; set; }
        public DateTime _created { get; set; }
        public DateTime _modified { get; set; }
    }
}
