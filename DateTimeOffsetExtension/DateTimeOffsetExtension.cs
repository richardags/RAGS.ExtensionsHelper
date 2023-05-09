using DateTimeOffsetExtension.classes;
using System;
using TelegramHelper;

namespace DateTimeOffsetExtension
{
    public static class DateTimeOffsetExtension
    {
        public static DateTimeOffset TruncateMillisecond(this DateTimeOffset dateTimeOffset)
        {
            return new DateTimeOffset(
                dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day,
                dateTimeOffset.Hour, dateTimeOffset.Minute, dateTimeOffset.Second,
                TimeSpan.Zero);
        }
        public static DateTimeOffset TruncateSecond(this DateTimeOffset dateTimeOffset)
        {
            return new DateTimeOffset(
                dateTimeOffset.Year, dateTimeOffset.Month, dateTimeOffset.Day,
                dateTimeOffset.Hour, dateTimeOffset.Minute, 0,
                TimeSpan.Zero);
        }

        public static string FullFormat(this DateTimeOffset dateTimeOffset, TelegramLanguageEnum language)
        {
            switch (language)
            {
                case TelegramLanguageEnum.ENGLISH:
                    return dateTimeOffset.ToString(Constants.ENGLISH_FULL_DATETIME_FORMAT);
                case TelegramLanguageEnum.PORTUGUESE:
                    return dateTimeOffset.ToString(Constants.PORTUGUESE_FULL_DATETIME_FORMAT);
                case TelegramLanguageEnum.SPANISH:
                    return dateTimeOffset.ToString(Constants.SPANISH_FULL_DATETIME_FORMAT);
                default:
                    throw new Exception("DateTimeOffsetExtension.cs FullFormat() - unknown language: " + language);
            }
        }
        public static string ShortFormat(this DateTimeOffset dateTimeOffset, TelegramLanguageEnum language)
        {
            switch (language)
            {
                case TelegramLanguageEnum.ENGLISH:
                    return dateTimeOffset.ToString(Constants.ENGLISH_SHORT_DATETIME_FORMAT);
                case TelegramLanguageEnum.PORTUGUESE:
                    return dateTimeOffset.ToString(Constants.PORTUGUESE_SHORT_DATETIME_FORMAT);
                case TelegramLanguageEnum.SPANISH:
                    return dateTimeOffset.ToString(Constants.SPANISH_SHORT_DATETIME_FORMAT);
                default:
                    throw new Exception("DateTimeOffsetExtension.cs ShortFormat() - unknown language: " + language);
            }
        }
    }
}