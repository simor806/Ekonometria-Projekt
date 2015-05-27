using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MethodOfGraphs;
using Microsoft.Glee.Drawing;
using Microsoft.Glee.GraphViewerGdi;
using System.Windows.Forms;

namespace ekonometria1 {
    public class GraphicalRepresentation {

        public GViewer view;
        public Graph g;
        public DataReader dr;
        public Calculations c;
        public double alfa=0.05;
        public string fileName;

        public GraphicalRepresentation(string fileName) {
            this.fileName= fileName;
            this.view = new GViewer();
            this.g = new Graph("graph");
            this.dr = new DataReader(fileName);
            this.c = new Calculations(fileName);
        }

        public void DrawingGraph(double alfa) {
            Form f = new Form();
            double[,] R = c.VerificationOfTheHypothesis(alfa);

            Node nodeX1 = (Node)g.AddNode("x1");
            nodeX1.Attr.Fillcolor = Color.AliceBlue;
            nodeX1.Attr.Fontsize = 8;

            Node nodeX2 = (Node)g.AddNode("x2");
            nodeX2.Attr.Fillcolor = Color.AliceBlue;
            nodeX2.Attr.Fontsize = 8;

            Node nodeX3 = (Node)g.AddNode("x3");
            nodeX3.Attr.Fillcolor = Color.AliceBlue;
            nodeX3.Attr.Fontsize = 8;

            if (R[1, 0] != 0) {
                Edge x1x2 = (Edge)g.AddEdge("x1", "x2");
                x1x2.Attr.ArrowHeadAtTarget = ArrowStyle.None;
            }
            if (R[2, 0] != 0) {
                Edge x1x3 = (Edge)g.AddEdge("x1", "x3");
                x1x3.Attr.ArrowHeadAtTarget = ArrowStyle.None;
            }
            if (R[2, 1] != 0) {
                Edge x2x3 = (Edge)g.AddEdge("x2", "x3");
                x2x3.Attr.ArrowHeadAtTarget = ArrowStyle.None;
            }
            view.Graph = g;
            f.SuspendLayout();
            view.Dock = DockStyle.Fill;
            f.Controls.Add(view);
            f.ResumeLayout();
            f.ShowDialog();

        }
    }
}
