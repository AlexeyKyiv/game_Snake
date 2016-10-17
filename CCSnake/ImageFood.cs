using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CCSnake
{
    class ImageFood
    {
        Image [] redFood = new Image []  { Properties.Resources.FoodRed_1, Properties.Resources.FoodRed_2, Properties.Resources.FoodRed_3, 
                                                Properties.Resources.FoodRed_4, Properties.Resources.FoodRed_5, Properties.Resources.FoodRed_4,
                                                    Properties.Resources.FoodRed_3, Properties.Resources.FoodRed_2, Properties.Resources.FoodRed_1};

        Image [] yellowFood = new Image []  { Properties.Resources.FoodYellow_1, Properties.Resources.FoodYellow_2, Properties.Resources.FoodYellow_3, 
                                                Properties.Resources.FoodYellow_4, Properties.Resources.FoodYellow_5, Properties.Resources.FoodYellow_4,
                                                    Properties.Resources.FoodYellow_3, Properties.Resources.FoodYellow_2, Properties.Resources.FoodYellow_1};

        Image[] blueFood = new Image[] { Properties.Resources.FoodBlue_1, Properties.Resources.FoodBlue_2, Properties.Resources.FoodBlue_3, 
                                                Properties.Resources.FoodBlue_4, Properties.Resources.FoodBlue_5, Properties.Resources.FoodBlue_4,
                                                    Properties.Resources.FoodBlue_3, Properties.Resources.FoodBlue_2, Properties.Resources.FoodBlue_1};

        public Image[] RedFood
        {
            get { return redFood; }
        }
        public Image[] YellowFood
        {
            get { return yellowFood; }
        }
        public Image[] BlueFood
        {
            get { return blueFood; }
        }
    }
}
