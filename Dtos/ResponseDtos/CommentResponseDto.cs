namespace lab_1.Dtos.ResponseDtos
{
    public class CommentResponseDto:BaseResponseDto
    {
        public long? _storyId { get; set; }
        public string? _content { get; set; }
    }
}
