using System;
using System.Collections.Generic;
using System.Reflection;

namespace GetScaleIndex
{
    /// <summary>
    /// Scaling integers
    /// </summary>
    public partial class GetScaleIndex
    {
        // Height
        private static int s_height;

        // Width
        private static int s_width;

        /// <summary>
        /// Set width that will be used for scaling.
        /// </summary>
        /// <param name="height">Height of matrix.</param>
        public static void SetHeight(int height)
        {
            // Checking if value is below two.
            if (height < 2)
            {
                // Throwing an argument to indicate value must be two or higher.
                throw new ArgumentException("Height should be more than 2");
            }

            // Set height parameter.
            s_height = height;
        }

        /// <summary>
        /// Set height that will be used for scaling.
        /// </summary>
        /// <param name="width">Width of matrix.</param>
        public static void SetWidth(int width)
        {
            // Checking if value is below two.
            if (width < 2)
            {
                // Throwing an argument to indicate value must be two or higher.
                throw new ArgumentException("Width should be more than 2");
            }

            // Set width parameter.
            s_width = width;
        }

    }

    /// <summary>
    /// Temporary partial class. All methods will be obsolote under this section.
    /// </summary>
    public partial class GetScaleIndex
    {
        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <param name="index">Index position of array.</param>
        /// <returns>Integer array.</returns>

        public static int[] GetScalingIndexFor4x(int index)
        {
            //
            int offset = (index / s_width * 2 * s_height) + (index * 2);

            //
            int[] list = new int[4];

            //
            int innerIndex = 0;

            //
            for (int i = 0; i < s_height - 1; i++)
            {
                //
                for (int j = 0; j < s_width - 1; j++)
                {
                    //
                    list[innerIndex] = (2 * s_height * i) + offset + j;

                    //
                    innerIndex++;
                }
            }

            return list;
        }

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <param name="index">Index position of array.</param>
        /// <returns>Integer array.</returns>
        public static int[] GetScalingIndexFor9X(int index)
        {
            //
            int adding = (index / s_width * 6 * s_height) + (index * 3);

            //
            int[] list = new int[9]
            {
                adding,
                adding + 1,
                adding + 2,

                adding + (3 * s_height),
                adding + (3 * s_height) + 1,
                adding + (3 * s_height) + 2,

                adding + (6 * s_height),
                adding + (6 * s_height) + 1,
                adding + (6 * s_height) + 2
            };

            //
            return list;
        }

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <param name="index">Index position of array.</param>
        /// <returns>Integer array.</returns>
        public static int[] GetScalingIndexFor16X(int index)
        {
            //
            int adding = (index / s_width * 12 * s_height) + (index * 4);

            //
            int[] list = new int[16]
            {
                //
                adding,
                adding + 1,
                adding + 2,
                adding + 3,

                //
                adding + (4 * s_height),
                adding + (4 * s_height) + 1,
                adding + (4 * s_height) + 2,
                adding + (4 * s_height) + 3,

                //
                adding + (8 * s_height),
                adding + (8 * s_height) + 1,
                adding + (8 * s_height) + 2,
                adding + (8 * s_height) + 3,

                //
                adding + (12 * s_height),
                adding + (12 * s_height) + 1,
                adding + (12 * s_height) + 2,
                adding + (12 * s_height) + 3,
            };

            //
            return list;
        }

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <param name="index">Index position of array.</param>
        /// <returns>Integer array.</returns>
        public static int[] GetScalingIndexFor25X(int index)
        {
            //
            int adding = (index / s_width * 20 * s_height) + (index * 5);

            //
            int[] list = new int[25]
            {
                //
                adding,
                adding + 1,
                adding + 2,
                adding + 3,
                adding + 4,

                //
                adding + (5 * s_height),
                adding + (5 * s_height) + 1,
                adding + (5 * s_height) + 2,
                adding + (5 * s_height) + 3,
                adding + (5 * s_height) + 4,

                //
                adding + (10 * s_height),
                adding + (10 * s_height) + 1,
                adding + (10 * s_height) + 2,
                adding + (10 * s_height) + 3,
                adding + (10 * s_height) + 4,

                //
                adding + (15 * s_height),
                adding + (15 * s_height) + 1,
                adding + (15 * s_height) + 2,
                adding + (15 * s_height) + 3,
                adding + (15 * s_height) + 4,

                //
                adding + (20 * s_height),
                adding + (20 * s_height) + 1,
                adding + (20 * s_height) + 2,
                adding + (20 * s_height) + 3,
                adding + (20 * s_height) + 4,
            };

            //
            return list;
        }

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <param name="index">Index position of array.</param>
        /// <returns>Integer array.</returns>
        public static int[] GetScalingIndexFor36X(int index)
        {
            //
            int adding = (index / s_width * 30 * s_height) + (index * 6);

            //
            int[] list = new int[36]
            {
                //
                adding,
                adding + 1,
                adding + 2,
                adding + 3,
                adding + 4,
                adding + 5,

                //
                adding + (6 * s_height),
                adding + (6 * s_height) + 1,
                adding + (6 * s_height) + 2,
                adding + (6 * s_height) + 3,
                adding + (6 * s_height) + 4,
                adding + (6 * s_height) + 5,

                //
                adding + (12 * s_height),
                adding + (12 * s_height) + 1,
                adding + (12 * s_height) + 2,
                adding + (12 * s_height) + 3,
                adding + (12 * s_height) + 4,
                adding + (12 * s_height) + 5,

                //
                adding + (18 * s_height),
                adding + (18 * s_height) + 1,
                adding + (18 * s_height) + 2,
                adding + (18 * s_height) + 3,
                adding + (18 * s_height) + 4,
                adding + (18 * s_height) + 5,

                //
                adding + (24 * s_height),
                adding + (24 * s_height) + 1,
                adding + (24 * s_height) + 2,
                adding + (24 * s_height) + 3,
                adding + (24 * s_height) + 4,
                adding + (24 * s_height) + 5,

                //
                adding + (30 * s_height),
                adding + (30 * s_height) + 1,
                adding + (30 * s_height) + 2,
                adding + (30 * s_height) + 3,
                adding + (30 * s_height) + 4,
                adding + (30 * s_height) + 5,
            };

            //
            return list;
        }
    }

    public partial class GetScaleIndex
    {
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
            int offset = (index / (width * height) * (customScale * (customScale - 1))) + (index * customScale);

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
                foreach (var item in scalingIndexList)
                {
                    //
                    result[item] = list[i];
                }
            }

            // Returning result
            return result;
        }
    }
}