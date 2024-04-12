using System;
using System.Collections.Generic;

namespace GetScaleIndex
{
    public partial class GetScaleIndex
    {
        #region List

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="widthScale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] GetScaleIndexByWidth(int[] list, int width, int height, int widthScale)
        {
            //
            int[] result = new int[width * height * widthScale];

            int index = 0;

            //
            for (int i = 0; i < list.Length; i++)
            {
                //
                for (int j = 0; j < widthScale; j++)
                {
                    //
                    result[index] = list[i];

                    //
                    index++;
                }
            }

            //
            return result;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="heightScale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] GetScaleIndexByHeight(int[] list, int width, int height, int heightScale)
        {
            //
            List<int> result = new List<int>();

            //
            for (int i = 0; i < list.Length / width; i++)
            {
                //
                for (int j = 0; j < width; j++)
                {
                    //
                    for (int z = 0; z < heightScale; z++)
                    {
                        result.Add(list[i]);
                    }
                }
            }

            //
            throw new NotImplementedException();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] GetScaleIndexByDiagonal(int[] list, int width, int height, int scale)
        {
            //
            List<int> result = new List<int>();

            //
            for (int i = 0; i < scale; i++)
            {
                //
                for (int j = 0; j < width; j++)
                {

                }
            }

            //
            throw new NotImplementedException();
        }

        #endregion List

        #region Point

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="widthScale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] GetScaleIndexByWidth(int index, int width, int height, int widthScale)
        {
            //
            int[] scaledList = new int[width * height * widthScale];

            //
            int innerIndex = 0;

            //
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    for (int z = 0; z < widthScale; z++)
                    {
                        scaledList[innerIndex] = ((i * width) * j) + z;

                        //
                        innerIndex++;
                    }
                }
            }

            //
            return scaledList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="heightScale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] GetScaleIndexByHeight(int index, int width, int height, int heightScale)
        {
            //
            int offset = (index * heightScale);

            //
            int[] scaledList = new int[width * height * heightScale];

            //
            int innerIndex = 0;

            //
            for (int i = 0; i < heightScale; i++)
            {
                //
                for (int j = 0; j < heightScale; j++)
                {
                    //
                    scaledList[innerIndex] = offset + j;
                }
            }

            //
            return scaledList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="scale"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static int[] GetScaleIndexByDiagonal(int index, int width, int height, int scale)
        {
            //
            int[] scaledList = new int[width * height * scale * scale];

            //
            throw new NotImplementedException();
        }

        #endregion Point

        #region Old methods

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <param name="index">Index position of array.</param>
        /// <param name="width">Width of matrix.</param>
        /// <param name="height">Height of matrix.</param>
        /// <param name="customScale">Scaling</param>
        /// <returns>Integer array.</returns>
        public static int[] GetCustomScalingIndex(int index, int width, int height, int customScale)
        {
            if (width != height)
            {
                throw new NotSupportedException("width and height should be match for current version.");
            }

            //
            int offset = (index / width * customScale * (customScale - 1) * height) + (index * customScale);

            //
            int[] scaledList = new int[customScale * customScale];

            //
            int innerIndex = 0;

            //
            for (int i = 0; i < customScale; i++)
            {
                //
                for (int j = 0; j < customScale; j++)
                {
                    // i: Vertical shift. j: Horizontally shift.
                    scaledList[innerIndex] = offset + (i * customScale * height) + j;

                    //
                    innerIndex++;
                }
            }

            //
            return scaledList;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <param name="customScale"></param>
        /// <returns></returns>
        public static int[] GetCustomScalingIndex(int[] list, int width, int height, int customScale)
        {
            //
            int[] scaledList = new int[list.Length * customScale * customScale];

            //
            int offset;

            //
            int innerIndex = 0;

            //
            for (int i = 0; i < list.Length; i++)
            {
                //
                offset = (i / width * height * (customScale * (customScale - 1))) + (i * customScale);

                //
                for (int j = 0; j < customScale; j++)
                {
                    //
                    for (int m = 0; m < customScale; m++)
                    {
                        //
                        scaledList[innerIndex] = offset + (j * customScale * height) + m;

                        //
                        innerIndex++;
                    }
                }
            }

            //
            return scaledList;
        }

        #endregion Old methods
    }
}
