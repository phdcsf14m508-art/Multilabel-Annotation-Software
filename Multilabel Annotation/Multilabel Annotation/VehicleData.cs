using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilabel_Annotation
{
   public class VehicleData
    {
        public string ImageName;

        public int[] NumberPlateBoundingBox;
        public string NumberPlate;

        public int[] VehicleBoundingBox;
        public string VehicleType;
        public string VehicleMakeModel;
        public string VehicleColour;
        
    }


}
