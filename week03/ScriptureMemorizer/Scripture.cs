public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string sentence = text;
        string[] words = sentence.Split(' ');

        foreach (var w in words)
        {
            Word word = new Word(w);
            _words.Add(word);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        if (IsCompletelyHidden())
        {
            return;
        }

        int hidden = 0;
        Random random = new Random();

        while (hidden < numberToHide)
        {
            if (IsCompletelyHidden())
            {
                break;
            }

            int index = random.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hidden++;
            }
        }

    }

    public string GetDisplayText()
    {
        string fullReference = $"{_reference.GetDisplayText()} -";

        foreach (Word word in _words)
        {
            fullReference += $" {word.GetDisplayText()}";
        }

        return fullReference;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
}