using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Hornet_Comm
{
    class Program
    {
        static void Main()
        {
            var dictBroadcast = new Dictionary<string,List<string>>();
            var dictMessages = new Dictionary<string,List< string>>();
            var input = Console.ReadLine();
            while (input != "Hornet is Green")
            {
                string[] split = input.Split(new[] {  '<', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var firstQuery = split[0].ToString().Trim();
                var secondQuery = split[1].ToString().Trim();

                bool isRecipientsCode = IsRecipientsCode(firstQuery);
                bool isMessage = IsMessage(firstQuery);
                if (isRecipientsCode)
                {
                    string recipientsCodeFirstQuerry = firstQuery;
                }
                else if (isMessage)
                {
                    string messageFirstQuerry = firstQuery;
                }else
                {
                    continue;
                }
                bool secondQuerryMessageFirstCase = IsSecondQuerryMess(secondQuery);
                bool secondQuerryFrequency = IsSecondQuerryFreq(secondQuery);
                if (secondQuerryMessageFirstCase)
                {
                    string sqMessage = secondQuery.ToString();
                    ReverseString(sqMessage);
                }
                else if (secondQuerryFrequency)
                {
                    string sqFreq = secondQuery;
                    for (int i = 0; i < sqFreq.Length; i++)
                    {
                        if ((int)sqFreq[i]< 96)
                        {
                            sqFreq[i].ToString().ToUpper();
                        }else
                        {
                            sqFreq[i].ToString().ToLower();
                        }
                    }
                }
                if (isRecipientsCode && secondQuerryMessageFirstCase)
                {
                    var sqMessage = ReverseString(secondQuery);
                    var list = new List<string>();
                    list.Add(sqMessage);
                    dictMessages.Add(firstQuery, list);
                }
                else if (isMessage && secondQuerryFrequency)
                {
                    var list = new List<string>();
                    list.Add(firstQuery);
                    dictBroadcast.Add(secondQuery, list);
                }

                input = Console.ReadLine();
            }
                Console.WriteLine("Broadcast:");
            foreach (var kvp in dictBroadcast)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");

            }
                Console.WriteLine("Messages:");
            foreach (var kvp in dictMessages)
            {
                Console.WriteLine($"{kvp.Value} -> {kvp.Key} ");
            }
        }

        private static bool IsSecondQuerryFreq(string secondQuery)
        {
            string secondQuerryPattern = @"[A-Za-z]+|[0-9A-Za-z]+";
            var regex = new Regex(secondQuerryPattern);
            if (regex.IsMatch(secondQuery))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static string ReverseString(string maet)
        {

            string team = "";
            for (int i = maet.Length - 1; i >= 0; i--)
            {
                team += maet[i];

            }

            return team;
        }

        private static bool IsSecondQuerryMess(string secondQuery)
        {
            string secondQuerryPattern = @"[0-9A-Za-z]+|[A-Za-z]";
            var regex = new Regex(secondQuerryPattern);
            if (regex.IsMatch(secondQuery))
            {
                return true;
            }
            else
            {
                return false;
            }
        
        }

        private static bool IsMessage(string firstQuery)
        {
            var firstQuerryPatterAnythingButDig = @"\D+";
            var regex = new Regex(firstQuerryPatterAnythingButDig);
            if (regex.IsMatch(firstQuery))
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }

        private static bool IsRecipientsCode(string firstQuery)
        {
            var firstQueryPatternForDigitsOnly = @"\d+";
            var regexDigits = new Regex(firstQueryPatternForDigitsOnly);
            if (regexDigits.IsMatch(firstQuery))
            {
                return true;
            }
            
            {
                return false;
            }

        }
        private static void secondQueryRegex(string secondQuery)
        {

        }
        // da zapazq algorit

    }
}
