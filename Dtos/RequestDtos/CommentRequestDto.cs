namespace lab_1.Dtos.RequestDtos
{
    public class CommentRequestDto : BaseRequestDto
    {
        public long? _storyId { get; set; }
        public string? _content { get; set; }
    }
}
