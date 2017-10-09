using System.Text.RegularExpressions;

namespace Parcel
{
  public class Dimensions
  {
    private int _length;
    private int _width;
    private int _height;
    private int _weight;

    private string _regex = @"\d";

    public void SetLength(string newLength)
    {
      Match result = Regex.Match(newLength, _regex);
      if (result.Success)
      {
        _length = int.Parse(newLength);
      }
      else {
        _length = 80085;
      }
    }
    public int GetLength()
    {
      return _length;
    }


    public void SetWidth(string newWidth)
    {
      Match result = Regex.Match(newWidth, _regex);
      if (result.Success)
      {
        _width = int.Parse(newWidth);
      }
      else {
        _width = 80085;
      }
    }
    public int GetWidth()
    {
      return _width;
    }


    public void SetHeight(string newHeight)
    {
      Match result = Regex.Match(newHeight, _regex);
      if (result.Success)
      {
        _height = int.Parse(newHeight);
      }
      else {
        _height = 80085;
      }
    }
    public int GetHeight()
    {
      return _height;
    }


    public void SetWeight(string newWeight)
    {
      Match result = Regex.Match(newWeight, _regex);
      if (result.Success)
      {
        _weight = int.Parse(newWeight);
      }
      else {
        _weight = 80085;
      }
    }
    public int GetWeight()
    {
      return _weight;
    }
  }
}
