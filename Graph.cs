using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Graph_SearchPath;
using System.Drawing;

public class Graph
{

    public Double[][] weightEdge;

    public Graph(Double[][] weightEdge)
    {
        int vnum = weightEdge.Length;
        this.weightEdge = new Double[vnum][];
        for (int i = 0; i < vnum; i++)
        {
            this.weightEdge[i] = new Double[vnum];
        }
        System.Array.Copy(weightEdge, 0, this.weightEdge, 0, vnum);
    }

    public ArrayList<Path> getShortestPath(Int32 start, Int32 target)
    {
        return getShortestPath(start, target, weightEdge);
    }

    public ArrayList<Path> getShortestPath(Int32 start, Int32 target, Double[][] weightEdge)
    {
        int vnum = weightEdge.Length;
        Double[] valueMark = new Double[vnum];
        ArrayUtil.fill(valueMark, Double.MaxValue);
        valueMark[start] = 0.0;
        Boolean[] constMark = new Boolean[vnum];
        ArrayUtil.fill(constMark, false);
        constMark[start] = true;
        Int32 vcurr = start; //текущая вершиная по алгориитму Дейкстры
        Double minLength = Double.MaxValue;
        for (int i = 0; i < vnum; i++)
        {
            int minMark = -1;
            Double minValMark = Double.MaxValue;
            for (int j = 0; j < vnum; j++)
            {
                if (constMark[j]) continue;
                valueMark[j] = Math.Min(valueMark[j], valueMark[vcurr] + weightEdge[vcurr][j]);
                if (valueMark[j] < minValMark)
                {
                    minMark = j;
                    minValMark = valueMark[j];
                }
            }
            if (minMark < 0) return new ArrayList<Path>();
            constMark[minMark] = true;
            vcurr = minMark;
            if (minMark == target)
            {
                minLength = minValMark;
                break;
            }
        }
        ArrayList<Path> spaths = new ArrayList<Path>();
        spaths.add(getPrevVertex(vcurr, new Path(minLength, 
            new ArrayList<Int32>()), spaths, valueMark, vnum, weightEdge));
        return spaths;
    }

    public Path getPrevVertex(int v, Path prevPath,
        ArrayList<Path> pathList, Double[] valueMark, int vnum, Double[][] weightEdge)
    {
        ArrayList<Int32> prevVertex = new ArrayList<Int32>();
        Path path = new Path(prevPath);
        if (valueMark[v] == 0)
        {
            path.vseq.add(0, v);
            return path;
        }
        for (int i = 0; i < vnum; i++)
        {
            if ((v != i) && (valueMark[v] - weightEdge[i][v] == valueMark[i]))
                prevVertex.add(0, i);
        }
        int len = prevVertex.size();
        path.vseq.add(0, v);
        for (int i = 0; i < len; i++)
        {
            if (i != len - 1) pathList.add(getPrevVertex(
                prevVertex.get(i), path, pathList, valueMark, vnum, weightEdge));
            return getPrevVertex(prevVertex.get(len - 1),
                path, pathList, valueMark, vnum, weightEdge);
        }
        return null;
    }

    public ArrayList<Path> getShortestPath(Int32 start, Int32 target, Int32 number)
    {
        ArrayList<Path> L0, L, P;
        HashSet<Path> L1;
        L = new ArrayList<Path>(getShortestPath(start, target));
        if (L.size() >= number)
            return new ArrayList<Path>(L.subList(0, number));

        if(L.size() == 0) return new ArrayList<Path>();

        L0 = new ArrayList<Path>(L.subList(0, 1));
        L1 = new HashSet<Path>(L.subList(1, L.size()).ToArray());
        P = new ArrayList<Path>(L0);

        for (int k = 1; k < number; k++)
        {
            Path[] paths = getPathDeviations(P.get(k - 1), P).ToArray();
            foreach(Path p in paths){
                bool b = true;
                foreach (Path l in L1) if (p.Equals(l)) { b = false; break; }
                if(b) L1.Add(p);
            }
            double minLen = Double.MaxValue;
            Path shortestL1 = null;
            foreach (Path p in L1)
                if (p.val < minLen)
                {
                    minLen = p.val;
                    shortestL1 = p;
                }

            if (shortestL1 == null) break;
            L0.add(shortestL1);
            P.add(shortestL1);
            L1.Remove(shortestL1);
        }

        return L0;
    }

    public ArrayList<Path> getPathDeviations(Path direct, ArrayList<Path> P)
    {
        int vnum = weightEdge.Length;
        ArrayList<Path> devpath = new ArrayList<Path>();
        Int32 pathVnum = direct.vseq.size();
        for (int i = 1; i <= pathVnum - 1; i++)
        {
            Double[][] restrictWeightEdge = new Double[vnum][];
            for (int q = 0; q < vnum; q++)
            {
                restrictWeightEdge[q] = new Double[vnum];
                for (int w = 0; w < vnum; w++)
                    restrictWeightEdge[q][w] = weightEdge[q][w];
            }
            direct.blockRoot(restrictWeightEdge, i);
            for (int j = 0; j < P.length; j++)
            {
                if (P.get(j).vseq.size() >= i && direct.vseq.subList(0, i).Equals(P.get(j).vseq.subList(0, i)))
                    Path.blockEdge(restrictWeightEdge, P.get(j).vseq.get(i - 1), P.get(j).vseq.get(i));
            }

            ArrayList<Path> newDevpath = new ArrayList<Path>(getShortestPath(direct.vseq.get(i - 1),
                    direct.vseq.get(direct.vseq.size() - 1), restrictWeightEdge));
            Double sublen = direct.subLen(i, weightEdge);
            for (int j = 0; j < newDevpath.length; j++)
            {
                newDevpath.get(j).vseq.addAll(0, direct.vseq.subList(0, i - 1).ToArray());
                newDevpath.get(j).val += sublen;
            }

            devpath.addAll(newDevpath.ToArray());

        }

        return devpath;
    }

    public int getVertexNum()
    {
        return weightEdge.Length;
    }


    
    

}