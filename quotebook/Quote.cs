public class Quote
{
    private string _author = "";
    private string _quote = "";
    private source _source;

    public Quote(string person, string Quote, Source source)
    {
        _author = person;
        _quote = quote;
        _source = source;
    }

    public bool HasAuthor(string name)
    {
        if(_author.ToUpper().Contains(name.ToUpper()))
        {
            return true;
        }
        return false;
    }

    public string GetQuote()
    {
        return $"\"{_quote}\"\n{_author} - {_source.strigify()}";
    }



}