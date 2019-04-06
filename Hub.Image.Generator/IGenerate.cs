using System;

namespace Hub.Image.Generator
{
    public interface IGenerate
    {
        string Get(string bgColour, string fontColour, string fontSize, string width, string height, string text);
    }
}
