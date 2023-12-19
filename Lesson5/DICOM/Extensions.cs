using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public class PathExtension
    {
        private const int LevelsToRootDefault = 3;

        public static string GetParentDirectory(string path, int levels = LevelsToRootDefault)
        {
            for (int i = 0; i < levels; ++i)
            {
                string parent = Path.GetDirectoryName(path);

                if (parent != null)
                {
                    path = parent;
                }
                else break;
            }

            return path;
        }
    }
}
