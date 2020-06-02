namespace StringCompare.Logic
{
    public class CharCompareFromString
    {
        /// <summary>
        /// Total Same latter with Same Position with Two Difference String
        /// </summary>
        /// <param name="firstString">firstString as string value</param>
        /// <param name="secondString">secondString as string value</param>
        /// <returns>return Match Character</returns>
        public int GetCharacterCount(string firstString, string secondString)
        {
            int totalCount = 0;
            for (int i = 0; i < firstString.Length; i++)
            {
                if (firstString[i].Equals(secondString[i]) && firstString[i].Equals('0'))
                    totalCount += 1;
                else if (firstString[i].Equals(secondString[i]) && firstString[i].Equals('1'))
                    totalCount += 1;

            }
            return (totalCount);
        }
    }
}
