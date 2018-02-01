namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            // Напишите функцию склонения слова "рублей" в зависимости от предшествующего числительного count.
            if ((count % 10) == 1)
                return "рубль";
            else if (((count % 10) > 1) && (count % 10 < 5))
                return "рубля";
            else if (((count % 10) > 4) && (count % 10 < 10))
                return "рублей";
            else return "рублей";

        }
	}
}