using System;
using System.Collections.Generic;

namespace ConstructorSampe
{
    ///<summary>
    ///三角形
    ///</summary>

    class Triangle
    {
        private float width;
        private float height;
        private float[] sideLength = new float[3];
        private float surface;

        ///<summary>
        ///コンストラクタ
        ///</summary>
        ///<param name="w">幅</param>
        ///<param name="h">高さ</param>
        public Triangle(float w, float h)
        {
            this.width = w;
            this.height = h;
        }

        ///<summary>
        ///コンストラクタ
        ///</summary>
        ///<param name="a">辺A</param>
        ///<param name="b">辺B</param>
        ///<param name="c">辺C</param>
        public Triangle(float a, float b, float c)
        {
            sideLength[0] = a;
            sideLength[1] = b;
            sideLength[2] = c;

            //ヘロンの公式で面積を求める
            float s = (sideLength[0] + sideLength[1] + sideLength[2]) / 2;
            surface = MathF.Sqrt(s * (s - sideLength[0]) * (s - sideLength[1]) * (s - sideLength[2]));
          
        }

        ///<summary>
        ///面積を取得
        ///</summary>
        ///<returns>面積</returns>
        public float GetSurface()
        {
            return surface;
            //return width * height/2;
        }

    }
}
