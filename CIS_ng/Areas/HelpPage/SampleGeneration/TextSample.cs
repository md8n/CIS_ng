using System;

namespace CIS_ng.Areas.HelpPage.SampleGeneration
{
  /// <summary>
  /// This represents a pre-formatted text sample on the help page. There's a display template named TextSample associated with this class.
  /// </summary>
  public class TextSample
  {
    public TextSample(string text)
    {
      if (text == null)
      {
        throw new ArgumentNullException(nameof(text));
      }
      Text = text;
    }

    public string Text { get; }

    public override bool Equals(object obj)
    {
      var other = obj as TextSample;

      return other != null && Text == other.Text;
    }

    public override int GetHashCode()
    {
      return Text.GetHashCode();
    }

    public override string ToString()
    {
      return Text;
    }
  }
}