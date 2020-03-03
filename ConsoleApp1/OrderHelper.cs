using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public static class OrderHelper
    {
        public static short[] FirstShot(short[] inputValues)
        {
            short winner = 0;
            short times;
            short winnerTimes = 0;
            List<short> orderNumbers = new List<short>();

            while (inputValues.Length > 0)
            {
                winnerTimes = 0;
                foreach (var number in inputValues)
                {
                    times = 0;
                    foreach (var numberIndex in inputValues)
                    {
                        if (number == numberIndex) times++;
                    }
                    if (times > winnerTimes)
                    {
                        winner = number;
                        winnerTimes = times;
                    }
                    if (times == winnerTimes)
                    {
                        if (number > winner) winner = number;
                    }
                }

                orderNumbers.Add(winner);
                inputValues = inputValues.Where(val => val != winner).ToArray();
            }

            return orderNumbers.ToArray();
        }

        public static short[] SecondShot(short[] inputValues)
        {
            Dictionary<short, short> orderNumbers2 = new Dictionary<short, short>();

            foreach (var indexer in inputValues)
            {
                //orderNumbers2.Add(valor, veces)
                short outValue; 
                if (orderNumbers2.TryGetValue(indexer,out outValue))//solo entra cuando ya se encuentra el indexer en el diccionario
                {
                    outValue++;
                    orderNumbers2[indexer] = outValue;
                }
                else
                {
                    orderNumbers2.Add(indexer, 1);
                }               
            }

            return orderNumbers2.OrderByDescending(x => x.Value)
                    .ThenByDescending(x => x.Key)
                    .Select(x => x.Key).ToArray();
        }

        public static short[] ThirdShot(short[] inputValues)
        {
            return inputValues.GroupBy(x => x)
                    .ToDictionary(x => x.Key, x => x.Count())
                    .OrderByDescending(x => x.Value)
                    .ThenByDescending(x => x.Key)
                    .Select(x => x.Key).ToArray();
        }

        public static bool IsSortedDescending(int[] arr)
        {
            for (int i = arr.Length - 2; i >= 0; i--)
            {
                if (arr[i] < arr[i + 1])
                {
                    return false;
                }
            }
            return true;
        }

        public static bool GetCorrectString(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException();
            }

            if (value.Length > 20)
            {
                throw new ArgumentException();
            }

            if (value == "Valor no permitido")
            {
                return false;
            }

            return true;
        }

    }
}
