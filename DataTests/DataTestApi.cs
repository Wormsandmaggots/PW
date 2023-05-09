﻿using Data;

namespace DataTests
{
    public abstract class CreateDataTestApi
    {
        public static AbstractDataApi GetDataTestApi()
        {
            return new DataTestApi();
        }
    }

    internal sealed class DataTestApi : AbstractDataApi
    {
        public override IBall CreateBall(int x, int y, int radius, int width, int height)
        {
            return new TestBall(x, y, radius, width, height);
        }
    }
}
