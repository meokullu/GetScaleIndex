﻿using System;

namespace GetScaleIndex
{
    /// <summary>
    /// Scaling integers
    /// </summary>
    public class GetScaleIndex
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
            //TODO: Value should ve indicated as two or more.

            // Checking if value is below two.
            if (height < 2)
            {
                // Throwing an argument to indicate value must be two or higher.
                throw new ArgumentException("height should be more than 2");
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
            //TODO: Value should ve indicated as two or more.

            // Checking if value is below two.
            if (width < 2)
            {
                // Throwing an argument to indicate value must be two or higher.
                throw new ArgumentException("width should be more than 2");
            }

            // Set width parameter.
            s_width = width;
        }

        /// <summary>
        /// Experimental method. [Do not use!]
        /// </summary>
        /// <param name="index">Index position of array.</param>
        /// <returns>Integer array.</returns>
        public static int[] GetIndexFor4x(int index)
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
            //
            int adding = (index / width * customScale * (customScale - 1) * height) + (index * customScale);

            //
            int[] list = new int[customScale * customScale];

            //
            int innerIndex = 0;

            //
            for (int i = 0; i < customScale; i++)
            {
                //
                for (int j = 0; j < customScale; j++)
                {
                    // i: Vertical shift. j: Horizontally shift.
                    list[innerIndex] = adding + (i * customScale * height) + j;

                    //
                    innerIndex++;
                }
            }

            //
            return list;
        }
    }
}