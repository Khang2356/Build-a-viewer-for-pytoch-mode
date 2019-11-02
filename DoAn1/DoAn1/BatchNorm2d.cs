using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAn1
{
    public class BatchNorm2d : Module 
    {
        private int num_features;
        private string eps;
        private float momentum;
        private bool affine;
        private bool track_running_stats;
        private int x;
        private int y;
        private int dai;
        private int rong;

        public int Num_features { get => num_features; set => num_features = value; }
        public string Eps { get => eps; set => eps = value; }
        public float Momentum { get => momentum; set => momentum = value; }
        public bool Affine { get => affine; set => affine = value; }
        public bool Track_running_stats { get => track_running_stats; set => track_running_stats = value; }
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int Dai { get => dai; set => dai = value; }
        public int Rong { get => rong; set => rong = value; }

        public BatchNorm2d(string name,List<Layer> inputs,List<Layer> outputs,int num_features,string eps,float momentum,bool affine,bool track_running_stats):base(name,inputs,outputs){
            this.num_features = num_features;
            this.eps = eps;
            this.momentum = momentum;
            this.affine = affine;
            this.track_running_stats = track_running_stats;
        }
    }
}
