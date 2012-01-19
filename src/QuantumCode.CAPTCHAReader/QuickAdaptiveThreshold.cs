using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantumCode.CAPTCHAReader
{
    /// <summary>
    /// 快速自适应阀值算法
    /// 该方法来自于：http://www.xrce.xerox.com/Publications/Attachments/1993-110/EPC-1993-110.pdf
    /// </summary>
    public class QuickAdaptiveThreshold : IThresholdingAlgorithm
    {
        #region IThresholdAlgorithm Members

        /// <summary>
        ///  
        ///            | FOREGROUND, if pn < ((gs(n) + gs(n-w)) / (2*s)) * ((100-t)/100)
        /// color(n) = |                      
        ///            | BACKGROUND_QR, otherwise 
        ///            
        /// where pn = gray value of current pixel, 
        ///        s = width of moving average, and 
        ///        t = threshold percentage of brightness range 
        ///    gs(n) = gs(n-1) * (1-1/s) + pn 
        ///    gs(n-w) = gs-value of pixel above current pixel 
        /// 
        ///  
        /// </summary>
        /// <param name="grayscale"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public byte[] ComputeThreshold(byte[] grayscale, int width, int height)
        {
            int t = 15;   
            int s = width >> 3; // s: number of pixels in the moving average (w = image width)  
            const int S = 9; // integer shift, needed to avoid floating point operations  
            const int power2S = 1 << S;  
            // for speedup: multiply all values by 2^s, and use integers instead of floats  
            int factor = power2S * (100-t) / (100*s); // multiplicand for threshold  
            int gn = 127 * s; // initial value of the moving average (127 = average gray value)  
            int q = power2S - power2S / s; // constant needed for average computation  
            int pn, hn;
            byte scanline;  
            int[] prev_gn = null;  
                  
            prev_gn = new int[width];
  
            for (int i = 0; i < width; i++) {  
                prev_gn[i] = gn;  
            }
  
            byte[] thres;

            thres = new byte[width * height];

            for (int y = 0; y < height; y ++ )  
            {  
                int yh = y * width;

                for ( int x = 0; x <width; x ++ )  
                {
                    scanline = grayscale[yh + x];
                    pn = scanline ;  
                    gn = ((gn * q) >> S) + pn;   
                    hn = (gn + prev_gn[x]) >> 1;  
                    prev_gn[x] = gn;
                    thres[yh + x] = (byte)(pn < (hn * factor) >> S ? 0 : 0xff);
                }
  
                y++;
  
                if ( y == height)  
                    break; 

                yh = y * width;  

                for ( int x = width-1; x >= 0; x --)  
                {
                    scanline = grayscale[yh + x];
                    pn = scanline; 
                    gn = ((gn * q) >> S) + pn;   
                    hn = (gn + prev_gn[x]) >> 1;  
                    prev_gn[x] = gn;
                    thres[yh + x] = (byte)(pn < (hn * factor) >> S ? 0 : 0xff); 
                }  
            }

            return thres;
        }

        #endregion
    }
}
