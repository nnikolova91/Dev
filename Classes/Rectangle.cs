using System;

namespace Classes
{
    public class Rectangle //: IShape
    {
        public string Id { get; set; }
        public int Width { get; set; }
        public int Heigth { get; set; }

        public int Cordin1 { get; set; }
        public int Cordin2 { get; set; }


        public bool Intersect(Rectangle rec1,Rectangle rec2)
        {
            //int cor1NaPurvi = rec1.Cordin1 + rec1.Width;
            //int cor2NaPurvi = rec1.Cordin2 + rec1.Heigth;
            To4ka tGoreLqvo = new To4ka();
            tGoreLqvo.X = rec1.Cordin1;
            tGoreLqvo.Y = rec1.Cordin2;

            To4ka tGoreDqsno = new To4ka();
            tGoreDqsno.X = rec1.Cordin1+ rec1.Width;
            tGoreDqsno.Y = rec1.Cordin2;

            To4ka tDoluLqvo = new To4ka();
            tDoluLqvo.X = rec1.Cordin1;
            tDoluLqvo.Y = rec1.Cordin2-rec1.Heigth;

            To4ka tDoluDqsno = new To4ka();
            tDoluDqsno.X = rec1.Cordin1 + rec1.Width;
            tDoluDqsno.Y = rec1.Cordin2-rec1.Heigth;
            //point.X>= topLeft.X && point.X<=BottmRight.X && 
            //point.Y<=TopLeft.Y && point.Y>=BottumRight.Y ||
            //point.Y>TL.Y && point.X
            
            if ((Math.Max(rec1.Cordin1+ rec1.Width, rec2.Cordin1+rec2.Width)- Math.Min(rec1.Cordin1+rec1.Width, rec2.Cordin1+rec2.Width)<=rec1.Width && Math.Max(rec1.Cordin2+rec1.Heigth, rec2.Cordin2+rec2.Heigth) - Math.Min(rec1.Cordin2+rec1.Heigth, rec2.Cordin2+rec2.Heigth) <=rec1.Heigth ) ||
                (Math.Max(rec1.Cordin1, rec2.Cordin1) - Math.Min(rec1.Cordin1, rec2.Cordin1) >= rec2.Width && Math.Max(rec1.Cordin2, rec2.Cordin2) - Math.Min(rec1.Cordin2, rec2.Cordin2) >= rec2.Heigth))
            {
                return true;
            }
            else
            {
                return false;
            }
            //if ((rec1.Cordin2<=rec2.Cordin2 && rec1.Cordin2>=rec2.Cordin2-rec2.Heigth && rec1.Cordin1+rec1.Width>rec2.Cordin2)
            //    || (rec1.Cordin1 == rec2.Cordin1 && rec1.Cordin2 == rec2.Cordin2) ||
            //    (rec1.Cordin2-rec1.Heigth <= rec2.Cordin2 && rec1.Cordin2 - rec1.Heigth > rec2.Cordin2 - rec2.Heigth && rec1.Cordin1 + rec1.Width > rec2.Cordin2))
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}

        }
        public class To4ka
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        //public void Draw()
        //{
        //    for (int i = 0; i < Heigth; i++)
        //    {
        //        if (i == 0 || i == Heigth - 1)
        //        {
        //            Console.WriteLine($"|{new string('-', Width)}|");
        //        }
        //        else
        //        {
        //            Console.WriteLine($"|{new string(' ', Width)}|");
        //        }
        //    }
        //}
    }
}
