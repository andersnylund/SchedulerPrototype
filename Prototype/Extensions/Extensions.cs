using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Prototype.Objects;

namespace Prototype.Extensions
{
    /// <summary>
    /// Static class containing extensions
    /// </summary>
    public static class Extensions
    {
        static Extensions()
        {
            Rand = new Random();
        }

        /// <summary>
        /// Static random for tight for-loops. Use this random for everything that needs to be random
        /// </summary>
        public static Random Rand;

        /// <summary>
        /// Deepclones the object
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj">Object to clone</param>
        /// <returns>The deepcloned object</returns>
        public static T DeepClone<T>(T obj)
        {
            using (var ms = new MemoryStream())
            {
                var formatter = new BinaryFormatter();
                formatter.Serialize(ms, obj);
                ms.Position = 0;

                return (T)formatter.Deserialize(ms);
            }
        }

        /// <summary>
        /// Save a timeperiod to a binary file
        /// </summary>
        /// <param name="obj">The timeperiod that will be saved</param>
        /// <param name="fileName">Location where the files are saved</param>
        public static void SaveObjectToFile(TimePeriod obj, string fileName)
        {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, obj);
                stream.Close();
        }

        /// <summary>
        /// Opens a timeperiod from the specified file
        /// </summary>
        /// <param name="fileName">The filepath of the file</param>
        /// <returns></returns>
        public static TimePeriod OpenObjectFromFile(string fileName)
        {
            Stream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.None);
            IFormatter formatter = new BinaryFormatter();
            object obj = formatter.Deserialize(stream);
            stream.Close();

            return (TimePeriod)obj;
        }

        /// <summary>
        /// Shuffles a list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static List<T> Shuffle<T>(this IList<T> list)
        {
            // http://stackoverflow.com/questions/5383498/shuffle-rearrange-randomly-a-liststring

            int n = list.Count;
            while (n > 1)
            {
                int k = (Rand.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }

            return (List<T>)list;
        }
    }
}
