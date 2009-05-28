using System;
using System.IO;
using Google.GData.Client;

namespace Google.Unoffical.Translate
{
    // Ported from Richard Midwinter's Unofficial Java Google Translate API

    public static class Language
    {
        public static string AUTO_DETECT = "";
        public static string ARABIC = "ar";
        public static string BULGARIAN = "bg";
        public static string CATALAN = "ca";
        public static string CHINESE = "zh";
        public static string CHINESE_SIMPLIFIED = "zh-CN";
        public static string CHINESE_TRADITIONAL = "zh-TW";
        public static string CROATIAN = "hr";
        public static string CZECH = "cs";
        public static string DANISH = "da";
        public static string DUTCH = "nl";
        public static string ENGLISH = "en";
        public static string FILIPINO = "tl";
        public static string FINNISH = "fi";
        public static string FRENCH = "fr";
        public static string GALACIAN = "gl";
        public static string GERMAN = "de";
        public static string GREEK = "el";
        public static string HEBREW = "iw";
        public static string HINDI = "hi";
        public static string HUNGARIAN = "hu";
        public static string INDONESIAN = "id";
        public static string ITALIAN = "it";
        public static string JAPANESE = "ja";
        public static string KOREAN = "ko";
        public static string LATVIAN = "lv";
        public static string LITHUANIAN = "lt";
        public static string MALTESE = "mt";
        public static string NORWEGIAN = "no";
        public static string POLISH = "pl";
        public static string PORTUGESE = "pt";
        public static string ROMANIAN = "ro";
        public static string RUSSIAN = "ru";
        public static string SERBIAN = "sr";
        public static string SLOVAK = "sk";
        public static string SLOVENIAN = "sl";
        public static string SPANISH = "es";
        public static string SWEDISH = "sv";
        public static string THAI = "th";
        public static string TURKISH = "tr";
        public static string UKRANIAN = "uk";
        public static string VIETNAMESE = "vi";

        public static string[] validLanguages = new string[] {
			    AUTO_DETECT, ARABIC, BULGARIAN, CATALAN, CHINESE, CHINESE_SIMPLIFIED,
			    CHINESE_TRADITIONAL, CROATIAN, CZECH, DANISH, DUTCH,
			    ENGLISH, FILIPINO, FINNISH, FRENCH, GALACIAN, GERMAN,
			    GREEK, HEBREW, HINDI, HUNGARIAN, INDONESIAN, ITALIAN,
			    JAPANESE, KOREAN, LATVIAN, LITHUANIAN, MALTESE, NORWEGIAN,
			    POLISH, PORTUGESE, ROMANIAN, RUSSIAN, SERBIAN, SLOVAK,
			    SLOVENIAN, SPANISH, SWEDISH, THAI, TURKISH, UKRANIAN, VIETNAMESE
        	    };

        /**
         * Checks a given language is available to use with Google Translate.
         * 
         * @param language The language code to check for.
         * @return true if this language is available to use with Google Translate, false otherwise.
         */
        public static bool isValidLanguage(string checkLanguage)
        {
            foreach (string Language in validLanguages)
            {
                if (Language == checkLanguage)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public static class Translate
    {
        private static string ENCODING = "UTF-8";
        private static string URL_STRING = "http://ajax.googleapis.com/ajax/services/language/translate?v=1.0&langpair=";
        private static string TEXT_VAR = "&q=";

        /**
         * Translates text from a given language to another given language using Google Translate
         * 
         * @param text The string to translate.
         * @param from The language code to translate from.
         * @param to The language code to translate to.
         * @return The translated string.
         * @throws MalformedURLException
         * @throws IOException
         */
        public static string translate(string text, string from, string to)
        {
            return retrieveTranslation(text, from, to);
        }
        /**
         * Forms an HTTP request and parses the response for a translation.
         * 
         * @param text The string to translate.
         * @param from The language code to translate from.
         * @param to The language code to translate to.
         * @return The translated string.
         * @throws Exception
         */
        private static string retrieveTranslation(string text, string from, string to)
        {
            if (!Language.isValidLanguage(from) || !Language.isValidLanguage(to) || Language.AUTO_DETECT == to)
            {
                throw new ArgumentException("You must use a valid language code to translate to and from.");
            }

            try
            {
                Uri RequestURL = new Uri(URL_STRING + from + "|" + to + TEXT_VAR + text); //URLEncoder.encode( text, ENCODING ) );
                Service TranslationRequest = new Service("GoogleTranslateUnofficialAPI");

                Stream result = TranslationRequest.Query(RequestURL);
                String page = "";

                const int size = 4096;
                byte[] bytes = new byte[size];
                int numBytes;
                while ((numBytes = result.Read(bytes, 0, size)) > 0)
                {
                    page += System.Text.Encoding.UTF8.GetString(bytes, 0, numBytes);
                }
                //{\"responseData\": {\"translatedText\":\"tout va bien dans ma douleur, elle n\\u0026#39;est pas un salon de beaut??, salle de gravure, de cendre et de l\\u0026#39;ombre, voil?? le h??ros\"}, \"responseDetails\": null, \"responseStatus\": 200}
                int resultBox = page.IndexOf("\"translatedText\":\"");
                if (resultBox < 0)
                    throw new Exception("No translation result returned.");

                String start = page.Substring(resultBox + 18);
                int nStart = start.IndexOf('\"');
                return start.Substring(0, nStart);
            }
            catch (Exception ex)
            {
                throw new Exception("[Google.Unoffical.Translate] Error retrieving translation.", ex);
            }
        }
    }
}