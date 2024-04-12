using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GetScaleIndex
{
    public partial class GetScaleIndex
    {
        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="customScale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static List<T> ApplyScale<T>(List<T> list, int width, int height, int customScale)
        {
            if (width != height)
            {
                throw new NotSupportedException("width and height should be match for current version.");
            }

            //
            List<T> result = new List<T>(list.Count * customScale * customScale);

            //
            for (int i = 0; i < list.Count * customScale * customScale; i++)
            {
                //
                result.Add(list[0]);
            }

            //
            for (int i = 0; i < list.Count; i++)
            {
                //
                int[] scalingIndexList = GetCustomScalingIndex(index: i, width: width, height: height, customScale: customScale);

                //
                foreach (int item in scalingIndexList)
                {
                    //
                    result[item] = list[i];
                }
            }

            // Returning result
            return result;
        }

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="customScale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static T[] ApplyScale<T>(T[] array, int width, int height, int customScale)
        {
            //
            T[] result = new T[array.Length * customScale * customScale];

            //
            for (int i = 0; i < array.Length; i++)
            {
                //
                int[] scalingIndexList = GetCustomScalingIndex(index: i, width: width, height: height, customScale: customScale);

                //
                for (int j = 0; j < scalingIndexList.Length; j++)
                {
                    //
                    result[scalingIndexList[j]] = array[i];
                }
            }

            //
            return result;
        }

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="customScale"></param>
        /// <param name="parallelOptions"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static T[] ApplyScale<T>(T[] array, int width, int height, int customScale, ParallelOptions parallelOptions)
        {
            //
            T[] result = new T[array.Length * customScale * customScale];

            _ = Parallel.For(0, array.Length, parallelOptions: parallelOptions, x =>
            {
                //
                int[] scalingIndexList = GetCustomScalingIndex(index: x, width: width, height: height, customScale: customScale);

                //
                for (int j = 0; j < scalingIndexList.Length; j++)
                {
                    //
                    result[scalingIndexList[j]] = array[x];
                }
            });

            //
            return result;
        }

        // Width

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="widthScale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static T[] ApplyScaleByWidth<T>(T[] array, int width, int height, int widthScale)
        {
            //
            T[] result = new T[array.Length * widthScale];

            //
            for (int i = 0; i < array.Length; i++)
            {
                //
                int[] scalingIndexList = GetScaleIndexByWidth(index: i, width: width, height: height, widthScale: widthScale);

                //
                for (int j = 0; j < scalingIndexList.Length; j++)
                {
                    //
                    result[scalingIndexList[j]] = array[i];
                }
            }

            //
            return result;
        }

        // Height

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="array"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="heightScale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static T[] ApplyScaleByHeight<T>(T[] array, int width, int height, int heightScale)
        {
            //
            T[] result = new T[array.Length * heightScale];

            //
            for (int i = 0; i < array.Length; i++)
            {
                //
                int[] scalingIndexList = GetScaleIndexByHeight(index: i, width: width, height: height, heightScale: heightScale);

                //
                for (int j = 0; j < scalingIndexList.Length; j++)
                {
                    //
                    result[scalingIndexList[j]] = array[i];
                }
            }

            //
            return result;
        }
    }
}