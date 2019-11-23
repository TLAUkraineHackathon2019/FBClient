using Newtonsoft.Json;
using System;
using System.Text;

namespace YC.FacebookMessenger.Json
{
    internal class EnumConverter : JsonConverter
    {
        private bool _isUpperCase;

        public EnumConverter()
        {
            _isUpperCase = true;
        }

        public EnumConverter(bool isUpperCase = true)
        {
            _isUpperCase = isUpperCase;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType.IsEnum;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(GetValue(value));
        }

        protected string GetValue(object obj)
        {
            string value = ToSnakeCase(obj.ToString());

            return _isUpperCase ? value.ToUpperInvariant() : value;
        }

        public override bool CanRead
        {
            get { return false; }
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Taken from  Newtonsoft.Json/Src/Newtonsoft.Json/Utilities/StringUtils.cs 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        private static string ToSnakeCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return s;
            }

            StringBuilder sb = new StringBuilder();
            SnakeCaseState state = SnakeCaseState.Start;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (state != SnakeCaseState.Start)
                    {
                        state = SnakeCaseState.NewWord;
                    }
                }
                else if (char.IsUpper(s[i]))
                {
                    switch (state)
                    {
                        case SnakeCaseState.Upper:
                            bool hasNext = (i + 1 < s.Length);
                            if (i > 0 && hasNext)
                            {
                                char nextChar = s[i + 1];
                                if (!char.IsUpper(nextChar) && nextChar != '_')
                                {
                                    sb.Append('_');
                                }
                            }
                            break;
                        case SnakeCaseState.Lower:
                        case SnakeCaseState.NewWord:
                            sb.Append('_');
                            break;
                    }

                    char c;
                    c = char.ToLowerInvariant(s[i]);
                    sb.Append(c);

                    state = SnakeCaseState.Upper;
                }
                else if (s[i] == '_')
                {
                    sb.Append('_');
                    state = SnakeCaseState.Start;
                }
                else
                {
                    if (state == SnakeCaseState.NewWord)
                    {
                        sb.Append('_');
                    }

                    sb.Append(s[i]);
                    state = SnakeCaseState.Lower;
                }
            }

            return sb.ToString();
        }

        private enum SnakeCaseState
        {
            Start,
            Upper,
            Lower,
            NewWord
        }
    }
}
