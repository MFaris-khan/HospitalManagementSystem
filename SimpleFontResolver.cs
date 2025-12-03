using PdfSharp.Fonts;
using System;

public class SimpleFontResolver : IFontResolver
{
    public string DefaultFontName => "Arial";

    public byte[] GetFont(string faceName)
    {
        // Load Arial from Windows fonts directory
        string fontPath = Environment.GetFolderPath(Environment.SpecialFolder.Fonts);

        if (faceName.Equals("Arial#Regular", StringComparison.OrdinalIgnoreCase))
            return System.IO.File.ReadAllBytes(System.IO.Path.Combine(fontPath, "arial.ttf"));

        if (faceName.Equals("Arial#Bold", StringComparison.OrdinalIgnoreCase))
            return System.IO.File.ReadAllBytes(System.IO.Path.Combine(fontPath, "arialbd.ttf"));

        if (faceName.Equals("Arial#Italic", StringComparison.OrdinalIgnoreCase))
            return System.IO.File.ReadAllBytes(System.IO.Path.Combine(fontPath, "ariali.ttf"));

        if (faceName.Equals("Arial#BoldItalic", StringComparison.OrdinalIgnoreCase))
            return System.IO.File.ReadAllBytes(System.IO.Path.Combine(fontPath, "arialbi.ttf"));

        return null;
    }

    public FontResolverInfo ResolveTypeface(string familyName, bool bold, bool italic)
    {
        familyName = familyName.ToLower();

        if (familyName == "courier new")
            familyName = "arial";

        if (familyName == "arial")
        {
            if (bold && italic)
                return new FontResolverInfo("Arial#BoldItalic");
            if (bold)
                return new FontResolverInfo("Arial#Bold");
            if (italic)
                return new FontResolverInfo("Arial#Italic");

            return new FontResolverInfo("Arial#Regular");
        }

        return new FontResolverInfo("Arial#Regular");
    }
}
