﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;

namespace OtsuMethod
{
    class LevelsOfGray64
    {   
        LevelsOfGray256 methods64 =  new LevelsOfGray256();
        static int NGRAY = 64;

        public Bitmap ConvertingToGrayScale(Bitmap bmp)
        {
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
                    ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                int stopAddress = (int)p + bmData.Stride * bmData.Height;
                while ((int)p != stopAddress)
                {
                    p[0] =(byte)((0.299 * p[2]) * 63 / 255 + (0.587 * p[1]) * 63 / 255 + (0.114 * p[0]) * 63 / 255); // convert to 64 levels of gray
                    p[1] = p[0];
                    p[2] = p[0];

                    p += 3;
                }
            }
            bmp.UnlockBits(bmData);
            return bmp;
        }

        public long[] Histogram(System.Drawing.Bitmap picture)
        {
            long[] myHistogram = new long[64];

            for (int i = 0; i < picture.Size.Width; i++)
                for (int j = 0; j < picture.Size.Height; j++)
                {
                    System.Drawing.Color c = picture.GetPixel(i, j);

                    long Temp = 0;
                    Temp += c.R; // red
                    Temp += c.G; // green
                    Temp += c.B; // blue

                    Temp = (int)Temp / 3; 
                    myHistogram[Temp]++;
                }
            return myHistogram;
        }

        public void CalculateValues(float[,] P, float[,] S, float[,] H, long[] h)
        {
          
            for (int j = 0; j < NGRAY; j++)
                for (int i = 0; i < NGRAY; ++i)
                {
                    P[i, j] = 0.0f;
                    S[i, j] = 0.0f;
                    H[i, j] = 0.0f;
                }
         
            for (int i = 1; i < NGRAY; ++i)
            {
                P[i, i] = h[i];
                S[i, i] = ((float)i) * h[i];
            }

            for (int i = 1; i < NGRAY - 1; ++i)
            {
                P[1, i + 1] = P[1, i] + h[i + 1];
                S[1, i + 1] = S[1, i] + ((float)(i + 1)) * h[i + 1];
            }
            
            for (int i = 2; i < NGRAY; i++)
                for (int j = i + 1; j < NGRAY; j++)
                {
                    P[i, j] = P[1, j] - P[1, i - 1];
                    S[i, j] = S[1, j] - S[1, i - 1];
                }
          
            for (int i = 1; i < NGRAY; ++i)
                for (int j = i + 1; j < NGRAY; j++)
                {
                    if (P[i, j] != 0)
                        H[i, j] = (S[i, j] * S[i, j]) / P[i, j];
                    else
                        H[i, j] = 0.0f;
                }

        }
        public float findMaxSigma2classes(float[,] H, int[] t)
        {
            t[0] = 0;
            float maxSig = 0.0f;


            for (int i = 1; i < 64 - 2; i++)
            {

                float Sq = H[1, i] + H[i + 1, 63];
                if (maxSig < Sq)
                {
                    t[1] = i;

                    maxSig = Sq;
                }
            }


            return maxSig;
        }

        public float findMaxSigma3classes(float[,] H, int[] t)
        {

            t[0] = 0;
            float maxSig = 0.0f;


            for (int i = 1; i < 64 - 3; i++)
            {
                for (int j = i + 1; j < 64 - 3 + 1; j++)
                {

                    float Sq = H[1, i] + H[i + 1, j] + H[j + 1, 63];
                    if (maxSig < Sq)
                    {
                        t[1] = i;
                        t[2] = j;
                        maxSig = Sq;
                    }

                }
            }

            return maxSig;
        }

        public float findMaxSigma4classes(float[,] H, int[] t)
        {

            t[0] = 0;
            float maxSig = 0.0f;


            for (int i = 1; i < 64 - 3; i++)
            {
                for (int j = i + 1; j < 64 - 3 + 1; j++)
                {
                    for (int k = j + 1; k < 64 - 3 + 2; k++)
                    {
                        float Sq = H[1, i] + H[i + 1, j] + H[j + 1, k] + H[k + 1, 63];
                        if (maxSig < Sq)
                        {
                            t[1] = i;
                            t[2] = j;
                            t[3] = k;
                            maxSig = Sq;
                        }

                    }
                }
            }


            return maxSig;
        }

        public void Binarization(Bitmap bmp, int[] t)
        {
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                int h = bmp.Height;
                int w = bmp.Width;
                int ws = bmData.Stride;
                ;
                for (int i = 0; i < h; i++)
                {
                    byte* row = &p[i * ws];
                    for (int j = 0; j < w * 3; j += 3)
                    {
                        row[j] = (byte)((row[j] > (byte)t[1]) ? 63 : 0); // when the color number is greater of the threshold , we set the color to 63
                        row[j + 1] = (byte)((row[j + 1] > (byte)t[1]) ? 63 : 0);
                        row[j + 2] = (byte)((row[j + 2] > (byte)t[1]) ? 63 : 0);
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }

        public void Binarization2(Bitmap bmp, int[] t)
        {
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                int h = bmp.Height;
                int w = bmp.Width;
                int ws = bmData.Stride;

                for (int i = 0; i < h; i++)
                {
                    byte* row = &p[i * ws];
                    for (int j = 0; j < w * 3; j += 3)
                    {
                        if (row[j] < (byte)t[1] && row[j + 1] < (byte)t[1] && row[j + 2] < (byte)t[1])
                        {
                            row[j] = 0;
                            row[j + 1] = 0;
                            row[j + 2] = 0;
                        }
                        else if (row[j] > (byte)t[1] && row[j] < (byte)t[2] && row[j + 1] > (byte)t[1] && row[j + 1] < (byte)t[2] && row[j + 2] > (byte)t[1] && row[j + 2] < (byte)t[2])
                        {
                            int g = t[1] + t[2] / 2;
                            row[j] = (byte)g;
                            row[j + 1] = (byte)g;
                            row[j + 2] = (byte)g;
                        }
                        else
                        {
                            row[j] = 63;
                            row[j + 1] = 63;
                            row[j + 2] = 63;
                        }
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }
        public void Binarization3(Bitmap bmp, int[] t)
        {
            BitmapData bmData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height),
            ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* p = (byte*)(void*)bmData.Scan0.ToPointer();
                int h = bmp.Height;
                int w = bmp.Width;
                int ws = bmData.Stride;

                for (int i = 0; i < h; i++)
                {
                    byte* row = &p[i * ws];
                    for (int j = 0; j < w * 3; j += 3)
                    {
                        if (row[j] < (byte)t[1] && row[j + 1] < (byte)t[1] && row[j + 2] < (byte)t[1])
                        {
                            row[j] = 0;
                            row[j + 1] = 0;
                            row[j + 2] = 0;
                        }
                        else if (row[j] > (byte)t[1] && row[j] < (byte)t[2] && row[j + 1] > (byte)t[1] && row[j + 1] < (byte)t[2] && row[j + 2] > (byte)t[1] && row[j + 2] < (byte)t[2])
                        {
                            int g = t[1] + t[2] / 2;
                            row[j] = (byte)g;
                            row[j + 1] = (byte)g;
                            row[j + 2] = (byte)g;
                        }
                        else if (row[j] > (byte)t[2] && row[j] < (byte)t[3] && row[j + 1] > (byte)t[2] && row[j + 1] < (byte)t[3] && row[j + 2] > (byte)t[2] && row[j + 2] < (byte)t[3])
                        {
                            int g = t[2] + t[3] / 2;
                            row[j] = (byte)g;
                            row[j + 1] = (byte)g;
                            row[j + 2] = (byte)g;
                        }
                        else
                        {
                            row[j] = 63;
                            row[j + 1] = 63;
                            row[j + 2] = 63;
                        }
                    }
                }
            }
            bmp.UnlockBits(bmData);
        }
    }
}
