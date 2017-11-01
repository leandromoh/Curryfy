using System;

namespace Functional
{
    public static partial class Prelude
    {
        public static T TryGetData<T>(this Func<T> getData, Func<T, bool> validateData, Func<T> getFallBackData, int maxTries)
        {
            while (maxTries-- > 0)
            {
                try
                {
                    var data = getData();

                    if (validateData(data))
                    {
                        return data;
                    }
                }
                catch (Exception)
                {

                }
            }

            return getFallBackData();
        }
    }
}