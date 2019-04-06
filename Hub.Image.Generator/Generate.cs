using System;

namespace Hub.Image.Generator
{
    public class Generate : IGenerate
    {
        public Generate()
        {

        }

        public string Get(string bgColour, string fontColour, string fontSize, string width, string height, string text)
        {
            // Reference example: 
            // https://placehold.jp/24/1a1a1a/ffffff/360x360.png?text=Testing+Longish+Title+Plus

            var image = "https://placehold.jp/150x150.png";

            if (string.IsNullOrWhiteSpace(bgColour) &&
                string.IsNullOrWhiteSpace(fontColour) &&
                string.IsNullOrWhiteSpace(fontSize) &&
                string.IsNullOrWhiteSpace(width) &&
                string.IsNullOrWhiteSpace(height) &&
                string.IsNullOrWhiteSpace(text))
            {
                return image;
            }

            image = "https://placehold.jp";

            if (!string.IsNullOrWhiteSpace(fontSize))
            {
                image += $"/{fontSize}";
            }

            if (!string.IsNullOrWhiteSpace(bgColour))
            {
                image += $"/{bgColour}";
            }

            if (!string.IsNullOrWhiteSpace(fontColour))
            {
                image += $"/{fontColour}";
            }

            if (!string.IsNullOrWhiteSpace(width))
            {
                image += $"/{width}";
            }

            if (!string.IsNullOrWhiteSpace(height))
            {
                image += $"x{height}.png";
            }

            if (!string.IsNullOrWhiteSpace(text))
            {
                image += $"?text={text.Replace(" ", "+")}";
            }

            return image;
        }
    }
}
