using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuantumCode.CAPTCHAReader
{
    /// <summary>
    /// 阀值算法接口，用于计算图像阀值，返回二值化图像
    /// </summary>
    public interface IThresholdAlgorithm
    {
        /// <summary>
        /// 计算阀值
        /// </summary>
        /// <param name="grayscale">输入的灰度</param>
        /// <param name="width">图像宽度</param>
        /// <param name="height">图像高度</param>
        /// <returns></returns>
        byte[] ComputeThreshold(byte[] grayscale, int width, int height);
    }
}
