using System.Collections.Generic;

namespace Aircompany.Planes
{
    public abstract class Plane
    {
        public string Model;
        public int _maxSpeed;
        public int MaxFlightDistance;
        public int MaxLoadCapacity;

        public Plane(string model, int maxSpeed, int maxFlightDistance, int maxLoadCapacity)
        {
            Model = model;
            _maxSpeed = maxSpeed;
            MaxFlightDistance = maxFlightDistance;
            MaxLoadCapacity = maxLoadCapacity;
        }

        public string GetModel()
        {
            return Model;
        }

        public int GetMS()
        {
            return _maxSpeed;
        }

        public int MAXFlightDistance()
        {
            return MaxFlightDistance;
        }

        public int MAXLoadCapacity()
        {
            return MaxLoadCapacity;
        }

        public override string ToString()
        {
            return "Plane{" +
                "model='" + Model + '\'' +
                ", maxSpeed=" + _maxSpeed +
                ", maxFlightDistance=" + MaxFlightDistance +
                ", maxLoadCapacity=" + MaxLoadCapacity +
                '}';
        }

        public override bool Equals(object obj)
        {
            var plane = obj as Plane;
            return plane != null &&
                   Model == plane.Model &&
                   _maxSpeed == plane._maxSpeed &&
                   MaxFlightDistance == plane.MaxFlightDistance &&
                   MaxLoadCapacity == plane.MaxLoadCapacity;
        }

        public override int GetHashCode()
        {
            var hashCode = -1043886837;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Model);
            hashCode = hashCode * -1521134295 + _maxSpeed.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxFlightDistance.GetHashCode();
            hashCode = hashCode * -1521134295 + MaxLoadCapacity.GetHashCode();
            return hashCode;
        }        

    }
}
