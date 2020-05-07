using QuizScoreTracker.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizScoreTracker
{
    public static class Extensions
    {
        public static void UpdateImage(this PictureBox pictureBox, int newValue)
        {
            pictureBox.Image = GetTallyImage(newValue);
            pictureBox.Tag = newValue;
            pictureBox.Refresh();
        }

        public static int IndexOfFirst(this ComboBox.ObjectCollection collection, Func<string, bool> predicate)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                if (predicate((string)collection[i]))
                {
                    return i;
                }
            }

            return 0;
        }

        private static Image GetTallyImage(int score)
        {
            switch (score)
            {
                case 5: return Resources.five;
                case 4: return Resources.four;
                case 3: return Resources.three;
                case 2: return Resources.two;
                default: return Resources.one;
            }
        }
    }
}