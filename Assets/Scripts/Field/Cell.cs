using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace genField
{
    class Cell
    {
        private int state = 0;
        private int id = 0;
        private int randomNum = 0;

        //public Color normCol;
        //public Color partiesCol;

        public Cell() { }
        public Cell(int state) { this.state = state; }

        public int getId() { return id; }
        public int getRandomNum() { return randomNum; }
        public int getState() { return state; }

        public void setId(int id) { this.id = id; }
        public void setRandomNum(int randomNum) { this.randomNum = randomNum; }
        public void setState(int state)
        {
            this.state = state;
            if (this.state == 0)
            {
                //GetComponent<Image>().color = normCol;
            }
            else if (this.state == 1)
            {
                //GetComponent<Image>().color = partiesCol;
                /*
                Image button = GetComponent<Image>();
                String path = "image/file" + randomNum.ToString();
                button.color = new Color32(255, 255, 255, 255);
                button.sprite = Resources.Load<Sprite>(path);
                */
            }
        }
    }
}
