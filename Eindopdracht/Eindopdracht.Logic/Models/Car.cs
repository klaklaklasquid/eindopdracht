using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eindopdracht.Logic.Models {
    public class Car {
        private int _id;

        public int Id {
            get { return _id; }
            set {
                _id = value;
            }
        }

        private string _nummerplaat;

        public string Nummerplaat {
            get { return _nummerplaat; }
            set { _nummerplaat = value; }
        }

        private string _model;

        public string Model {
            get { return _model; }
            set { _model = value; }
        }

        private int _zitplaatsen;

        public int Zitplaatsen {
            get { return _zitplaatsen; }
            set { _zitplaatsen = value; }
        }

        private string _motortype;

        public string Motortype {
            get { return _motortype; }
            set { _motortype = value; }
        }

        public Car(int id, string nummerplaat, string model, int zitplaatsen, string motortype) {
            Id = id;
            Nummerplaat = nummerplaat;
            Model = model;
            Zitplaatsen = zitplaatsen;
            Motortype = motortype;
        }

        public override bool Equals(object? obj) {
            return obj is Car car &&
                   Id == car.Id;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Id);
        }
    }
}
