﻿using Microsoft.AspNetCore.WebUtilities;
using System.Text;

namespace GalaxyExpress.BLL.Extensions;

public static class UrlEncoder
{
    public static string Encode(string value)
    {
        byte[] valueGeneratedBytes = Encoding.UTF8.GetBytes(value);
        string encodedValue = WebEncoders.Base64UrlEncode(valueGeneratedBytes);

        return encodedValue;
    }

    public static string Decode(string value)
    {
        byte[] valueDecodedBytes = WebEncoders.Base64UrlDecode(value);
        string decodedValue = Encoding.UTF8.GetString(valueDecodedBytes);

        return decodedValue;
    }
}