namespace Reco.JavaScript.Minifiers
{
    public interface IJavaScriptCompressor
    {
        string Identifier { get; }        
        string CompressContent(string content);
    }
}