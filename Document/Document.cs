
namespace Document
{
    class Document : IDocument
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Document(string content, string title)
        {
            Title = title;
            Content = content;
        }
    }
}
