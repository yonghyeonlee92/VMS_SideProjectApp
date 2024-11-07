using OpenCvSharp;
using OpenCvSharp.XPhoto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace RtspStreamClientApp.Support.Helpers
{
    public class ImageProcess
    {
        public static void ToGray(Mat frame, Mat dst)
        {
            //using Mat gray = new Mat();
            Cv2.CvtColor(frame, dst, ColorConversionCodes.BGR2GRAY);
            //return gray;
        }

        public static Mat CustomFindContours(Mat frame, int Threshold = 100)
        {
            Mat gray = new Mat();
            // Cv2.CvtColor(InputArray src, OutputArray dst, ColorConversionCodes code, int dstCn = 0);
            Cv2.CvtColor(frame, gray, ColorConversionCodes.BGR2GRAY);

            Mat thresh = new Mat();
            // Cv2.Threshold(InputArray src, OutputArray dst, double thresh, double maxval, ThresholdTypes type);
            // ThresholdTypes (Binary = 0, BinaryInv = 1, Trunc = 2, Tozero = 3, TozeroInv = 4, Mask = 7, Otsu = 8, Triangle = 16)
            Cv2.Threshold(gray, thresh, Threshold, 255, ThresholdTypes.Binary);

            // Cv2.FindContours(InputArray image, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes mode, ContourApproximationModes method, Point offset = null);
            Cv2.FindContours(thresh, out var contours, out var hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);
            foreach (var contour in contours)
            {
                if (Cv2.ArcLength(contour, true) < 4000)
                {
                    continue;
                }
                /*
                var approxCurve = new Mat();

                /// <summary>
                /// Cv2.ApproxPolyDP(InputArray curve, OutputArray approxCurve, double epsilon, bool closed);
                /// 꼭지점을 줄이는 함수
                /// </summary>
                /// <param name="curve">입력 컨투어</param>
                /// <param name="approxCurve">출력 근사 컨투어</param>
                /// <param name="epsilon">근사 정확도. 입력 컨투어와 근사 컨투어 사이의 최대 거리.</param>
                /// <param name="closed">폐곡선 여부</param>
                /// Cv2.Arclength(contour, true) : 컨투어의 둘레를 반환

                Cv2.ApproxPolyDP(contour, approxCurve, 0.02 * Cv2.ArcLength(contour, true), true);
                */

                // Cv2.DrawContours(InputOutputArray image, InputArray contours, int contourIdx, Scalar color, int thickness = 1, LineTypes lineType = LineTypes.Link8, InputArray hierarchy = null, int maxLevel = int.MaxValue, Point offset = null);
                //Cv2.DrawContours(frame, new[] { approxCurve }, -1, Scalar.White, 2);
                Cv2.DrawContours(frame, new[] { contour }, -1, Scalar.White, 1);
            }

            return frame;
        }
    }
}
