using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graph_SearchPath;

namespace Graph_SearchPath
{
    public class Path
    {
        public Double val;
        public ArrayList<Int32> vseq;

        public Path(Double len, ArrayList<Int32> vseq)
        {
            this.val = len;
            this.vseq = (ArrayList<Int32>)vseq.Clone();
        }

        public Path(Path p)
        {
            this.val = p.val;
            this.vseq = (ArrayList<Int32>)p.vseq.Clone();
        }


        public Double subLen(int len, Double[][] weightEdge)
        {
            double sublen = 0;
            for (int i = 0; i < len - 1; i++)
                sublen += weightEdge[vseq.get(i)][vseq.get(i + 1)];
            return sublen;
        }


        public static void blockVertex(Double[][] weightEdge, Int32 index)
        {
            Int32 vnum = weightEdge.Length;
            for (int i = 0; i < vnum; i++)
                weightEdge[i][index] = Double.MaxValue;
            for (int i = 0; i < vnum; i++)
                weightEdge[index][i] = Double.MaxValue;
        }

        public static void blockEdge(Double[][] weightEdge, Int32 vout, Int32 vin)
        {
            weightEdge[vout][vin] = Double.MaxValue;
        }

        public void blockRoot(Double[][] weightEdge, Int32 rootLen)
        {
            for (int i = 0; i < rootLen - 1; i++) blockVertex(weightEdge, vseq.get(i));
        }

        override public String ToString()
        {
            return val + " - " + vseq.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != typeof(Path)) return false;
            if ((((Path)obj).val == val)) 
            if ((((Path)obj).vseq.Equals(vseq))) return true;
            return false;

        }


        //override public int GetHashCode()
        //{
        //    return Object. (val, vseq);
        //}


    }
}