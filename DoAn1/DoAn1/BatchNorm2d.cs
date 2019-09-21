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

        public int Num_features { get => num_features; set => num_features = value; }
        public string Eps { get => eps; set => eps = value; }
        public float Momentum { get => momentum; set => momentum = value; }
        public bool Affine { get => affine; set => affine = value; }
        public bool Track_running_stats { get => track_running_stats; set => track_running_stats = value; }
    }
}
